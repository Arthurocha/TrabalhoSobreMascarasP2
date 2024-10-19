namespace TrhabalhoComMascaras
{
    
    public partial class Frm_Mascara : Form
    {
        public Frm_Mascara()
        {
            InitializeComponent();
        }

        private void Frm_Mascara_Load(object sender, EventArgs e)
        {

        }

        public int variavel = 0;

        private void Btn_Hora_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00:00";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            variavel = 0;
        }


        private void Btn_VerConteudo_Click(object sender, EventArgs e)
        {
            if (variavel == 0)
            {
                string conteudo = Msk_TextBox.Text;

                if (Msk_TextBox.Mask == "00/00/0000")
                {
                    DateTime temp;
                    if (!DateTime.TryParseExact(conteudo, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out temp))
                    {
                        MessageBox.Show("Data inválida! Por favor, insira uma data válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Msk_TextBox.Focus();
                        return;
                    }

                    else
                    {
                        Lbl_Conteudo.Text = conteudo;
                    }
                }

                else if (Msk_TextBox.Mask == "00:00")
                {
                    DateTime temp;
                    if (!DateTime.TryParseExact(conteudo, "HH:mm", null, System.Globalization.DateTimeStyles.None, out temp))
                    {
                        MessageBox.Show("Hora inválida! Por favor, insira uma hora válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Msk_TextBox.Focus();
                        return;
                    }

                    else
                    {
                        Lbl_Conteudo.Text = conteudo;
                    }
                }

                else
                {
                    Lbl_Conteudo.Text = conteudo;
                }

            }
            else
            {
                string conteudo = Msk_TextBox.Text;

                if (conteudo.Length < 8 ||
                    !conteudo.Any(char.IsUpper) ||
                    !conteudo.Any(char.IsLower) ||
                    !conteudo.Any(char.IsDigit) ||
                    !conteudo.Any(c => "!@#$%^&*()_-+=<>?".Contains(c)))
                {
                    MessageBox.Show("Deve conter ao menos 8 caracteres, incluindo letra maiúscula, minúscula, número e caractere especial.", "Senha inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Lbl_Conteudo.Text = conteudo;
                }
            }
        }


        private void Btn_CEP_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00000-000";
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            variavel = 0;
        }


        private void Btn_Moeda_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "$ 000,000,000.00";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            variavel = 0;
        }


        private void Btn_Data_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00/00/0000";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            variavel = 0;
        }


        private void Btn_Telefone_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "(00) 0000-0000";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            variavel = 0;
        }


        private void Btn_Senha_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = true;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "";
            Lbl_MascaraAtiva.Text = "";
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
            variavel = 1;
            MessageBox.Show("Deve conter ao menos 8 caracteres, incluindo letra maiúscula, minúscula, número e caractere especial.", "Regras:", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
