using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using SAP.Middleware.Connector;
using SAPConnector.Core.Model;

namespace SAPConnector.Core
{
    public static class SapConnection
    {

        public static List<SapClassModel> classModel = new List<SapClassModel>();

        private static RfcDestination GetRfcDestination(SapParameter param)
        {
            RfcConfigParameters parameters = new RfcConfigParameters
            {
                {RfcConfigParameters.Name, param.Name},
                {RfcConfigParameters.User, param.User},
                {RfcConfigParameters.Password, param.Password},
                {RfcConfigParameters.Client, param.Client},
                {RfcConfigParameters.Language, param.Language},
                {RfcConfigParameters.AppServerHost, param.AppServerHost},
                {RfcConfigParameters.SystemNumber, param.SystemNumber},
                {RfcConfigParameters.IdleTimeout, param.IdleTimeout},
                {RfcConfigParameters.PoolSize, param.PoolSize},
                {RfcConfigParameters.PeakConnectionsLimit, param.PeakConnectionsLimit}
            };


            return RfcDestinationManager.GetDestination(parameters);
        }

        public static IRfcFunction GetFunction(SapParameter parameter)
        {
            IRfcFunction rfcFunction = null;

            try
            {
                RfcDestination rfcDestination = GetRfcDestination(parameter);
                rfcFunction = rfcDestination.Repository.CreateFunction(parameter.FunctionName);
                rfcFunction.Invoke(rfcDestination);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
           
            return rfcFunction;
        }

        public static List<SapClassModel> GetAllTablesClass(IRfcFunction function)
        {
            foreach (var tableName in GetResultTableNames(function.Metadata.ToString()))
            {
                var rfcTable = function.GetTable(tableName);
                classModel.Add(GetClassBuilder(rfcTable));
            }

            foreach (var structureName in GetResultStructureNames(function.Metadata.ToString()))
            {
                var rfcStructure = function.GetStructure(structureName);
                classModel.Add(GetClassBuilder(rfcStructure));
            }
            
            return classModel;
        }

        private static IEnumerable<string> GetResultTableNames(string metadataDescription)
        {
            var regex = new Regex(@"TABLES (\w+):");

            foreach (Match match in regex.Matches(metadataDescription))
            {
                yield return match.Groups[1].Value;
            }

            regex = new Regex(@"(\w+):TABLE");

            foreach (Match match in regex.Matches(metadataDescription))
            {
                yield return match.Groups[1].Value;
            }
        }

        private static IEnumerable<string> GetResultStructureNames(string metadataDescription)
        {
            var regex = new Regex(@"IMPORT (\w+):STRUCTURE");

            foreach (Match match in regex.Matches(metadataDescription))
            {
                yield return match.Groups[1].Value;
            }

            regex = new Regex(@"EXPORT (\w+):STRUCTURE");

            foreach (Match match in regex.Matches(metadataDescription))
            {
                yield return match.Groups[1].Value;
            }
        }

        private static string GetType(string sapType,RfcFieldMetadata fieldMetaData)
        {
            switch (sapType)
            {
                case "BYTE":
                    return "string";
                case "INT":
                    return "string";
                case "INT1":
                    return "string";
                case "INT2":
                    return "string";
                case "FLOAT":
                    return "string";
                case "NUM":
                    return "string";
                case "TABLE":
                    return "List<"+ GetInClass(fieldMetaData) + ">";
                case "STRUCTURE":
                    return GetInClass(fieldMetaData);
                default:
                    return "string";
            }
        }

        private static SapClassModel GetClassBuilder(IRfcTable tableRef)
        {
            SapClassModel result = new SapClassModel();
            var rfcTableMetadata = tableRef.Metadata.LineType;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("public class " + rfcTableMetadata.Name);
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append("\t{");
            stringBuilder.Append(Environment.NewLine);

            for (int i = 0; i < rfcTableMetadata.FieldCount; i++)
            {
                stringBuilder.Append("\t\tpublic " + GetType(rfcTableMetadata[i].DataType.ToString(),rfcTableMetadata[i]) + " " + rfcTableMetadata[i].Name + " { get; set; }\t\t\t\t// "+rfcTableMetadata[i].Documentation);
                stringBuilder.Append(Environment.NewLine);
            }
            stringBuilder.Append("\t}");


            result.Builder = stringBuilder;
            result.ClassName = rfcTableMetadata.Name;
            return result;
        }

        private static SapClassModel GetClassBuilder(IRfcStructure structureRef)
        {
            SapClassModel result = new SapClassModel();
            var rfcStructureMetadata = structureRef.Metadata;

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("public class " + rfcStructureMetadata.Name);
            stringBuilder.Append(Environment.NewLine);
            stringBuilder.Append("\t{");
            stringBuilder.Append(Environment.NewLine);

            for (int i = 0; i < rfcStructureMetadata.FieldCount; i++)
            {
                stringBuilder.Append("\t\tpublic " + GetType(rfcStructureMetadata[i].DataType.ToString(),rfcStructureMetadata[i]) + " " + rfcStructureMetadata[i].Name + " { get; set; }\t\t\t\t// "+ rfcStructureMetadata[i].Documentation);
                stringBuilder.Append(Environment.NewLine);
            }
            stringBuilder.Append("\t}");

            result.Builder = stringBuilder;
            result.ClassName = rfcStructureMetadata.Name;
            return result;
        }

        private static string GetInClass(RfcFieldMetadata metadata)
        {
            if (metadata.DataType.ToString() == "TABLE")
            {
                classModel.Add(GetClassBuilder(metadata.ValueMetadataAsTableMetadata.CreateTable()));
                return metadata.ValueMetadataAsTableMetadata.Name;
            }
            else
            {
                classModel.Add(GetClassBuilder(metadata.ValueMetadataAsStructureMetadata.CreateStructure()));
                return metadata.ValueMetadataAsStructureMetadata.Name;
            }
        }
    }
}