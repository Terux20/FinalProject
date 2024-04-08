using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.DataAcecess
    {//generic constraint
    //ALTTAKI KODDA ANLATILMAK İSTENEN REFERANS OLARAK KULLANILABİLECEK DEĞERLERİ IENTITY
    //VE ONUN ALT KATMANINDAKİ SINIFLAR HARİCİ REFERANS KULLANILMASINI İSTEMEMİZDEN DOLAYI
    // WHERE KOŞULU KULLANIYORUZ 
    //IENTITY YI İMPLEMENT EDEN BİR NESNE OLABİLİR 
    //NEW ISE IENTITY INTERFACE İNİN NEWLENEMEDİĞİNİ BİLDİĞİMİZ İÇİN NEW KOŞULU OLUŞMASINI İSTİYORUZ Kİ
    //
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

    }
}
