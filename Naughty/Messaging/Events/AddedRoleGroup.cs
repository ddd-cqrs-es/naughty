using System;

namespace Seabites.Naughty.Messaging.Events {
  public class AddedRoleGroup {
    public readonly Guid RoleGroupId;
    public readonly string Name;

    public AddedRoleGroup(Guid roleGroupId, string name) {
      RoleGroupId = roleGroupId;
      Name = name;
    }
  }
}