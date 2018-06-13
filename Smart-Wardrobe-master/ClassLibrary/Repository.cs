using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Repository: Interface {
       

        public class GeneralData
        {
            public List<Cloth> Clothes { get; set; }
            
        }
        private GeneralData _generalData = new GeneralData();

        public IEnumerable<Cloth> Clothes => _generalData.Clothes;

        public void AddClothes(Cloth cloth)
        {
            cloth.ID = _generalData.Clothes.Count > 0 ? _generalData.Clothes.Max(c => c.ID) + 1 : 1;
            _generalData.Clothes.Add(cloth);
            Save();
        }
        public void Action_WearOrWash(Cloth cloth)
        {
            foreach(var condition in _generalData.Clothes)

            {
                condition.Condition = !condition.Condition;
            }
        }
        public void Save()
        {

        }
    }
    
}

