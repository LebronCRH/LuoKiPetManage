using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.LuoKiPetModels;
using Web.Models.LayuiModel;
using LuoKiPetIBLL;

namespace Web.MethodDal
{
    public class PetDiseaseTreeDal
    {
        private IPetPositionService _IPetPositionService;
        private IPetPositionSymptomService _IPetPositionSymptomService;
        private IPetDiseaseService _IPetDiseaseService;
        public PetDiseaseTreeDal(IPetPositionService service1, IPetPositionSymptomService service2, IPetDiseaseService service3)
        {
            _IPetPositionService = service1;
            _IPetPositionSymptomService = service2;
            _IPetDiseaseService = service3;
        }
        public List<treeItem> PetPositionDoglistFormat(int PetCategoryId)
        {
            List<treeItem> SecondTreeList = new List<treeItem>();
            var petpositionDoglist = _IPetPositionService.LoadEntities(p => p.ForPetCategoryId == PetCategoryId).ToList();
            foreach (var positionitem in petpositionDoglist)
            {
                treeItem positem = new treeItem()
                {
                    name = positionitem.PetPositionName,
                    id = positionitem.PetPositionId,
                    jibie = 2,
                    forparentid = PetCategoryId.ToString(),
                };
                var positionsymlist = _IPetPositionSymptomService.LoadEntities(s => s.ForPetPositionId == positionitem.PetPositionId).ToList();
                List<treeItem> ThirdTreeList = new List<treeItem>();
                foreach (var symitem in positionsymlist)
                {
                    treeItem positionsymitem = new treeItem()
                    {
                        name = symitem.SymptomName,
                        id = symitem.PetPositionSymptomId,
                        spread = false,
                        jibie = 3,
                        forparentid = positionitem.PetPositionId.ToString(),
                        dataname= PetCategoryId.ToString(),
                    };
                    var positionsymdiseaselist = _IPetDiseaseService.LoadEntities(d => d.ForSymptomId == symitem.PetPositionSymptomId).ToList();
                    List<treeItem> FourthTreeList = new List<treeItem>();
                    foreach (var diseaseitem in positionsymdiseaselist)
                    {
                        treeItem positionsymdiseaseitem = new treeItem()
                        {
                            name = diseaseitem.DiseaseName,
                            id = diseaseitem.DiseaseId,
                            spread = false,
                            jibie = 4,
                            forparentid = symitem.PetPositionSymptomId.ToString(),
                        };
                        FourthTreeList.Add(positionsymdiseaseitem);
                    }
                    positionsymitem.children = FourthTreeList;
                    ThirdTreeList.Add(positionsymitem);
                }
                positem.children = ThirdTreeList;
                SecondTreeList.Add(positem);
            }
            return SecondTreeList;
        }
    }
}
