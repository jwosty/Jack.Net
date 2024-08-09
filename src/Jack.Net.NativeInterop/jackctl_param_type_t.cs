namespace Jack.Net.NativeInterop
{
    [NativeTypeName("unsigned int")]
    public enum jackctl_param_type_t : uint
    {
        JackParamInt = 1,
        JackParamUInt,
        JackParamChar,
        JackParamString,
        JackParamBool,
    }
}
