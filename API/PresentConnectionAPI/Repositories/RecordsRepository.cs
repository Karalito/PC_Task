using Microsoft.EntityFrameworkCore;
using PresentConnectionAPI.Config;
using PresentConnectionAPI.Models;

namespace PresentConnectionAPI.Repositories
{
    internal sealed class RecordsRepository
    {
        internal async static Task<List<Record>> GetRecordsAsync()
        {
            using(var db = new RecordsDBContext())
            {
                return await db.Records.ToListAsync();
            }
        }

        internal async static Task<Record> GetRecordByIdAsync(int id)
        {
            using (var db = new RecordsDBContext())
            {
                var record = await db.Records.SingleOrDefaultAsync(x => x.Id == id);

                if (record == null) throw new ArgumentException("Record not found");
                
                return record;
            }
        }

        internal async static Task<bool> CreateRecordAsync(Record newRecord)
        {
            using (var db = new RecordsDBContext())
            {
                try
                {
                    await db.Records.AddAsync(newRecord);

                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        internal async static Task<bool> UpdateRecordAsync(Record updatePost)
        {
            using (var db = new RecordsDBContext())
            {
                try
                {
                    db.Records.Update(updatePost);

                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        internal async static Task<bool> DeleteRecordAsync(int id)
        {
            using(var db = new RecordsDBContext())
            {
                try
                {
                    Record recordToDelete = await GetRecordByIdAsync(id);

                    db.Remove(recordToDelete);

                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
    }
}
