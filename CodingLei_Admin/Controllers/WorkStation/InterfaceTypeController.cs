using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;
using CodingLei_Business.Business;
using CodingLei_Model.SearchModel;
using CodingLei_Common.Helper;
using CodingLei_Model.TableModel;

namespace CodingLei_Admin.Controllers.WorkStation
{
    public class InterfaceTypeController : Controller
    {
        // GET: InterfaceType
        public ActionResult InterfaceTypeIndex()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetInterfaceTypeList(DemoSearchModel search, int id = 0)
        {
            search.PageSize = 2;
            search.PageIndex = (id == 0 ? 1 : id);
            var model = new InterfaceTypeBusiness().GetInterfaceTypeList();
            ViewData["TotalCount"] = model.Count();
            var modelView = model.Skip(search.PageSize * (search.PageIndex - 1)).Take(search.PageSize).ToList();

            return PartialView("InterfaceTypeResultView", modelView);
        }

        public void CreateXmlFile()
        {
            XmlDocument xmlDoc = new XmlDocument();
            //创建类型声明节点  
            XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
            xmlDoc.AppendChild(node);
            //创建根节点  
            XmlNode root = xmlDoc.CreateElement("Users");
            xmlDoc.AppendChild(root);

            XmlNode node1 = xmlDoc.CreateNode(XmlNodeType.Element, "User", null);
            CreateNode(xmlDoc, node1, "name", "xuwei");
            CreateNode(xmlDoc, node1, "sex", "male");
            CreateNode(xmlDoc, node1, "age", "25");
            root.AppendChild(node1);
            try
            {
                xmlDoc.Save("c://data5.xml");
            }
            catch (Exception e)
            {
                //显示错误信息  
                Console.WriteLine(e.Message);
            }
            //Console.ReadLine();  

        }

        /// <summary>    
        /// 创建节点    
        /// </summary>    
        /// <param name="xmldoc"></param>  xml文档  
        /// <param name="parentnode"></param>父节点    
        /// <param name="name"></param>  节点名  
        /// <param name="value"></param>  节点值  
        ///   
        public void CreateNode(XmlDocument xmlDoc, XmlNode parentNode, string name, string value)
        {
            XmlNode node = xmlDoc.CreateNode(XmlNodeType.Element, name, null);
            node.InnerText = value;
            parentNode.AppendChild(node);
        }

    }
}