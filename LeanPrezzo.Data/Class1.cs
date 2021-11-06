using Azure.Data.Tables;

namespace LeanPrezzo.Data
{
    public class Class1
    {

        // Construct a new <see cref="TableClient" /> using a <see cref="TableSharedKeyCredential" />.
        TableClient tableClient = new TableClient(
            new Uri("http://localhost:10002/devstorageaccount1/table1"),
            "table1",
            new TableSharedKeyCredential("Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw=="));

        // Create the table in the service.
        tableClient.Create();

    }
}