namespace Jack.NET.Interop
{
    [NativeTypeName("unsigned int")]
    public enum jack_transport_state_t : uint
    {
        JackTransportStopped = 0,
        JackTransportRolling = 1,
        JackTransportLooping = 2,
        JackTransportStarting = 3,
    }
}
