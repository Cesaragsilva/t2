using System;
using System.Collections.Generic;

namespace Teste2
{
    /*
      * TODO
      * Implementar CanBeConnect para identificar se o Friend A pode se Conectar com o Friend C. Para isso, é necessário ter um friend em comum.
         - Caso sim, o método deverá retornar True
         - Caso não, o método deverá retornar False
      */
    class Friend
    {
        public string Email { get; private set; }

        public ICollection<Friend> Friends { get; private set; }

        public Friend(string email)
        {
            this.Email = email;
            this.Friends = new List<Friend>();
        }

        public void AddFriendship(Friend friend)
        {
            this.Friends.Add(friend);
        }

        public bool CanBeConnect(Friend friendC)
        {
            //Lista aos amigos existes.
            var amigos = this.Friends;

            // Se o count for maior que 0, possui amigos
            if (amigos.Count > 0)
            {
                // Varre na lista de amigos, para ver se algum tem friendC como amigo, caso sim, ele pode se conectar ao friendC.
                foreach (var friend in amigos)
                {
                    if (friend.Friends.Contains(friendC))
                    {
                        return true;
                        
                    }
                }
            }         

            return false;
        }

        static void Main(string[] args)
        {
            Friend a = new Friend("A");
            Friend b = new Friend("B");
            Friend c = new Friend("C");

            a.AddFriendship(b);
            b.AddFriendship(c);

            //Pode se conectar ao friend c
            var podeConectar = a.CanBeConnect(c);

        }
    }
}
