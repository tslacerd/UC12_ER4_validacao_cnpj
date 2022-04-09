using System.Text.RegularExpressions;
using CadastroPessoa.Interface;

namespace CadastroPessoa.Classes
{
    public class PessoaJuridica : Pessoa , IPessoaJuridica
    {
       public string? Cnpj { get; set; }

       public string? razaoSocial { get; set; }

        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {
          if (Regex.IsMatch(cnpj, @"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
          {
              if (cnpj.Length == 18)
              {
                if (cnpj.Substring(11, 4) =="0001")
              {
                 return true; 
              }
          } else if (cnpj.Length == 14)
          {
              if (cnpj.Substring(8, 4) == "0001")
              {
                  return true;
              }

          }
          
                    
        } 
        return false;
    }
    }
}