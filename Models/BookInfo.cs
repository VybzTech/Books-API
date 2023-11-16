namespace API.Models
{
    public class BookInfo
    {
            // creating string, int and array list variables for our book details
            private String title;
            private String subtitle;
            private List<String> authors;
            private String publisher;
            private String publishedDate;
            private String description;
            private int pageCount;
            private String thumbnail;
            private String previewLink;
            private String infoLink;
            private String buyLink;

            // creating getter and setter methods
            public String getTitle()=>title;
            

            public void setTitle(String title)=>this.title = title;

            public String getSubtitle()
                =>subtitle;

            public void setSubtitle(String subtitle)
            =>
                this.subtitle = subtitle;
            

            public List<String> getAuthors()
            =>
              authors;
            

            public void setAuthors(List<String> authors)
            =>
                this.authors = authors;
            

            public String getPublisher()
            =>publisher;
            

            public void setPublisher(String publisher)
            =>
                this.publisher = publisher;
            

            public String getPublishedDate()

            => publishedDate;
            

            public void setPublishedDate(String publishedDate)
            =>
                this.publishedDate = publishedDate;
            

            public String getDescription()
            =>
              description;
            

            public void setDescription(String description)

            => this.description = description;
            

            public int getPageCount()
            
=>pageCount;

            public void setPageCount(int pageCount)
=>                this.pageCount = pageCount;

            public String getThumbnail()
=>thumbnail;

            public void setThumbnail(String thumbnail)
            
            =>    this.thumbnail = thumbnail;
            

            public String getPreviewLink()
            =>
              previewLink;
            

            public void setPreviewLink(String previewLink)

            => this.previewLink = previewLink;
            

            public String getInfoLink()

            => infoLink;
            

            public void setInfoLink(String infoLink)

            => this.infoLink = infoLink;
            

            public String getBuyLink()

            => buyLink;
            

            public void setBuyLink(String buyLink)
        
            =>    this.buyLink = buyLink;
            

            // CONSTRUCTOR
            public BookInfo(String title, String subtitle, List<String> authors, String publisher,
                            String publishedDate, String description, int pageCount, String thumbnail,
                            String previewLink, String infoLink, String buyLink)
            {
                this.title = title;
                this.subtitle = subtitle;
                this.authors = authors;
                this.publisher = publisher;
                this.publishedDate = publishedDate;
                this.description = description;
                this.pageCount = pageCount;
                this.thumbnail = thumbnail;
                this.previewLink = previewLink;
                this.infoLink = infoLink;
                this.buyLink = buyLink;
            }

    }
}
