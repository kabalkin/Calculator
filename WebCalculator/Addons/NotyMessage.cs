namespace Addons
{
    public class NotyMessage
    {
        public string Message { get; set; }
        /// <summary>
        /// Message type. Can be only: 
        /// Success
        /// Info
        /// Warning
        /// Error
        /// </summary>
        /// <value></value>
        public string Type { get; set; }
    }
}