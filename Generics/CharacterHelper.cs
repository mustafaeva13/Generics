namespace Generics
{
    class CharacterHelper
    {
        public static int CompareHealth<T>(T character1,T character2) where T : Character
        {
            if(character1.Health ==character2.Health)
            {
                return 0;
            }
            else if(character1.Health < character2.Health)
            {
                return -1;
            }
            else { return 1; }
        }

        internal static object CompareHealth<T1, T2>(T1 player, T1 player1)
        {
            throw new NotImplementedException();
        }
    }
}