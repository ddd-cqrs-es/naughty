using System;

namespace Seabites.Naughty.Messaging {
  public class RemovedRoleFromRoleGroup {
    public readonly Guid RoleGroupId;
    public readonly Guid RoleId;
    public RemovedRoleFromRoleGroup(Guid roleGroupId, Guid roleId) {
      RoleGroupId = roleGroupId;
      RoleId = roleId;
    }
  }
}