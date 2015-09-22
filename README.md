##.net 简单任务调度平台

用于.net dll,exe的任务的挂载，任务的隔离，调度执行，访问权限控制，监控，管理，日志，错误预警，性能分析等。

1) 平台基于quartz.net进行任务调度功能开发，采用C#代码编写, 支持corn表达式和第三方自定义的corn表达式扩展。

2) 架构以插件形式开发，具有良好的功能扩展性，稳定性，简单性，便于第三方开发人员进一步进行功能扩展。

3) 支持多节点集群，便于集群服务器的资源有效分配，任务的相互隔离。

4) 支持邮件形式的错误预警，便于运维及时处理任务异常等。


（项目允许用于第三方公司进行二次开发且在公司内部使用，但禁止以盈利为目的进行商业行为）



-- 车江毅 2015-06-17


##未来构想：

1) 任务故障转移: 检测到任务持续故障n次或者故障频率，判定进行异地节点/节点集群内的任务启动，可支持n次故障恢复。
2）任务负载均衡: 多个任务并行执行，用于高资源负载任务的多节点运行。
3）任务拆分: 一个父级任务可以创建多个子任务，并对任务进行管理，调度，故障恢复，预警等。


##其他备注:
1.项目编译时出现xxf命名空间问题,请使用"引用"下面的xxf进行编译。
  （任务调度sdk原先集成于xxf.baseservice下面,开源项目从xxf项目里分离出来，xxf代码暂不开源。）

