namespace Diplom
{
    partial class Room
    {
        public int Free_place
        {
            get
            {
                int x = NumberOfPlace - Contracts.Count;
                if(x>0)
                {
                    return x;
                }
                return 0;
            }
        }
    }
}
