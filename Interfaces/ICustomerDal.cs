using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal  //Sql server bir veri tabanıdır..
                                               // hangi veri tabanı olursa olsun ICustomerDal'ı implemente edecek..
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql delete");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated");
        }
    }
    class OracleServerCustomerDal : ICustomerDal  //Oracle server da bir veri tabanıdır..
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle delete");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");

        }
    }
}
