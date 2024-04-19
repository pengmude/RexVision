namespace DMSkin.Socket
{
    public enum SocketState
    {
        Connecting,
        Connected,
        Reconnection,
        Disconnect,
        StartListening,
        StopListening,
        ClientOnline,
        ClientOnOff
    }
}
