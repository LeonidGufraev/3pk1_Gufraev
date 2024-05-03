using pz_10.Data;

namespace pz_10.Services
{
    public class ZooService
    {
        private ZooContext _context;
        public ZooService()
        {
            _context = new ZooContext();
        }
        internal void Add(object source, int num)
        {
            if(num== 0)
            {
                source = new Animal();
            }
        }
    }
}
