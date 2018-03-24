namespace Nethereum.Generators.Net.ContractLibrary
{

    public class GenerateClassesCommand
    {
        public string ContractByteCode { get; set; }
        public string Abi { get; set; }
        public string BasePath { get; set; }
        public string ContractName { get; set; }
        public string ServiceNamespace { get; set; }
        public string CqsNamespace { get; set; }
        public string DtoNamesapce { get; set; }
        public string PathDelimiter { get; set; }
        public string BaseNamespace { get; set; }

        public GenerateClassesCommand(string contractByteCode, string abi, string basePath,  string baseNamespace, string contractName, string serviceNamespace, string cqsNamespace, string dtoNamesapce, string pathDelimiter)
        {
            ContractByteCode = contractByteCode;
            Abi = abi;
            BasePath = basePath;
            BaseNamespace = baseNamespace;
            ContractName = contractName;
            ServiceNamespace = serviceNamespace;
            CqsNamespace = cqsNamespace;
            DtoNamesapce = dtoNamesapce;
            PathDelimiter = pathDelimiter;
        }

        public GenerateClassesCommand(string contractByteCode, string abi, string basePath, string baseNamespace, string contractName, string pathSeparator) 
            : this(contractByteCode, abi, basePath, baseNamespace, contractName, (string) SetDefaultService(contractName), (string) SetDefaultDto(contractName), (string) SetDefaultCqs(contractName), pathSeparator)
        {

        }

        private static string SetDefaultCqs(string contractName)
        {
            return contractName + "." + "CQS";
        }

        private static string SetDefaultDto(string contractName)
        {
            return contractName + "." + "DTOs";
        }

        private static string SetDefaultService(string contractName)
        {
            return contractName + "." + "Service";
        }
    }
}