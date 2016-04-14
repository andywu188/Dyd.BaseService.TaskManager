using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Data;
using System.Text;
using XXF.Extensions;
using XXF.Db;
using XXF.BaseService.TaskManager.model;
using XXF.ProjectTool;

namespace XXF.BaseService.TaskManager.dal
{
	/*�����Զ����ɹ����Զ�����,��Ҫ������д�Լ��Ĵ��룬����ᱻ�Զ�����Ŷ - ����*/
	public partial class tb_error_dal
    {
        public int Add(DbConn PubConn, tb_error_model model)
        {
            return SqlHelper.Visit(ps =>
            {
                ps.Add("@msg", model.msg);
                ps.Add("@errortype", model.errortype);
                ps.Add("@errorcreatetime", model.errorcreatetime);
                ps.Add("@taskid", model.taskid);
                ps.Add("@nodeid", model.nodeid);
                return PubConn.ExecuteSql(@"insert into tb_error(msg,errortype,errorcreatetime,taskid,nodeid)
										   values(@msg,@errortype,@errorcreatetime,@taskid,@nodeid)", ps.ToParameters()) ;
            });
        }
    }
}