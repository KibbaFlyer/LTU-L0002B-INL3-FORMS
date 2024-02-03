namespace PersonRegistrerare
{
    public partial class PersonRegistrerare : Form
    {
        public PersonRegistrerare()
        {
            InitializeComponent();
            // Vi lyssnar här på kez
            inputPersonnummer.KeyPress += inputPersonnummer_KeyPress;
        }
        // denna metod tittar efter KeyPressEvent och undersöker om KeyPress är en siffra
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

        private void buttonAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}