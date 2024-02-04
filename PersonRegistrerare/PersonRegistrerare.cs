namespace PersonRegistrerare
{
    public partial class PersonRegistrerare : Form
    {
        public PersonRegistrerare()
        {
            InitializeComponent();
            // Vi lyssnar h�r p� key-press f�r att kunna s�ga till n�r anv�ndaren anger fel tecken
            inputPersonnummer.KeyPress += inputPersonnummer_KeyPress;
        }
        // Denna metod tittar efter KeyPressEvent och unders�ker om KeyPress �r en siffra och att l�ngden inte �r l�ngre �n 12
        private void inputPersonnummer_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (inputPersonnummer.Text.Length == 12 && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Var god ange max 12 siffror");
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Var god ange endast nummer");
            }

        }
        // Detta event reagerar p� att "Ok" klickas, detta validerar f�rst personnumret, om det �r godk�nt
        // skapas en ny person som f�r data enligt anv�ndarens input. Sedan skrivs svar ut i textboxen fr�n 
        // Personinstansens "returneraData"-svar
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (Person.ValideraPersonnummer(inputPersonnummer.Text) == false)
            {
                MessageBox.Show("Felaktigt personnummer");
            }
            else
            {
                Person person = new Person(inputF�rnamn.Text, inputEfternamn.Text, inputPersonnummer.Text);
                outputTextbox.Text = string.Join(System.Environment.NewLine, person.ReturneraData());
            }
        }
        // Om anv�ndaren klickar avbryt st�ngs f�nstret (men applikation k�rs fortfarande)
        private void buttonAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}