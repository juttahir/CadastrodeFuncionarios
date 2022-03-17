using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_SQL_e_MVC.Paginas
{
    public partial class Cadastro : System.Web.UI.Page
    {
        private MeuBanco Banco { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Banco = new MeuBanco();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionarios fun = new Funcionarios()
                {
                    Bairro = txtBairro.Text,
                    Cidade = txtCidade.Text,
                    CPF = txtCPF.Text,
                    Departamento = 1,
                    Email = txtEmail.Text,
                    Endereco = txtEndereco.Text,
                    Nome = txtNome.Text,
                    RG = txtRG.Text,
                    Sobrenome = txtSobrenome.Text,
                    UF = txtUF.Text
                };
                Banco.Funcionarios.Add(fun);
                Banco.SaveChanges();
                txtResp.Text = "Cadastro efetuado com sucesso!";
            }
            catch (Exception ex)
            {

                txtResp.Text = ex.Message;
            }
            
        }
    }
}