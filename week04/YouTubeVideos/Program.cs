using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("How to train your spiderman", "Stan Lee", 35);

        Comment c1 = new Comment("user 1", "comment 1");
        Comment c2 = new Comment("user 2", "comment 2");
        Comment c3 = new Comment("user 3", "comment 3");

        v1.CreateCommentList(c1);
        v1.CreateCommentList(c2);
        v1.CreateCommentList(c3);
        v1.DisplayCommentList();
        v1.NumberOfComments();

        
        
        Video v2 = new Video("The best way to control people with rings", "Sauron", 900);

        Comment c4 = new Comment("user 4", "comment 4");
        Comment c5 = new Comment("user 5", "comment 5");
        Comment c6 = new Comment("user 6", "comment 6");

        v2.CreateCommentList(c4);
        v2.CreateCommentList(c5);
        v2.CreateCommentList(c6);

        v2.DisplayCommentList();
        v2.NumberOfComments();

        


        Video v3 = new Video("My favorite Lasagna", "Garfield01", 4000);

        Comment c7 = new Comment("user 7", "comment 7");
        Comment c8 = new Comment("user 8", "comment 8");
        Comment c9 = new Comment("user 9", "comment 9");

        v3.CreateCommentList(c7);
        v3.CreateCommentList(c8);
        v3.CreateCommentList(c9);
        v3.DisplayCommentList();
        v3.NumberOfComments();

        

    }
}