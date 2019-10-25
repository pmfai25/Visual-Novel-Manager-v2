﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using LiteDB;
using VisualNovelManagerCore.Controls.Vndb.AddVn;
using VisualNovelManagerCore.Database;
using VisualNovelManagerCore.Database.Model.VNDB.VnCharacter;
using VisualNovelManagerCore.Database.Model.VNDB.VnInfo;
using VisualNovelManagerCore.Helper.Vndb;
using VndbSharp;
using VndbSharp.Models;
using VndbSharp.Models.Character;
using VndbSharp.Models.Release;
using VndbSharp.Models.VisualNovel;

namespace VisualNovelManagerCore
{
    public class TesterForDebug
    {
        public void CallTestMethods()
        {
#if DEBUG
            Test1Async();
            Test2();
            Test3();
#else

#endif
        }

        private async Task Test1Async()
        {
            Debug.WriteLine("method works");
            using (VndbSharp.Vndb client = new VndbSharp.Vndb(true))
            {
                bool hasMore = true;
                RequestOptions ro = new RequestOptions { Count = 25 };
                int pageCount = 1;
                int characterCount = 0;
                int releasesCount = 0;

                VndbResponse<VisualNovel> visualNovels = await client.GetVisualNovelAsync(VndbFilters.Id.Equals(11), VndbFlags.FullVisualNovel);
                if (visualNovels == null)
                {
                    HandleError.HandleErrors(client.GetLastError(), 0);
                    return;
                }
                var addDb = new AddDataToDb();
                //addDb.FormatVnInfo(visualNovels);
                using (var db = new LiteDatabase(@"Database.db"))
                {
                    //var tbl = db.GetCollection<VnCharacterInfo>("vninfo");
                    //var visualnovel = visualNovels.FirstOrDefault();
                    //var vninfo = new VnCharacterInfo
                    //{
                    //    VnId = 4,
                    //    CharacterId = visualnovel.Id,
                    //    Name = visualnovel.Name,
                    //    Original = visualnovel.OriginalName,
                    //    Description = visualnovel.Description
                    //};
                    //tbl.Upsert(vninfo);
                    ////tbl.Insert(characterList);
                    //tbl.EnsureIndex(x => x.Id);
                    ////var result = tbl.FindOne(x => x.Name.Equals("Shirogane Takeru"));
                    //var result = tbl.FindById(1);
                    //VnCharacterInfo res2 = tbl.Find(x => x.Name == "Clannad").FirstOrDefault();
                    var dbtest = db.GetCollection<VnInfo>("vninfo");
                    var vninfo = new VnInfo()
                    {
                        VnId = 92,
                        Title = "Muv Luv ALternative",
                        Aliases = "test1,test2"
                        
                    };
                    dbtest.Upsert(vninfo);
                    //var foo = dbVnInfo.FindById(1);
                    //var bar = dbVnInfo.FindAll().ToList();
                }


            }
        }
        private void Test2()
        {

        }
        private void Test3()
        {

        }
    }
}
