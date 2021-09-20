using Persistence;

namespace API.Controllers
{
    public class ActivitiesController : BaseApiController
    {
        public ActivitiesController (DataContext contex)
        {
            _context = context;
        }

        [httpGet]
        public async task<ActionResult<list<Activity>>> GetActivities(){
            
        }
    }
}