using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessT.Concrete;
using BusinessT.Abstract;
using DataAccessT.Concrete;
using DataAccessT.Abstract;

namespace BusinessT.Dependency.autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<UserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<BlogPostManager>().As<IBlogPostService>().SingleInstance();
            builder.RegisterType<BlogPostDal>().As<IBlogPostDal>().SingleInstance();

            builder.RegisterType<CommentManager>().As<ICommentService>().SingleInstance();
            builder.RegisterType<CommentDal>().As<ICommentDal>().SingleInstance();

            builder.RegisterType<BaseContext>().As<BaseContext>().SingleInstance();
        }
    }
}
