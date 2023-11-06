using api_model;

namespace api_service
{
    public class MissleService
    {
        readonly Data _data;
        public MissleService(Data data)
        {
            _data = data;
        }
        //מחזיר את מערך הטילים
        public IEnumerable<Missle> GetData()
        {
            return _data.data;
        }
        public bool add(Missle m)
        {
            if (!_data.data.Contains(m))
            {

                return true;
            }
            _data.data.Add(m);
            return true;

        }
        //החזרת טילים לפי מיקום
        public IEnumerable<Missle> GetDataByCity(string city)
        {
            return _data.data.Where(t => t.Location.City == city).ToList();
        }

        public IEnumerable<string> GetCities()
        {
            return _data.data.Select(x => x.Location.City).Distinct().ToList();

        }

    }
}
