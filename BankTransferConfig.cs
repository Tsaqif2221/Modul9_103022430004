using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Modul9_103022430004
{
    public class BankTransferConfig
    {
        public Config config;
        private string filepath = @"bank_transfer_config.json";
        public BankTransferConfig()
        {
            try
            {
                ReadConfigFile();

            }
            catch
            {
                setDeafult();
                WriteConfigFile();
            }

        }
        public void ReadConfigFile()
        {
            string hasilbaca = File.ReadAllText(filepath);
            config = JsonSerializer.Deserialize<Config>(hasilbaca);


        }
        public void WriteConfigFile()
        {
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            string tulisan = JsonSerializer.Serialize(config, options);
            File.WriteAllText(filepath, tulisan);

        }
        public void setDeafult()
        {
            config = new Config();
            config.lang = "en";
            Transfer transfer = new Transfer(25000000, 6500, 15000);
            config.transfer = transfer;
            List<string> files = new List<string>();
            files.Add("RTO (real-time)");
            files.Add("SKN");
            files.Add("RTGS");
            files.Add("BI FAST");
            config.methods = files;
            Confirmation confirmation = new Confirmation();
            confirmation.en = "yes";
            confirmation.id = "ya";
            config.confimation = confirmation;
        }
    }
}
