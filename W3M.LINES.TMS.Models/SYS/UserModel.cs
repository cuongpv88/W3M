using System;
using System.Collections.Generic;
using System.Text;

namespace W3M.LINES.TMS.Models
{
    public class UserModel
    {

        /// <summary>
        /// 标识
        /// </summary>		
        private int _uid;
        public int Uid
        {
            get { return _uid; }
            set { _uid = value; }
        }
        /// <summary>
        /// 登录名
        /// </summary>		
        private string _username;
        public string UserName
        {
            get { return _username; }
            set { _username = value; }
        }
        /// <summary>
        /// 密码
        /// </summary>		
        private string _userpwd;
        public string UserPwd
        {
            get { return _userpwd; }
            set { _userpwd = value; }
        }
        /// <summary>
        /// 真实名
        /// </summary>		
        private string _factname;
        public string FactName
        {
            get { return _factname; }
            set { _factname = value; }
        }
        /// <summary>
        /// 电话号码
        /// </summary>		
        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        /// <summary>
        /// 手机号码
        /// </summary>		
        private string _tel;
        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }
        /// <summary>
        /// 邮箱
        /// </summary>		
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        /// <summary>
        /// 类型
        /// </summary>		
        private string _usertype;
        public string UserType
        {
            get { return _usertype; }
            set { _usertype = value; }
        }
        /// <summary>
        /// 隶属部门
        /// </summary>		
        private int _dpid;
        public int DPid
        {
            get { return _dpid; }
            set { _dpid = value; }
        }
        /// <summary>
        /// 隶属供应商
        /// </summary>		
        private int _nfid;
        public int NFid
        {
            get { return _nfid; }
            set { _nfid = value; }
        }
        /// <summary>
        /// 所属客户
        /// </summary>		
        private int _cid;
        public int Cid
        {
            get { return _cid; }
            set { _cid = value; }
        }
        /// <summary>
        /// 所属收货人
        /// </summary>		
        private int _rcid;
        public int RCid
        {
            get { return _rcid; }
            set { _rcid = value; }
        }
        /// <summary>
        /// 角色
        /// </summary>		
        private int _rid;
        public int Rid
        {
            get { return _rid; }
            set { _rid = value; }
        }
        /// <summary>
        /// 备注
        /// </summary>		
        private string _memo;
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }
        /// <summary>
        /// 汉字拼音简码
        /// </summary>		
        private string _retrievalcode;
        public string RetrievalCode
        {
            get { return _retrievalcode; }
            set { _retrievalcode = value; }
        }
        /// <summary>
        /// 是否有效
        /// </summary>		
        private bool _isenable;
        public bool IsEnable
        {
            get { return _isenable; }
            set { _isenable = value; }
        }
        /// <summary>
        /// 创建人
        /// </summary>		
        private string _createuser;
        public string CreateUser
        {
            get { return _createuser; }
            set { _createuser = value; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>		
        private DateTime _createdate;
        public DateTime CreateDate
        {
            get { return _createdate; }
            set { _createdate = value; }
        }
        /// <summary>
        /// 修改人
        /// </summary>		
        private string _modifyuser;
        public string ModifyUser
        {
            get { return _modifyuser; }
            set { _modifyuser = value; }
        }
        /// <summary>
        /// 修改时间
        /// </summary>		
        private DateTime _modifydate;
        public DateTime ModifyDate
        {
            get { return _modifydate; }
            set { _modifydate = value; }
        }
    }
}
