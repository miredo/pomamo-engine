// Copyright (C) 2009-2023 Lemoine Automation Technologies
//
// SPDX-License-Identifier: Apache-2.0

using System;
using System.Data;
using System.Diagnostics;
using Lemoine.Core.Log;
using Migrator.Framework;

namespace Lemoine.GDBMigration
{
  /// <summary>
  /// Migration 817: deprecated
  /// </summary>
  [Migration (817)]
  public class RestoreSfkcfgs : MigrationExt
  {
    static readonly ILog log = LogManager.GetLogger (typeof (RestoreSfkcfgs).FullName);

    /// <summary>
    /// Update the database
    /// </summary>
    override public void Up ()
    {
    }

    /// <summary>
    /// Downgrade the database
    /// </summary>
    override public void Down ()
    {
    }
  }
}
