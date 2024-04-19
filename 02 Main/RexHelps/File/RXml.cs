using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Data;

namespace RexHelps
{
    /// <summary>
    /// RXml 的摘要说明。
    /// xml操作类
    /// </summary>
    public class RXml
    {
        protected string strXmlFile;
        protected XmlDocument objXmlDoc = new XmlDocument();

        public RXml(string XmlFile)
        {
            try
            {

                objXmlDoc.Load(XmlFile);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            strXmlFile = XmlFile;
        }

        public DataTable GetData(string XmlPathNode)
        {
            //查找数据。返回一个DataView 
            DataSet ds = new DataSet();
            StringReader read = new StringReader(objXmlDoc.SelectSingleNode(XmlPathNode).OuterXml);
            ds.ReadXml(read);
            return ds.Tables[0];
        }
        /// <summary>
        /// 新节点内容。
        /// 示例：xmlTool.Replace("Book/Authors[ISBN=\"0002\"]/Content","ppppppp"); 
        /// </summary>
        /// <param name="XmlPathNode"></param>
        /// <param name="Content"></param>
        public void Replace(string XmlPathNode, string Content)
        {
            //更新节点内容。 
            objXmlDoc.SelectSingleNode(XmlPathNode).InnerText = Content;
        }

        /// <summary>
        /// 删除一个指定节点的子节点。 
        /// 示例： xmlTool.DeleteChild("Book/Authors[ISBN=\"0003\"]"); 
        /// </summary>
        /// <param name="Node"></param>
        public void DeleteChild(string Node)
        {
            //删除一个节点。 
            string mainNode = Node.Substring(0, Node.LastIndexOf("/"));
            objXmlDoc.SelectSingleNode(mainNode).RemoveChild(objXmlDoc.SelectSingleNode(Node));
        }

        /// <summary>
        ///  * 使用示列:
        ///  示例： RXml.Delete( "/Node", "")
        ///  RXml.Delete( "/Node", "Attribute")
        /// </summary>
        /// <param name="node">节点</param>
        /// <param name="attribute">属性名，非空时删除该节点属性值，否则删除节点值</param>
        public void Delete(string node, string attribute)
        {
            try
            {

                XmlNode xn = objXmlDoc.SelectSingleNode(node);
                XmlElement xe = (XmlElement)xn;
                if (attribute.Equals(""))
                {
                    xn.ParentNode.RemoveChild(xn);
                }
                else
                {
                    xe.RemoveAttribute(attribute);
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// 插入一节点和此节点的一子节点。 
        /// 示例：xmlTool.InsertNode("Book","Author","ISBN","0004"); 
        /// </summary>
        /// <param name="MainNode">主节点</param>
        /// <param name="ChildNode">子节点</param>
        /// <param name="Element">元素</param>
        /// <param name="Content">元素内容</param>
        public void InsertNode(string MainNode, string ChildNode, string Element, string Content)
        {
            //插入一节点和此节点的一子节点。 
            XmlNode objRootNode = objXmlDoc.SelectSingleNode(MainNode);
            XmlElement objChildNode = objXmlDoc.CreateElement(ChildNode);
            objRootNode.AppendChild(objChildNode);
            XmlElement objElement = objXmlDoc.CreateElement(Element);
            objElement.InnerText = Content;
            objChildNode.AppendChild(objElement);
        }

        /// <summary>
        /// 插入一个节点，带一属性。
        /// 示例： xmlTool.InsertElement("Book/Author[ISBN=\"0004\"]","Title","Sex","man","iiiiiiii"); 
        /// </summary>
        /// <param name="MainNode">主节点</param>
        /// <param name="Element">元素</param>
        /// <param name="Attrib">元素属性</param>
        /// <param name="AttribContent">元素属性内容</param>
        /// <param name="Content">元素内容</param>
        public void InsertElement(string MainNode, string Element, string Attrib, string AttribContent, string Content)
        {
            //插入一个节点，带一属性。 
            XmlNode objNode = objXmlDoc.SelectSingleNode(MainNode);
            XmlElement objElement = objXmlDoc.CreateElement(Element);
            objElement.SetAttribute(Attrib, AttribContent);
            objElement.InnerText = Content;
            objNode.AppendChild(objElement);
        }

        /// <summary>
        /// 插入一个节点，不带属性。
        /// 示例：xmlTool.InsertElement("Book/Author[ISBN=\"0004\"]","Content","aaaaaaaaa"); 
        /// </summary>
        /// <param name="MainNode">主节点</param>
        /// <param name="Element">元素</param>
        /// <param name="Content">元素内容</param>
        public void InsertElement(string MainNode, string Element, string Content)
        {
            //插入一个节点，不带属性。 
            XmlNode objNode = objXmlDoc.SelectSingleNode(MainNode);
            XmlElement objElement = objXmlDoc.CreateElement(Element);
            objElement.InnerText = Content;
            objNode.AppendChild(objElement);
        }

        /// <summary>
        /// 对xml文件做插入，更新，删除后需做Save()操作，以保存修改
        /// </summary>
        public void Save()
        {
            //保存文檔。 
            try
            {
                objXmlDoc.Save(strXmlFile);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            objXmlDoc = null;
        }
    }

    //========================================================= 

    //实例应用： 

    //string strXmlFile = Server.MapPath("TestXml.xml"); 
    //XmlControl xmlTool = new XmlControl(strXmlFile); 

    // 数据显视 
    // dgList.DataSource = xmlTool.GetData("Book/Authors[ISBN=\"0002\"]"); 
    // dgList.DataBind(); 

    // 更新元素内容 
    // xmlTool.Replace("Book/Authors[ISBN=\"0002\"]/Content","ppppppp"); 
    // xmlTool.Save(); 

    // 添加一个新节点 
    // xmlTool.InsertNode("Book","Author","ISBN","0004"); 
    // xmlTool.InsertElement("Book/Author[ISBN=\"0004\"]","Content","aaaaaaaaa"); 
    // xmlTool.InsertElement("Book/Author[ISBN=\"0004\"]","Title","Sex","man","iiiiiiii"); 
    // xmlTool.Save(); 

    // 删除一个指定节点的所有内容和属性 
    // xmlTool.Delete("Book/Author[ISBN=\"0004\"]"); 
    // xmlTool.Save(); 

    // 删除一个指定节点的子节点 
    // xmlTool.Delete("Book/Authors[ISBN=\"0003\"]"); 
    // xmlTool.Save();
}
