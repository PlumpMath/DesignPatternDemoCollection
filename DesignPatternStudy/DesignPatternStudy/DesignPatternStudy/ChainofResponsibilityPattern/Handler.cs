using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternStudy.ChainofResponsbilityPattern
{
    /**
     * 处理者基类
     * 职责：
     * 1.定义请求的处理方法handleMessage()
     * 2.定义一个链的编排方法setNext()
     * 3.具体的请求者必须实现两个方法:定义自己能够处理的级别getHandlerLevel()和具体处理任务echo()
     */

    public class Handler
    {
        private Handler nextHandler;

        public Response handleMessage(Request1 request)
        {
            Response response = null;
            //是否自己处理级别
            if (this.getHandlerLevel().levelNumber == request.getRequestLevel().levelNumber)
            {
                response = this.echo(request);
            }
            else
            {
                //是否有下一个处理者
                if (this.nextHandler != null)
                {
                    response = this.nextHandler.handleMessage(request);
                }
                else
                {
                    //没有人处理时的默认业务
                    Console.WriteLine("请求 str=" + request.testStr + ",level=" + request.getRequestLevel().levelNumber + " 没人处理");
                }
            }
            return response;
        }

        //设置下一个处理者
        public void setNext(Handler _handler)
        {
            this.nextHandler = _handler;
        }

        //每个处理者都有一个处理级别
        protected virtual Level getHandlerLevel()
        {
            return null;
        }

        //每个处理者都必须实现处理任务
        protected virtual Response echo(Request1 request)
        {
            return null;
        }
    }
}