using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNP_Validator
{
    class Storage
    {
        private string CNP { get; set; }

        private List<string> CNPList { get; set; }


        public string GetCNP()
        {
            return this.CNP;
        }
        public void SetCNP(string input)
        {
            this.CNP = input;
        }
        

        public List<string> GetCNPList()
        {
            return this.CNPList;
        }
        public void SetCNPList(string input)
        {
            this.CNPList.Add(input);
        }











    }
}
