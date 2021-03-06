using System;

namespace Seabites.Naughty.Security {
  public struct RoleGroupId : IEquatable<RoleGroupId> {
    readonly Guid _value;

    public RoleGroupId(Guid value) {
      _value = value;
    }

    public static bool operator ==(RoleGroupId left, RoleGroupId right) {
      return left.Equals(right);
    }

    public static bool operator !=(RoleGroupId left, RoleGroupId right) {
      return !left.Equals(right);
    }

    public bool Equals(RoleGroupId other) {
      return _value.Equals(other._value);
    }

    public override bool Equals(object obj) {
      if (ReferenceEquals(null, obj)) return false;
      return obj is RoleGroupId && Equals((RoleGroupId) obj);
    }

    public override int GetHashCode() {
      return _value.GetHashCode();
    }

    public static implicit operator Guid(RoleGroupId id) {
      return id._value;
    }

    public override string ToString() {
      return String.Format("RoleGroup/{0}", _value.ToString().ToUpperInvariant());
    }
  }
}