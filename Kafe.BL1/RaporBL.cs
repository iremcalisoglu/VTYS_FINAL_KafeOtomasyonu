using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kafe.DAL1;

namespace Kafe.BL1
{
    public class RaporBL
    {
        RaporDAL dal =
           new RaporDAL();

        public float ToplamSiparis()
        {
            return dal.ToplamSiparis();
        }

        public float ToplamOdeme()
        {
            return dal.ToplamOdeme();
        }

        public int ToplamMusteri()
        {
            return dal.ToplamMusteri();
        }

        public int ToplamUrun()
        {
            return dal.ToplamUrun();
        }

        public float KDVliSiparis()
        {
            return dal.KDVliSiparis();
        }
    }
}
