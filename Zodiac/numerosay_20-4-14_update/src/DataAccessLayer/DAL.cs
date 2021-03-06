﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace DataAccessLayer
{
    public class DAL
    {
        public static void AddAttribute(string attribute)
        {
            //Llamar a el método ejecutar sentencia sql
            string query = string.Format("INSERT INTO attribute ( attribute ) VALUES ('{0}')", attribute);
            MicrosoftAccessConnector.Ejecutar_Sentencia(query);
        }

        public static string GetAboutContent()
        {
            string query = "SELECT content FROM cms WHERE Id=2";

            DataSet vDataset = null;

            vDataset = MicrosoftAccessConnector.Recuperar_Consulta(query);

            DataTable tbl = vDataset.Tables[0];

            string content = tbl.Rows[0]["content"].ToString();

            return content;
        }

        public static string GetPrivacyContent()
        {
            string query = "SELECT content FROM cms WHERE Id=3";

            DataSet vDataset = null;

            vDataset = MicrosoftAccessConnector.Recuperar_Consulta(query);

            DataTable tbl = vDataset.Tables[0];

            string content = tbl.Rows[0]["content"].ToString();

            return content;
        }

        public static string GetFAQContent()
        {
            string query = "SELECT content FROM cms WHERE Id=4";

            DataSet vDataset = null;

            vDataset = MicrosoftAccessConnector.Recuperar_Consulta(query);

            DataTable tbl = vDataset.Tables[0];

            string content = tbl.Rows[0]["content"].ToString();

            return content;
        }

        public static void AddAttributeBirthNumber(int IDAttribute, int birthNumber)
        {
            //Llamar a el método ejecutar sentencia sql
            string query = string.Format("INSERT INTO [attribute-birthnumber] ( IDattribute, birthNumber ) VALUES ({0}, {1})", IDAttribute, birthNumber);
            try
            {
                MicrosoftAccessConnector.Ejecutar_Sentencia(query);
            }
            catch (System.Data.OleDb.OleDbException e)
            {
                //Agregar Excepcion de que no se puede agregar con esos datos porque no coinciden

            }
            
        }

        public static void AddAttributeNameNumber(int IDAttribute, int nameNumber)
        {
            //Llamar a el método ejecutar sentencia sql
            string query = string.Format("INSERT INTO [attribute-namenumber] ( IDattribute, nameNumber ) VALUES ({0}, {1})", IDAttribute, nameNumber);
            try
            {
                MicrosoftAccessConnector.Ejecutar_Sentencia(query);
            }
            catch (System.Data.OleDb.OleDbException e)
            {
                //Agregar Excepcion de que no se puede agregar con esos datos porque no coinciden

            }
            
        }

        public static void AddAttributeFortune(int IDAttribute, int IDfortune)
        {
            //Llamar a el método ejecutar sentencia sql
            string query = string.Format("INSERT INTO [attribute-fortune] ( IDattribute, IDfortune ) VALUES ({0}, {1})", IDAttribute, IDfortune);

            try
            {
                MicrosoftAccessConnector.Ejecutar_Sentencia(query);
            }
            catch (System.Data.OleDb.OleDbException e)
            {
                //Agregar Excepcion de que no se puede agregar con esos datos porque no coinciden

            }


        }

        public static void UpDateAttribute(int IDattribute, string attribute)
        {
            string query = string.Format("UPDATE attribute SET attribute='{0}' WHERE ID={1}", attribute, IDattribute);
            try
            {
                MicrosoftAccessConnector.Ejecutar_Sentencia(query);
            }
            catch (System.Data.OleDb.OleDbException e)
            {
                //Agregar Excepcion de que no se puede agregar con esos datos porque no coinciden

            }
        }


        public static void DeleteAttribute(int IDattribute)
        {

            string query = "DELETE FROM attribute WHERE ID =" + IDattribute;
            MicrosoftAccessConnector.Ejecutar_Sentencia(query);

        }

        public static void UpDateAttributeBirthNumber(int IDattribute, int birthNumber, int newIDAttribute, int newbirthNumber)
        {
            string query = string.Format("UPDATE [attribute-birthnumber] SET IDattribute={0}, birthNumber={1} WHERE IDattribute={2} AND birthNumber={3}", newIDAttribute, newbirthNumber, IDattribute, birthNumber);

            try
            {
                MicrosoftAccessConnector.Ejecutar_Sentencia(query);
            }
            catch (System.Data.OleDb.OleDbException e)
            {
                //Agregar Excepcion de que no se puede agregar con esos datos porque no coinciden

            }
        }
        

        public static void UpDateAboutPage(string content)
        {
            string fixedContent = content.Replace("\'", "&#39;");

            string query = string.Format("UPDATE [cms] SET content='{0}' WHERE Id=2;", fixedContent);

            try
            {
                MicrosoftAccessConnector.Ejecutar_Sentencia(query);
            }
            catch (System.Data.OleDb.OleDbException e)
            {
                //Agregar Excepcion de que no se puede agregar con esos datos porque no coinciden

            }
        }


        public static void UpDatePrivacyPage(string content)
        {

            string fixedContent = content.Replace("\'", "&#39;");

            string query = string.Format("UPDATE [cms] SET content='{0}' WHERE Id=3;", fixedContent);

            //try
            //{
                MicrosoftAccessConnector.Ejecutar_Sentencia(query);
            //}
            //catch (System.Data.OleDb.OleDbException e)
            //{
            //    //Agregar Excepcion de que no se puede agregar con esos datos porque no coinciden

            //}
        }

        public static void UpDateFAQPage(string content)
        {
            string fixedContent = content.Replace("\'", "&#39;");

            string query = string.Format("UPDATE [cms] SET content='{0}' WHERE Id=4;", fixedContent);

            try
            {
                MicrosoftAccessConnector.Ejecutar_Sentencia(query);
            }
            catch (System.Data.OleDb.OleDbException e)
            {
                //Agregar Excepcion de que no se puede agregar con esos datos porque no coinciden

            }
        }

        public static void UpDateAttributeNameNumber(int IDattribute, int nameNumber, int newIDAttribute, int newnameNumber)
        {
            string query = string.Format("UPDATE [attribute-namenumber] SET IDattribute={0}, nameNumber={1} WHERE IDattribute={2} AND nameNumber={3}", newIDAttribute, newnameNumber, IDattribute, nameNumber);

            try
            {
                MicrosoftAccessConnector.Ejecutar_Sentencia(query);
            }
            catch (System.Data.OleDb.OleDbException e)
            {
                //Agregar Excepcion de que no se puede agregar con esos datos porque no coinciden

            }
        }

        public static void UpDateAttributeFortune(int IDattribute, int IDFortune, int newIDAttribute, int newIDFortune)
        {
            string query = string.Format("UPDATE [attribute-fortune] SET IDattribute={0}, IDfortune={1} WHERE IDattribute={2} AND IDfortune={3}", newIDAttribute, newIDFortune, IDattribute, IDFortune);

            try
            {
                MicrosoftAccessConnector.Ejecutar_Sentencia(query);
            }
            catch (System.Data.OleDb.OleDbException e)
            {
                //Agregar Excepcion de que no se puede agregar con esos datos porque no coinciden

            }
        }
        public static List<string> GetMatchedAttributesAsString (int birthNumber, string fortune, int nameNumber)
        {
            List<string> attributes = new List<string>();
            DataSet matchedAttributes = DataAccessLayer.DAL.GetMatchedAttributes(birthNumber, fortune, nameNumber);
            DataTable tblmatchedAttributes = matchedAttributes.Tables[0];
            for (int i = 0; i < tblmatchedAttributes.Rows.Count; i++)
            {
                attributes.Add(tblmatchedAttributes.Rows[i]["attribute"].ToString());

            }
            return attributes;
        }
        public static DataSet GetMatchedAttributes(int birthNumber, string fortune, int nameNumber)
        {
            string query = "SELECT attribute.attribute as attribute " +
                              "FROM attribute INNER JOIN [attribute-birthnumber] ON attribute.Id = [attribute-birthnumber].IDattribute " +
                              "WHERE ((([attribute-birthnumber].birthNumber)={0})) " +

                           "UNION ALL " +

                              "SELECT attribute.attribute  as attribute " +
                              "FROM fortune INNER JOIN (attribute INNER JOIN [attribute-fortune] ON attribute.Id = [attribute-fortune].IDattribute) ON fortune.Id = [attribute-fortune].IDfortune " +
                              "WHERE (((fortune.fortune)='{1}')) " +

                           "UNION ALL " +

                           "SELECT attribute.attribute as attribute " +
                           "FROM attribute INNER JOIN [attribute-namenumber] ON attribute.Id = [attribute-namenumber].IDattribute " +
                           "WHERE ((([attribute-namenumber].nameNumber)={2}))";

            DataSet vDataset = null;



            vDataset = MicrosoftAccessConnector.Recuperar_Consulta(string.Format(query, birthNumber, fortune, nameNumber));



            return vDataset;

        }


    }
}