namespace PersonRegistrerare
{
    public partial class PersonRegistrerare : Form
    {
        public PersonRegistrerare()
        {
            InitializeComponent();
            // Vi lyssnar här på key-press för att kunna säga till när användaren anger fel tecken
            inputPersonnummer.KeyPress += inputPersonnummer_KeyPress;
        }
        // Denna metod tittar efter KeyPressEvent och undersöker om KeyPress är en siffra och att längden inte är längre än 12
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
        // Detta event reagerar på att "Ok" klickas, detta validerar först personnumret, om det är godkänt
        // skapas en ny person som får data enligt användarens input. Sedan skrivs svar ut i textboxen från 
        // Personinstansens "returneraData"-svar
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (Person.ValideraPersonnummer(inputPersonnummer.Text) == false)
            {
                MessageBox.Show("Felaktigt personnummer");
            }
            else
            {
                Person person = new Person(inputFörnamn.Text, inputEfternamn.Text, inputPersonnummer.Text);
                outputTextbox.Text = string.Join(System.Environment.NewLine, person.ReturneraData());
            }
        }
        // Om användaren klickar avbryt stängs fönstret (men applikation körs fortfarande)
        private void buttonAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}