using Citadel.Kernel.Models;
using Microsoft.AspNetCore.Mvc;
using Npm.Models;

namespace Npm.Controllers;

public class RegistryController : Controller
{
    // GET
    [HttpGet("/{pkg}")]
    public async Task<PackageMetadata> Index([FromRoute] string pkg)
    {
        return null;
    }

    [HttpPost("/ingest")]
    public async Task<PackageMetadata> Ingest([FromBody] ArtifactIngestInput input)
    {
       /* Get file from wherever */
       
       /* Read package.json from .tgz file */
       
        
       /* If metadata present in db, load previous to append and process */
       /* Populate PackageVersionMetadata object */
       
       /* Add to / Create metadata object, store metadata object in database */
       
       return null;
    }
}