﻿using Entities.Enums;
using Entities.Models;

namespace Repository;

internal class MockQTITestRepositoryConfiguration
{
    public static List<QTITest> InitialData()
    {
        return new List<QTITest>
        {
            new QTITest
            {
                //Id = Guid.NewGuid(),
                Name = "Test 1",
                Description = "Description for Test 1",
                PackageBase64 = "dGVzdDE=",
                Tags = new[] { "tag1", "tag2" },
                Status = TestStatusEnum.Active,
                Uploaded = DateTime.Now
            },
            new QTITest
            {
                //Id = Guid.NewGuid(),
                Name = "Test 2",
                Description = "Description for Test 2",
                PackageBase64 = "dGVzdDI=",
                Tags = new[] { "tag3", "tag4" },
                Status = TestStatusEnum.InActive,
                Uploaded = DateTime.Now.AddDays(-1)
            },
            new QTITest
            {
                //Id = Guid.NewGuid(),
                Name = "Test 3",
                Description = "Description for Test 2",
                PackageBase64 = "dGVzdDI=",
                Tags = new[] { "tag3", "tag4" },
                Status = TestStatusEnum.InActive,
                Uploaded = DateTime.Now.AddDays(-1)
            },
            new QTITest
            {
                //Id = Guid.NewGuid(),
                Name = "Test 4",
                Description = "Description for Test 2",
                PackageBase64 = "dGVzdDI=",
                Tags = new[] { "tag3", "tag4" },
                Status = TestStatusEnum.InActive,
                Uploaded = DateTime.Now.AddDays(-1)
            },
            new QTITest
            {
                //Id = Guid.NewGuid(),
                Name = "Test 5",
                Description = "Description for Test 2",
                PackageBase64 = "dGVzdDI=",
                Tags = new[] { "tag3", "tag4" },
                Status = TestStatusEnum.InActive,
                Uploaded = DateTime.Now.AddDays(-1)
            }
        };
    }

}
