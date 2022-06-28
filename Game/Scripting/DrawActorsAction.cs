using System.Collections.Generic;
using Unit05.Game.Casting;
using Unit05.Game.Services;


namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An output action that draws all the actors.</para>
    /// <para>The responsibility of DrawActorsAction is to draw each of the actors.</para>
    /// </summary>
    public class DrawActorsAction : Action
    {
        private VideoService videoService;

        /// <summary>
        /// Constructs a new instance of ControlActorsAction using the given KeyboardService.
        /// </summary>
        public DrawActorsAction(VideoService videoService)
        {
            this.videoService = videoService;
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            Snake snake = (Snake)cast.GetFirstActor("snake");
            List<Actor> segments = snake.GetSegments();
            Actor score = cast.GetFirstActor("score");
            Actor food = cast.GetFirstActor("food");
            List<Actor> messages = cast.GetActors("messages");
            
            videoService.ClearBuffer();
            videoService.DrawActors(segments);
            videoService.DrawActor(score);
            videoService.DrawActors(messages);
            videoService.FlushBuffer();

            Snake2 snake2 = (Snake2)cast.GetFirstActor("snake2");
            List<Actor> segments2 = snake2.GetSegments();
            Actor score2 = cast.GetFirstActor("score2");
            Actor food2 = cast.GetFirstActor("food2");
            List<Actor> messages2 = cast.GetActors("messages2");
            
            videoService.ClearBuffer();
            videoService.DrawActors(segments2);
            videoService.DrawActor(score);
            videoService.DrawActors(messages);
            
        }
    }
}