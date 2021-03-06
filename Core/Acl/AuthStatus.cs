﻿namespace ScrewTurn.Wiki.Acl {

	/// <summary>
	/// Lists legal values for authorizations.
	/// </summary>
	public enum AuthStatus {
		/// <summary>
		/// Grant the action.
		/// </summary>
		Grant,
		/// <summary>
		/// Deny the action.
		/// </summary>
		Deny,
		/// <summary>
		/// Delete the permission entry.
		/// </summary>
		Delete
	}

}
