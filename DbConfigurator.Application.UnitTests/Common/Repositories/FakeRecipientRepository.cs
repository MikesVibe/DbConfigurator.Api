using DbConfigurator.Application.Contracts.Persistence;
using DbConfigurator.Application.Features.DistributionInformationFeature;
using DbConfigurator.Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConfigurator.Application.UnitTests.Common.Repositories
{
    public class FakeRecipientRepository : IRecipientRepository
    {
        private List<Recipient> _recipients;

        public FakeRecipientRepository()
        {
            _recipients = new List<Recipient>()
            {
                new Recipient { Id=1, FirstName="Whitney",LastName= "Soto",Email= "Whitney.Soto@company.net"},
                new Recipient { Id=2, FirstName = "Tia", LastName = "Lynn", Email = "Tia.Lynn@company.net" },
                new Recipient { Id=3, FirstName = "Amin", LastName = "Stevens", Email = "Amin.Stevens@company.net" },
                new Recipient { Id=4, FirstName = "Osian", LastName = "Chambers", Email = "Osian.Chambers@company.net" },
                new Recipient { Id=5, FirstName = "Sean", LastName = "Nguyen", Email = "Sean.Nguyen@company.net" }
            };
        }
        public Task<Recipient> AddAsync(Recipient entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Recipient value)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ExistsRangeAsync(IEnumerable<RecipientIdDto> recipientIds)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Recipient>> GetAllAsync()
        {
            await Task.CompletedTask;
            return _recipients;
        }

        public async Task<Recipient?> GetByIdAsync(int id)
        {
            await Task.CompletedTask;
            return _recipients.Where(r => r.Id == id).Single();
        }

        public async Task<ICollection<Recipient>> GetRecipientsAsync(ICollection<RecipientIdDto> recipientIds)
        {
            await Task.CompletedTask;
            var recipientsToReturn = new List<Recipient>();

            foreach (var recipientId in recipientIds)
            {
                var recipient = await GetByIdAsync(recipientId.Id);
                if (recipient == null)
                    throw new ArgumentNullException();

                recipientsToReturn.Add(recipient);
            }

            return recipientsToReturn;
        }

        public Task<bool> UpdateAsync(Recipient entity)
        {
            throw new NotImplementedException();
        }
    }
}
