﻿// 框架名称：Fur
// 框架作者：百小僧
// 框架版本：1.0.0
// 开源协议：MIT
// 项目地址：https://gitee.com/monksoul/Fur

using Fur.SpecificationDocument;

namespace Microsoft.AspNetCore.Builder
{
    /// <summary>
    /// 规范化文档中间件拓展
    /// </summary>
    public static class SpecificationDocumentApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseSpecificationDocuments(this IApplicationBuilder app)
        {
            // 配置 Swagger 全局参数
            app.UseSwagger(options => SpecificationDocumentBuilder.Build(options));

            // 配置 Swagger UI 参数
            app.UseSwaggerUI(options => SpecificationDocumentBuilder.BuildUI(options));

            return app;
        }
    }
}