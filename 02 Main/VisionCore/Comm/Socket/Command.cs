namespace DMSkin.Socket
{
    public enum Command
    {
        RequestSendFile = 1,
        ResponeSendFile = 1048577,
        RequestSendFilePack = 2,
        ResponeSendFilePack = 1048578,
        RequestCancelSendFile = 3,
        ResponeCancelSendFile = 1048579,
        RequestCancelReceiveFile = 4,
        ResponeCancelReceiveFile = 1048580,
        RequestSendTextMSg = 16
    }
}
