//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Seven7c.OA.Model
{
    using System;
    using System.Collections.Generic;
    
    [Serializable]
    public partial class Messsage
    {
        public Messsage()
        {
            this.DelFlagSend = 0;
            this.DelFlagGet = 0;
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string FileUrl { get; set; }
        public System.DateTime SendTime { get; set; }
        public Nullable<int> SendTo { get; set; }
        public Nullable<int> SendRoles { get; set; }
        public int UserInfoId { get; set; }
        public bool IsRead { get; set; }
        public short DelFlagSend { get; set; }
        public short DelFlagGet { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
    }
}
