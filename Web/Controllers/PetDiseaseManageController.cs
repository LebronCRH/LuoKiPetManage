using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models.LuoKiPetModels;
using LuoKiPetBLL;
using LuoKiPetIBLL;
using Web.Models.LayuiModel;
using Web.MethodDal;

namespace Web.Controllers
{
    public class PetDiseaseManageController : Controller
    {
        private IPetPositionService _IPetPositionService;
        private IPetPositionSymptomService _IPetPositionSymptomService;
        private IPetDiseaseService _IPetDiseaseService;
        public PetDiseaseManageController(IPetPositionService service1, IPetPositionSymptomService service2, IPetDiseaseService service3)
        {
            _IPetPositionService = service1;
            _IPetPositionSymptomService = service2;
            _IPetDiseaseService = service3;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddPetDisease()
        {
            PetDisease item = new PetDisease();
            return View(item);
        }
        public IActionResult AddPetPosition()
        {
            return View();
        }
        public IActionResult Addsymptom()
        {
            return View();
        }

        public IActionResult EditPetDisease(int id)
        {
            var petitem = _IPetDiseaseService.LoadEntities(d => d.DiseaseId == id).FirstOrDefault();
            return View(petitem);
        }

        [HttpPost]
        public int AddPetdisease(PetDisease petdiseas)
        {
            try
            {
                return _IPetDiseaseService.AddEntity(petdiseas) != null ? 1 : 0;
            }
            catch {
                return 0;
            }
        }

        [HttpPost]
        public int UpdatePetDisease(PetDisease petdisease)
        {
            try
            {
                return _IPetDiseaseService.EditEntity(petdisease) ? 1 : 0;
            }
            catch
            {
                return 0;
            }
        }

        [HttpPost]
        public int AddPetPosition(PetPosition petposition)
        {
            try
            {
                return _IPetPositionService.AddEntity(petposition) != null ? 1 : 0;
            }
            catch
            {
                return 0;
            }
        }
        [HttpPost]
        public int AddPositionSymptom(PetPositionSymptom sym)
        {
            try
            {
                return _IPetPositionSymptomService.AddEntity(sym) != null ? 1 : 0;
            }
            catch
            {
                return 0;
            }
        }

        public IList<CascadeItem> GetPetDiseaseSelect()
        {
            CascadeSelect viiewmodel = new CascadeSelect();
            List<CascadeItem> FirstSelectList = new List<CascadeItem>();
            CascadeItem DogCascadeItem = new CascadeItem() { code = "1", name = "狗类" };
            CascadeItem CatCascadeItem = new CascadeItem() { code = "2", name = "猫类" };
            var DogSecondPositionList = _IPetPositionService.LoadEntities(p => p.ForPetCategoryId == int.Parse(DogCascadeItem.code)).Select(m => new CascadeItem { code = m.PetPositionId.ToString(), name = m.PetPositionName }).ToList();
            foreach (var DogSecondPositionItem in DogSecondPositionList)
            {
                var DogThirdSymList = _IPetPositionSymptomService.LoadEntities(s => s.ForPetPositionId == int.Parse(DogSecondPositionItem.code)).Select(s => new CascadeItem { code = s.PetPositionSymptomId.ToString(), name = s.SymptomName }).ToList();
                DogSecondPositionItem.childs = DogThirdSymList;
            }
            DogCascadeItem.childs = DogSecondPositionList;
            var CatSecondPositionList = _IPetPositionService.LoadEntities(p => p.ForPetCategoryId == int.Parse(CatCascadeItem.code)).Select(m => new CascadeItem { code = m.PetPositionId.ToString(), name = m.PetPositionName }).ToList();
            foreach (var CatSecondPositionItem in CatSecondPositionList)
            {
                var CatThirdSymList = _IPetPositionSymptomService.LoadEntities(s => s.ForPetPositionId == int.Parse(CatSecondPositionItem.code)).Select(s => new CascadeItem { code = s.PetPositionSymptomId.ToString(), name = s.SymptomName }).ToList();
                CatSecondPositionItem.childs = CatThirdSymList;
            }
            CatCascadeItem.childs = CatSecondPositionList;
            FirstSelectList.Add(DogCascadeItem);
            FirstSelectList.Add(CatCascadeItem);
            viiewmodel.CascadeItemList = FirstSelectList;
            return viiewmodel.CascadeItemList;
        }

        public TableRespone<PetDisease> GetAllPetDiseaseTable(int page, int limit)
        {
            TableRespone<PetDisease> respone = new TableRespone<PetDisease>();
            try
            {
                List<PetDisease> diseaselist = new List<PetDisease>();
                diseaselist = _IPetDiseaseService.LoadEntities(m => m.DiseaseId > 0).ToList();
                respone.code = 0;
                respone.count = diseaselist.Count();
                respone.msg = "请求成功";
                respone.data = diseaselist.OrderBy(l => l.DiseaseId).Skip(limit * (page - 1)).Take(limit).ToList();
                return respone;
            }
            catch (Exception e)
            {
                respone.code = 500;
                respone.count = 0;
                respone.msg = e.ToString();
                respone.data = null;
                return respone;
            }
        }

        public TableRespone<PetDisease> GetSerachPetDiseaseTable(int page, int limit,int petcategoryid,int positionid,int symptomid)
        {
            TableRespone<PetDisease> respone = new TableRespone<PetDisease>();
            try
            {
                //List<PetDisease> diseaselist = new List<PetDisease>();
                var diseaselist = _IPetDiseaseService.LoadEntities(m => m.DiseaseId > 0);
                if (!string.IsNullOrEmpty(petcategoryid.ToString()))
                {
                    diseaselist = diseaselist.Where(d => d.ForPetCaegoryId == petcategoryid);
                }
                if (!string.IsNullOrEmpty(positionid.ToString()) && positionid != 0)
                {
                    var symlist = _IPetPositionSymptomService.LoadEntities(s => s.ForPetPositionId == positionid).ToList();
                    var PetPositionSymptomIDs = symlist.Select(s => s.PetPositionSymptomId).ToList();
                    diseaselist = _IPetDiseaseService.LoadEntitiesField(m => PetPositionSymptomIDs.Contains((int)m.ForSymptomId), m =>new PetDisease { DiseaseId=m.DiseaseId, Genera=m.Genera, Symptom=m.Symptom, Summary=m.Summary, DiseaseCause=m.DiseaseCause, MainSymptom=m.MainSymptom, Zdbz=m.Zdbz, Treatment=m.Treatment, DiseaseName=m.DiseaseName, ForPetCaegoryId=m.ForPetCaegoryId, ForEn=m.ForEn, Type=m.Type, ForSymptomId=m.ForSymptomId });
                    //diseaselist = diseaselist.Where(m => PetPositionSymptomIDs.Contains((int)m.ForSymptomId));
                }
                if (!string.IsNullOrEmpty(symptomid.ToString()) && symptomid != 0)
                {
                    diseaselist = diseaselist.Where(d => d.ForSymptomId == symptomid);
                }
                respone.code = 0;
                respone.count = diseaselist.Count();
                respone.msg = "请求成功";
                respone.data = diseaselist.OrderBy(l => l.DiseaseId).Skip(limit * (page - 1)).Take(limit).ToList();
                return respone;
            }
            catch (Exception e)
            {
                respone.code = 500;
                respone.count = 0;
                respone.msg = e.ToString();
                respone.data = null;
                return respone;
            }
        }

        /// <summary>
        /// 获取疾病管理的树形菜单数据
        /// </summary>
        /// <returns></returns>
        public treeRespone GetPetDiseaseTree()
        {
            PetDiseaseTreeDal _PetDiseaseTreeDal = new PetDiseaseTreeDal(_IPetPositionService, _IPetPositionSymptomService, _IPetDiseaseService);
            treeRespone treeres = new treeRespone();
            List<treeItem> TopBigTreeList = new List<treeItem>();
            treeItem TopTree = new treeItem()
            {
                name = "宠物疾病管理树形栏",
                spread = true,
                jibie = 0,
            };
            List<treeItem> FirstTreeList = new List<treeItem>();
            treeItem dogTreeSecond = new treeItem()
            {
                name = "狗类疾病管理",
                spread = true,
                id=1,
                jibie = 1,
            };
            treeItem catTreeSecond = new treeItem()
            {
                name = "猫类疾病管理",
                spread = true,
                id = 2,
                jibie = 1,
            };
            List<treeItem> DogSecondTreeList = _PetDiseaseTreeDal.PetPositionDoglistFormat(dogTreeSecond.id);
            List<treeItem> CatSecondTreeList = _PetDiseaseTreeDal.PetPositionDoglistFormat(catTreeSecond.id);
            dogTreeSecond.children = DogSecondTreeList;
            catTreeSecond.children = CatSecondTreeList;
            FirstTreeList.Add(dogTreeSecond); FirstTreeList.Add(catTreeSecond);
            TopTree.children = FirstTreeList;
            TopBigTreeList.Add(TopTree);
            treeres.tree = TopBigTreeList;
            return treeres;
        }
    }
}