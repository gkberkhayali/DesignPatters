using Newtonsoft.Json;

namespace RepositoryPatternCoreWebApi.GenericModals
{
    public class ResponseModal<T>
    {
        [JsonProperty]
        public List<T> dataList { get; set; }
    
        [JsonProperty]
        public T data { get; set; }

        [JsonProperty]
        public bool status { get; set; }
      
        public void SetDataList(List<T> dataList)
        {
            this.dataList = dataList;
            this.status = true;
        }
        public void SetData(T data)
        {
            this.data = data;
            this.status = true;
        }
    }
}
