using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Day4
{
    internal class mediaContent
    {
        public virtual void StartPlayingContent() //to override the parent method use virtual
        {
            Console.WriteLine("start");
        }
        public virtual void  StopPlayingContent()
        {
            Console.WriteLine("stop");
        }
        public virtual void PauseContent()
        {
            Console.WriteLine("pause");
        }
        public virtual void ContinuePlaying() 
        {
            Console.WriteLine("continue"); 
        }
    public override sealed  string ToString()
        {
            return "hi";
        } 
    }
    internal class AudioContent : mediaContent
    {
        public override sealed void StartPlayingContent()//sealed make not to override and but can inherited
        {
            Console.WriteLine("start");
        }
        //public override string ToString (cannot be overrided because it is sealed)
        //{cw("audio")}

    }//end of audiocontent
    internal class VideoContent : AudioContent
    {
        //public void StartPlayinContent{
    //
        //}

    }//end of videocontent
    internal class MediaTester
    {
        public void TestOne()
        {

        }
    }//end of mediatest
}
