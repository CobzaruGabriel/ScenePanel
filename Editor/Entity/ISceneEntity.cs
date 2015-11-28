﻿/// ------------------------------------------------
/// <summary>
/// IScene Entity
/// Purpose: 	Interface for a scene identity.
/// Author:		Juan Silva
/// Date: 		November 22, 2015
/// Copyright (c) Tuxedo Berries All rights reserved.
/// </summary>
/// ------------------------------------------------
using System;
using UnityEngine;

namespace TuxedoBerries.ScenePanel
{
	public interface ISceneEntity : ISceneFileEntity
	{

		/// <summary>
		/// Gets a value indicating whether this scene is marked as favorite.
		/// </summary>
		/// <value><c>true</c> if this instance is favorite; otherwise, <c>false</c>.</value>
		bool IsFavorite {
			get;
			set;
		}

		/// <summary>
		/// Determine if the scene is the current active scene.
		/// </summary>
		/// <value><c>true</c> if the scene is active; otherwise, <c>false</c>.</value>
		bool IsActive {
			get;
		}

		/// <summary>
		/// Gets the snapshot path.
		/// </summary>
		/// <value>The snapshot path.</value>
		string SnapshotPath {
			get;
		}

		#region Only in Build
		/// <summary>
		/// Determine if the scene is in the build list or not.
		/// </summary>
		/// <value><c>true</c> if is in build; otherwise, <c>false</c>.</value>
		bool InBuild {
				get;
		}

		/// <summary>
		/// Determine if the scene is in the build is enabled or not.
		/// </summary>
		/// <value><c>true</c> if this instance is enabled; otherwise, <c>false</c>.</value>
		bool IsEnabled {
			get;
		}

		/// <summary>
		/// Gets the index in the build.
		/// </summary>
		/// <value>The index in the build.</value>
		int BuildIndex {
			get;
		}
		#endregion
	}
}

