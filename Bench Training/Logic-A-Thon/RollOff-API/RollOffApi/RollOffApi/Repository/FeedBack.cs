using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RollOffApi.Repository
{
    public class FeedBack:IFeedBack
    {
        private readonly RollOff_DBContext context;
        public FeedBack(RollOff_DBContext context)
        {
            this.context = context;
        }
        #region AddFeedbackAsync
        public async Task<FeedbackForm> AddFeedbackAsync(FeedbackForm feedback)
        {
            await context.AddAsync(feedback);
            await context.SaveChangesAsync();
            return feedback;
        }

        public async Task<FeedbackForm> GetByIdAsync(double id)
        {
            return await context.FeedbackForms.FirstOrDefaultAsync(x => x.Id == id);
        }

        #endregion

        #region GetFeedbackAsync
        public async Task<IEnumerable<FeedbackForm>> GetFeedbackDetailsAsync()
        {
            return await context.FeedbackForms.ToListAsync();
        }
        #endregion

    }
}

