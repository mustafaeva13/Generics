using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
namespace Generics
{
    public class Program
    {
        static void Main(string[] args)

        {



            //Player player = new Player()
            //{
            //    Health = 100
            //};
            //Player player1 = new Player()
            //{
            //    Health=300
            //};

            //var result=CharacterHelper.CompareHealth<Player,Enemy>(player,player1);
            //Console.WriteLine(result);



            //List<int> GenericList = new List<int>();

            //GenericList.Add(30);
            //GenericList.Add(50);
            //GenericList.Add(100);
            //GenericList.Add(120);


            //foreach(int i in GenericList)
            //{
            //    Console.WriteLine(i);
            //}
            //}



        }


        #region   ///Task1


        //class GameCollection<T>
        //{
        //    private List<T> gameCollection;

        //    private List<T> GetGameCollection()
        //    {
        //        return gameCollection;
        //    }

        //    private void SetGameCollection(List<T> value)
        //    {
        //        gameCollection = value;
        //    }

        //    public void Add( T gameCollection)
        //    {
        //        GetGameCollection().Add(gameCollection);
        //    }
        //}
        #endregion


        #region Task2
        interface ICharacter<T>
        {
            void Attack(T attack);
            void TakeDamage(T damage);
            void Health(T health);
        }


        class Character : ICharacter<T>
        {
            public void Attack()
            {
                Console.WriteLine("Your attack");
            }

            public void Attack(T attack)
            {
                throw new NotImplementedException();
            }

            public void Health(T health)
            {
                Console.WriteLine("Your Health");
            }

            public void TakeDamage(T damage)
            {
                Console.WriteLine("Your takeDamege");
            }
        }
        #endregion




    }
}