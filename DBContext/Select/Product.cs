using DBContexts.Data;

namespace DBContexts.Select
{
    public  class Product
    {
         private readonly RFoods _rFoods;

        public Product()
        {
        }

        public Product(RFoods rFoods) => _rFoods = rFoods;

        public  async void select()
        {
            var lis = await _rFoods.GetAllAsync();


            for (int i = 0; i < lis.Count; i++)
            {
                Console.WriteLine(lis[i]);
            }
        }





    }
}
