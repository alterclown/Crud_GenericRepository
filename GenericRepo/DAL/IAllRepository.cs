using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepo.DAL
{
    interface IAllRepository <T> where T: class
    {
        IEnumerable<T> getModel();
        T getModelById(int modelId);
        void insertModel(T model);
        void deleteModel(int modelId);
        void updateModel(T model);

        void save();
        void insertModel();
        void updateModel();
        void deleteModel();
        void Remove(int id);
    }
}
