using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_Functions
{
    internal class Function_04_SideEffect
    {
        private Cryptographer cryptographer;

        public bool CheckPassword(String userName, String password)
        {
            User user = UserGateway.findByName(userName);
            if (user != null)
            {
                String codedPhrase = user.getPhraseEncodedByPassword();
                String phrase = cryptographer.decrypt(codedPhrase, password);
                if ("Valid Password".Equals(phrase))
                {
                    Session.initialize(); //side effect: call Session.initialize() 
                    return true;
                }
            }
            return false;
        }
    }
}
