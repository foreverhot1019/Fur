﻿// -----------------------------------------------------------------------------
// Fur 是 .NET 5 平台下极易入门、极速开发的 Web 应用框架。
// Copyright © 2020 Fur, Baiqian Co.,Ltd.
//
// 框架名称：Fur
// 框架作者：百小僧
// 框架版本：1.0.0
// 源码地址：https://gitee.com/monksoul/Fur
// 开源协议：Apache-2.0（http://www.apache.org/licenses/LICENSE-2.0）
// -----------------------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace Fur.DatabaseAccessor
{
    /// <summary>
    /// 数据库实体全局配置依赖接口
    /// </summary>
    public interface IEntityInfluence : IEntityInfluence<DbContextLocator>
    {
    }

    /// <summary>
    /// 数据库实体全局配置依赖接口
    /// </summary>
    /// <typeparam name="TDbContextLocator1">数据库上下文定位器</typeparam>
    public interface IEntityInfluence<TDbContextLocator1> : IEntityInfluencePrivate
        where TDbContextLocator1 : class, IDbContextLocator, new()
    {
    }

    /// <summary>
    /// 数据库实体全局配置依赖接口
    /// </summary>
    /// <typeparam name="TDbContextLocator1">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator2">数据库上下文定位器</typeparam>
    public interface IEntityInfluence<TDbContextLocator1, TDbContextLocator2> : IEntityInfluencePrivate
        where TDbContextLocator1 : class, IDbContextLocator, new()
        where TDbContextLocator2 : class, IDbContextLocator, new()
    {
    }

    /// <summary>
    /// 数据库实体全局配置依赖接口
    /// </summary>
    /// <typeparam name="TDbContextLocator1">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator2">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator3">数据库上下文定位器</typeparam>
    public interface IEntityInfluence<TDbContextLocator1, TDbContextLocator2, TDbContextLocator3> : IEntityInfluencePrivate
        where TDbContextLocator1 : class, IDbContextLocator, new()
        where TDbContextLocator2 : class, IDbContextLocator, new()
        where TDbContextLocator3 : class, IDbContextLocator, new()
    {
    }

    /// <summary>
    /// 数据库实体全局配置依赖接口
    /// </summary>
    /// <typeparam name="TDbContextLocator1">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator2">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator3">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator4">数据库上下文定位器</typeparam>
    public interface IEntityInfluence<TDbContextLocator1, TDbContextLocator2, TDbContextLocator3, TDbContextLocator4> : IEntityInfluencePrivate
        where TDbContextLocator1 : class, IDbContextLocator, new()
        where TDbContextLocator2 : class, IDbContextLocator, new()
        where TDbContextLocator3 : class, IDbContextLocator, new()
        where TDbContextLocator4 : class, IDbContextLocator, new()
    {
    }

    /// <summary>
    /// 数据库实体全局配置依赖接口
    /// </summary>
    /// <typeparam name="TDbContextLocator1">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator2">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator3">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator4">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator5">数据库上下文定位器</typeparam>
    public interface IEntityInfluence<TDbContextLocator1, TDbContextLocator2, TDbContextLocator3, TDbContextLocator4, TDbContextLocator5> : IEntityInfluencePrivate
        where TDbContextLocator1 : class, IDbContextLocator, new()
        where TDbContextLocator2 : class, IDbContextLocator, new()
        where TDbContextLocator3 : class, IDbContextLocator, new()
        where TDbContextLocator4 : class, IDbContextLocator, new()
        where TDbContextLocator5 : class, IDbContextLocator, new()
    {
    }

    /// <summary>
    /// 数据库实体全局配置依赖接口
    /// </summary>
    /// <typeparam name="TDbContextLocator1">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator2">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator3">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator4">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator5">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator6">数据库上下文定位器</typeparam>
    public interface IEntityInfluence<TDbContextLocator1, TDbContextLocator2, TDbContextLocator3, TDbContextLocator4, TDbContextLocator5, TDbContextLocator6> : IEntityInfluencePrivate
        where TDbContextLocator1 : class, IDbContextLocator, new()
        where TDbContextLocator2 : class, IDbContextLocator, new()
        where TDbContextLocator3 : class, IDbContextLocator, new()
        where TDbContextLocator4 : class, IDbContextLocator, new()
        where TDbContextLocator5 : class, IDbContextLocator, new()
        where TDbContextLocator6 : class, IDbContextLocator, new()
    {
    }

    /// <summary>
    /// 数据库实体全局配置依赖接口
    /// </summary>
    /// <typeparam name="TDbContextLocator1">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator2">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator3">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator4">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator5">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator6">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator7">数据库上下文定位器</typeparam>
    public interface IEntityInfluence<TDbContextLocator1, TDbContextLocator2, TDbContextLocator3, TDbContextLocator4, TDbContextLocator5, TDbContextLocator6, TDbContextLocator7> : IEntityInfluencePrivate
        where TDbContextLocator1 : class, IDbContextLocator, new()
        where TDbContextLocator2 : class, IDbContextLocator, new()
        where TDbContextLocator3 : class, IDbContextLocator, new()
        where TDbContextLocator4 : class, IDbContextLocator, new()
        where TDbContextLocator5 : class, IDbContextLocator, new()
        where TDbContextLocator6 : class, IDbContextLocator, new()
        where TDbContextLocator7 : class, IDbContextLocator, new()
    {
    }

    /// <summary>
    /// 数据库实体全局配置依赖接口
    /// </summary>
    /// <typeparam name="TDbContextLocator1">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator2">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator3">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator4">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator5">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator6">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator7">数据库上下文定位器</typeparam>
    /// <typeparam name="TDbContextLocator8">数据库上下文定位器</typeparam>
    public interface IEntityInfluence<TDbContextLocator1, TDbContextLocator2, TDbContextLocator3, TDbContextLocator4, TDbContextLocator5, TDbContextLocator6, TDbContextLocator7, TDbContextLocator8> : IEntityInfluencePrivate
        where TDbContextLocator1 : class, IDbContextLocator, new()
        where TDbContextLocator2 : class, IDbContextLocator, new()
        where TDbContextLocator3 : class, IDbContextLocator, new()
        where TDbContextLocator4 : class, IDbContextLocator, new()
        where TDbContextLocator5 : class, IDbContextLocator, new()
        where TDbContextLocator6 : class, IDbContextLocator, new()
        where TDbContextLocator7 : class, IDbContextLocator, new()
        where TDbContextLocator8 : class, IDbContextLocator, new()
    {
    }

    /// <summary>
    /// 数据库实体全局配置依赖接口（禁止外部继承）
    /// </summary>
    public interface IEntityInfluencePrivate : IModelCreating
    {
        /// <summary>
        /// 全局配置
        /// </summary>
        /// <param name="entityBuilder">实体构建器</param>
        /// <param name="dbContext">数据库上下文</param>
        /// <param name="dbContextLocator">数据库上下文定位器</param>
        /// <returns></returns>
        IEnumerable<object> Influence(EntityTypeBuilder entityBuilder, DbContext dbContext, IDbContextLocator dbContextLocator);
    }
}