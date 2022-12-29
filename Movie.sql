CREATE DATABASE MOVIE
USE MOVIE

CREATE TABLE ACCOUNT(
	_NAME_ACCOUNT VARCHAR(20),
	_PASSWORD VARCHAR(20),
	_USERNAME NVARCHAR(50),
)

CREATE TABLE FILM(
	_ID INTEGER IDENTITY,
	_FILM_NAME NVARCHAR(50),
	_FILM_TYPE NVARCHAR(50),
	_FILM_YEAR_RELEASE INT,
	_FILM_ACTOR NVARCHAR(250),
	_FILM_COMMENT NVARCHAR(MAX),
	_FILM_COUNTRY NVARCHAR(50),
	_FILM_LANGUAGE NVARCHAR(50),
	_FILM_RATE INT,
	_FILM_URL VARCHAR(255)

)

ALTER TABLE FILM
ADD _FILM_IMAGE_URL VARCHAR(200)

ALTER TABLE FILM
ADD _FILM_WEB_URL VARCHAR(200)

ALTER TABLE FILM
ADD _FILM_CONTENT NVARCHAR(MAX)

CREATE TABLE GENRE(
	_ID INTEGER IDENTITY,
	_GENRE_NAME NVARCHAR(20),
)



SET IDENTITY_INSERT [GENRE] ON
INSERT INTO [GENRE]
([_ID],[_GENRE_NAME])
VALUES
(1,N'Hành động'),
(2,N'Tình cảm'),
(3,N'Tâm lí'),
(4,N'Hoạt hình')
SET IDENTITY_INSERT [GENRE] OFF

delete GENRE
delete FILM
delete ACCOUNT

drop table film
drop table GENRE

DECLARE @QUABAO NVARCHAR(MAX),
		@NOICHIENSHIRAZ NVARCHAR(MAX),
		@ONGTRUMPUBLO NVARCHAR(MAX),
		@GIAOANHIEMNGUY NVARCHAR(MAX),
		@CAUVANG NVARCHAR(MAX),
		@THOATHUANTRIEUDO NVARCHAR(MAX),
		@HUYENTHOAIKUNGFU NVARCHAR(MAX),
		@COHOIDUOCSONG NVARCHAR(MAX),

		@TOILANGUOIQUADUONG NVARCHAR(MAX),
		@CHAYTRONQUABIENGIOI NVARCHAR(MAX),
		@DOIBONGCUATREMOCOI NVARCHAR(MAX),
		@XEDAYHOA NVARCHAR(MAX),
		@THEHOOTOWL NVARCHAR(MAX),
		@VOTOILAGANGSTER NVARCHAR(MAX),
		@CHUNGQUYPHUCMA NVARCHAR(MAX),
		@NHIEPANNUONG NVARCHAR(MAX),

		@NGUOIBANNGOAIHANHTINH NVARCHAR(MAX),
		@HUYENTHOAIXUOZ NVARCHAR(MAX),
		@HAITACTIEN NVARCHAR(MAX),
		@COTIENGIUPICH NVARCHAR(MAX),
		@TOMANDJERRY NVARCHAR(MAX),
		@LINHCUUHOA NVARCHAR(MAX),
		@COTHETOIDAUROI NVARCHAR(MAX),
		@DACVUKHONGGIAN NVARCHAR(MAX),

		@LINHDUYEN NVARCHAR(MAX),
		@7NGAYYEU NVARCHAR(MAX),
		@NORATH NVARCHAR(MAX),
		@LINHHONLACLOI NVARCHAR(MAX),
		@LOIMOIGOILUCNUADEM NVARCHAR(MAX),
		@NGUOICOITRAU NVARCHAR(MAX),
		@OANHONTRONGMUA NVARCHAR(MAX),
		@KYNGHITAIUONG NVARCHAR(MAX)

SET @QUABAO = N'Sau khi cận kề cái chết, người đàn ông muồn từ bỏ tất cả để trở lại cuộc sống bình thường, nhưng anh phải trả giá cho những gì mình đã làm trong quá khứ.';
SET @NOICHIENSHIRAZ = N'Trước cuộc cách mạng Iran, người dân được thể hiện niềm tin tôn giáo của mình và được đối xử bình đẳng. Nhưng kể từ khi cuộc cách mạng diễn ra tháng 9 năm 1979, tất cả đã thay đổi. Dalia Sofer, một gia đình Do Thái bị cuốn vào cơn lốc cách mạng của Iran phải chạy trốn cuộc nội chiến ra sao?'
SET	@ONGTRUMPUBLO = N'Dựa theo lời kể của Virginia Vallejo – MC truyền hình nổi tiếng đồng thời cũng là người tình xinh đẹp của Pablo Escobar, bộ phim khắc họa chân thực đế chế ma túy khổng lồ và sự máu lạnh của ông trùm khét tiếng bậc nhất trong lịch sử.'
SET	@GIAOANHIEMNGUY = N'Sau khi một giáo viên qua đời, bạn thân của anh ấy – một cựu cảnh sát – đến làm việc ở ngôi trường anh ấy từng làm việc để đối đầu với nhóm người mà anh cho là gây ra cái chết đó.'
SET	@CAUVANG = N'Sống trong cảnh nghèo khó, một ông lão và bạn đồng hành là chú chó trung thành phải bảo vệ mảnh đất của họ khỏi bị một gia đình quen thói áp bức cướp đoạt.'
SET	@THOATHUANTRIEUDO = N'Khi bạn gái bị bắt cóc bởi một đường dây mại dâm ngầm, Frank và Simon, bạn thân của anh ta đã vay tiền chuộc từ một tỷ phú tên là The Kid. Để trả nợ cho khoản vay, hai người bạn phải thực hiện một loạt các nhiệm vụ đối đầu, ám sát những tên xã hội đen tàn bạo nhất châu Á. Trong khi đó, chính đường dây mại dâm cũng đang bị tấn công bởi một cặp sát thủ bí ẩn.'
SET	@HUYENTHOAIKUNGFU = N'Diệp Vấn, Trần Chân, Hoàng Phi Hồng, Hoắc Nguyên Giáp – 4 vị tôn sư võ thuật của Trung Quốc – sẽ cùng góp mặt trong HUYỀN THOẠI KUNG FU. Bốn võ sư, bốn môn phái, đại diện cho bốn thời đại khác nhau gặp nhau và gây ra vô số tình huống dở khóc dở cười. Liệu những rắc rối của thời hiện đại có khiến tứ đại tôn sư lừng danh thiên hạ trong quá khứ phải chùn bước?'
SET	@COHOIDUOCSONG =N'Ba người, bị bắt cóc nhốt trong những căn phòng khác nhau có thiết bị ghi âm… và một chiếc ghế điện, cùng với kẻ đã giết người thân của mình nhưng đều đã được tuyên trắng án tại tòa, đang bị trói chặt. Dưới sự bảo trợ của một giọng nói tự xưng là'

SET	@TOILANGUOIQUADUONG= N'I am somebody có nội dung đơn giản, không cầu kỳ nhưng vẫn đủ sức hút và ý nghĩa. Xoay quanh nhân vật Vạn Quốc Bằng, phim tập trung khai thác cuộc sống của những diễn viên chỉ chuyên đóng vai phụ, vai quần chúng. Thông qua những câu chuyện nhỏ về cuộc sống và công việc của họ, người xem dần nhận ra giá trị, mục đích sống và cống hiến của những con người vô danh, ít được công chúng quan tâm, chú ý tới. Với họ, dù vai diễn nhỏ đến đâu cũng góp phần tạo nên một bộ phim hoàn chĩnh. Cũng giống như trong cuộc sống, mỗi người đều có vai trò và giá trị nhất định trong xã hội.' 
SET	@CHAYTRONQUABIENGIOI = N'Xem phim Chạy Trốn Qua Biên Giới HD Vietsub - Rum Runners 2020'
SET	@DOIBONGCUATREMOCOI = N' Những đứa trẻ bị đối xử một cách đầy kỳ thị bởi giám đốc xưởng in Frank Wynn ( Wayne Knight ), người thường xuyên đánh đập các cậu bé và chế giễu mong muốn của Russell là bắt đầu một chương trình bóng đá.Chưa ai từng chơi trò chơi này trước đây, ngoài huấn luyện viên Rusty với sự giúp đỡ của bác sĩ tình nguyện Doc Hall ( Martin Sheen), đã tập hợp các chàng trai lại, đáng chú ý nhất là cư dân mới nóng tính Hardy Brown (Jake Austin Brown) đã dạy họ những điều cơ bản.Sau đó họ bắt đầu tham gia vào các đội khác của trường, tất cả đều giàu kinh nghiệm hơn, gồm cả đội của những kẻ thô lỗ như huấn luyện viên Luther ( Lane Garrison ).'
SET	@XEDAYHOA  = N'Nội dung xoay quanh 1 kẻ giết người có bề ngoài ngụy trang rất hoàng hảo, nhỏ nhẹ ngọt ngào khiến cho ai cũng tin tưởng, quý mến. Mời các bạn cùng đón xem Xe Đẩy Hoa - Petal Pushers.'
SET	@THEHOOTOWL  = N'Một nhóm bạn chiến đấu để sinh tồn khi họ làm phiền những cư dân loạn trí của nơi được cho là bất động sản bị bỏ hoang nằm sâu trong rừng ở Đông Texas.'
SET	@VOTOILAGANGSTER  = N'Eun-jin là một huyền thoại sống trong những băng đảng thống trị thế giới ngầm do nam giới làm trung tâm và thương hiệu là hình xâm một đôi cánh. Một ngày, Eun-jin tìm thấy em gái của mình người mà cô đã được tách ra tại một trại trẻ mồ côi khi cả hai còn nhỏ, và em gái của Eun-jin trước khi chết muốn được thấy Eun-jin kết hôn…'
SET	@CHUNGQUYPHUCMA  = N' Tuyết Yêu Ma Linh – Zhongkui: Snow Girl And The Dark Crystal: Thành Hỗ Đô – một thành trấn biên giới phía Tây của Đường triều. Chung Quỳ – dưới sự chỉ bảo của Trương đạo tiên- đã trở thành trảm yêu sỹ, trấn thủ Hỗ Đô. Để bảo vệ bách tính khỏi sự xâm hại của yêu ma, Chung Quỳ đã thâm nhập vào ma giới, ăn trộm bảo hạp tích tụ năng lượng yêu ma, nhằm mục đích tận dụng cơ hội ngàn năm có một tiêu diệt ma giới, mang lại hòa bình vĩnh viễn cho nhân gian'
SET	@NHIEPANNUONG  = N'Câu chuyện của Nhiếp Ẩn Nương diễn ra vào thời điểm Trung Quốc còn rối ren về mặt chính trị, trong mỗi gia đình còn tồn tại những ghen tuông, tranh chấp, nhỏ mọn. Bộ phim do bậc thầy đạo diễn Hầu Hiếu Hiền lần đầu phụ trách, kể về cuộc đời của một cô gái thích khách Nhiếp Ẩn Nương (Thư Kỳ) với sứ mạng khai trừ những kẻ có âm mưu phản loạn, đe dọa triều chính nhà Đường.'

SET	@NGUOIBANNGOAIHANHTINH = N'Cừu Shaun u0026 nhóm bạn đã trở lại! Trong hành trình lần này, họ sẽ tìm cách giúp Lula – cô bé ngoài hành tinh đáng yêu trở về nhà.' 
SET	@HUYENTHOAIXUOZ  = N'Sau chuyến phiêu lưu đầu điên tại xứ Oz, Dorothy trở về quê nhà Kansas nhưng cô bé nhanh chóng tìm đường trở lại xứ Oz khi biết tin bạn bè của cô và toàn bộ xứ sở thần tiên này đang bị đe dọa. Cùng những người bạn cũ và mới, Dorothy phải chiến đấu chống lại Jester, kẻ muốn kiểm soát xứ Oz và biến toàn bộ cư dân thành con rối.'
SET	@HAITACTIEN  = N'Xem phim Tinker Bell Và Hải Tặc Tiên HD Thuyết Minh - Tinker Bell and The Pirate Fairy 2014 Tinker Bell và hải tặc tiên -2014, Tinker Bell and the pirate fairy'
SET	@COTIENGIUPICH  = N'Tinker Bell được sinh ra từ nụ cười đầu tiên của đứa trẻ sơ sinh và được ngọn gió mang tới Pixie Hollow (một hòn đảo ở Never Land). Tại đây cô gặp những nàng tiên nhỏ khác và biết rằng năng lực của mình là để phục vụ việc hàn gắn mọi thứ – một thiên thần sửa chữa mọi thứ. Các tiên thợ khác đã giúp nhân viên mới học việc và Tinker Bell đã học được nghề, cô có thể …'
SET	@TOMANDJERRY = N'Đã đến lúc đuổi theo tinh thần ngày lễ đó với Tom và Jerry! Với phép thuật trong không khí, Jerry và cháu trai của mình, Tuffy, tạo ra một con chuột tuyết sống lại một cách thần kỳ! Để giữ cho người bạn mới của họ, chú chuột tuyết Larry không bị tan chảy, Tuffy và Jerry phải chạy đua với anh ta đến Ngôi làng của Người tuyết trong truyền thuyết. Để theo đuổi nóng bỏng, Tom và Tiến sĩ Doublevay quỷ quyệt có kế hoạch riêng cho ma thuật của Larry.'
SET	@LINHCUUHOA  = N'Chuông báo động đã vang lên và phi hành đoàn Pontypandy ra đi để giải cứu bạn bè của họ và những người khác đang gặp khó khăn. Từ tia lửa động cơ và pháo hoa đến cứu hộ dưới nước và hơn thế nữa, bạn sẽ không muốn bỏ lỡ những cuộc phiêu lưu này với anh hùng yêu thích của mình, Fireman Sam!'
SET	@COTHETOIDAUROI  = N'Tình yêu, bí ẩn và phiêu lưu cùng đan xen trong bộ phim hoạt hình hấp dẫn khi chàng trai trẻ rơi vào lưới tình và bàn tay bị cắt rời lặn lội khắp Paris để tìm chủ nhân.'
SET	@DACVUKHONGGIAN  = N'Sau các đợt tấn công không dứt của Angel, NERV quyết định tiếp nhận thêm hai phi công mới đến hỗ trợ cho chiến dịch là Asuka Langley Shikinami, một cô bé mạnh mẽ đầy cá tính, và Makinami Mari Illustrous, một nữ phi công bí ẩn từng lập chiến công tiêu diệt hài cốt tái sinh của Angel thứ ba, Shamshel. Cùng với sự hỗ trợ của Asuka, công cuộc chống chọi các Angel trở nên nhẹ nhàng hơn và Ikari Shinji cũng đã bắt đầu quen dần với cuộc sống và mở lòng với mọi người. Để rồi một biến cố kinh hoàng xảy đến…'
 
SET	@LINHDUYEN  = N'Hùng tìm cách bắt chuyện và rất nhanh chóng làm quen với Thư, điều này khiến vợ của anh, Hương rất khó chịu, bỗng nhiên một ngày ba người bạn tìm được một hình nhân tại lớp học của mình và từ đó hàng loạt những câu chuyện ma quái xảy ra. Liệu hình nhân ấy đang ẩn chứa bí mật to lớn gì và tại sau nó lại được giấy tại nơi nhiều người ra vào như thế? Giữa mùa phim vào đầu năm 2017 với khá nhiều phim thuộc dòng phim kinh dị được ra mắt, Linh Duyên vẫn là bộ phim được khán giả mong đợi, qua đoạn trailer đầy hồi hộp và kịch tính.' 
SET	@7NGAYYEU  = N'‘Nếu mỗi ngày, bạn phải thức dậy trong cơ thể của một người khác và không thể biết được rằng mình sẽ là ai vào ngày mai, bạn sẽ chấp nhận được điều đó không? Và bạn sẽ phải thuyết phục người thân yêu của bạn rằng đó chính là bạn, mặc dù chẳng phải là bạn một chút nào?’. Đó chính là lời mở đầu cho bộ phim 7 Ngày Yêu, khi một người đàn ông mỗi lúc thức dậy sẽ xuất hiện trong một cơ thể khác. Xoay quanh những rắc rối của chàng trai trong hành trình thuyết phục bạn gái của mình rằng đó thực sự là anh ta, ‘7 Ngày Yêu’ sẽ là thước phim tình cảm hài ý nghĩa cho những ai đã, đang và sắp có tình yêu của riêng mình.'
SET	@NORATH  = N'Một câu chuyện tình yêu sử thi của một cô gái du hành từ thời hiện tại đến vương quốc thần thoại trong quá khứ và gặp một chàng trai trẻ quyến rũ, làm chủ điệu nhảy truyền thống.'
SET	@LINHHONLACLOI = N'Câu chuyện về những kẻ thua cuộc trong cuộc sống, những người luôn muốn thay đổi. Jones di cư từ London đến Bilbao để tìm kiếm sự yên tĩnh, muốn quên hiện tại. Ana, Argentina trốn thoát với chồng muốn tìm lại trong bầu không khí yên bình, không có tiếng động quen thuộc.' 
SET	@LOIMOIGOILUCNUADEM  = N'Sâu vào giấc ngủ vào lúc nửa đêm, thiếu nữ mới lớn thường xuyên bị quấy rối bởi một thế lực bí ẩn mang theo lời mời gọi hấp dẫn vọng lên từ tầng hầm, khiến cô không thể cưỡng lại được. Cơn ác mộng chỉ mới bắt đầu…'
SET	@NGUOICOITRAU  = N'Cô gái nổi loạn người Mỹ gốc Thái được chuyển đến sống cùng người thân ở vùng nông thôn Thái Lan, cô đối đầu với dân làng khi kết bạn với chàng trai câm và giúp anh chàng tham gia cuộc thi đua trâu hàng năm.'
SET	@OANHONTRONGMUA  = N'Phim xoay quanh câu chuyện về cái chết bí ẩn và đầy oan khuất của cô gái tên Som. Bước ra từ cửa hàng tiện lợi vào lúc 1 giờ sáng, Som phát hiện rằng mình đã chết không lý do. Gab – cậu thiếu gia nhà giàu bỏ nhà ra đi và đang làm việc tại cửa hàng tiện lợi vô tình trở thành người duy nhất nhìn thấy Som. Liệu có uẩn khúc gì với cái chết của Som? Tại sao định mệnh lại sắp đặt Gab là người duy nhất biết Som tồn tại và những màn trả thù chết chóc trong phim sẽ thế nào?…'
SET	@KYNGHITAIUONG  = N'Thongsook có cảm tình với cô nàng Nam xinh đẹp. Tuy vậy, cậu lại thường hay bị đám bạn cùng nhóm của Nam trêu chọc và bắt nạt. Khi nhóm bạn trẻ tới một hòn đảo bị bỏ hoang để nghỉ ngơi cuối tuần, những người bạn của Nam đã nhốt Thongsook lại trong một ngôi miếu thờ cổ. Và đó chính là khởi điểm cho những tai ương kinh hoàng sắp sửa giáng xuống cả hội…'




SET IDENTITY_INSERT [FILM] ON
INSERT INTO [FILM]
([_FILM_WEB_URL],[_ID],[_FILM_NAME],[_FILM_COUNTRY],[_FILM_YEAR_RELEASE],[_FILM_LANGUAGE],[_FILM_TYPE],[_FILM_RATE],[_FILM_ACTOR],[_FILM_URL],[_FILM_IMAGE_URL],[_FILM_CONTENT])
VALUES
('https://www.youtube.com/watch?v=tPO_ZJgbDdU',1,N'QUẢ BÁO',N'Âu - Mỹ',2012,N'Phụ đề Việt',N'Hành động',6,'Aaron Pedersen, Dominic Purcell, Ray Liotta','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\badkarma.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\BadKarma.jpg',@QUABAO),
('https://www.youtube.com/watch?v=iPC-zPpm2Kg&t=6s',2,N'NỘI CHIẾN SHIRAZ',N'Âu - Mỹ',2015,N'Thuyết minh',N'Hành động',8,'Adrien Brody, Salma Hayek, Shohreh Aghdashloo','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\shiraz.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\NoiChienShiraz.jpg',@NOICHIENSHIRAZ),
('https://www.youtube.com/watch?v=hOnUTeNi-hQ&t=10s',3,N'ÔNG TRÙM PABLO',N'Âu - Mỹ',2017,N'Thuyết minh',N'Hành động',8,'Javier Bardem, Penélope Cruz, Peter Sarsgaard','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\pablo.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\OngTrumPablo.jpg',@ONGTRUMPUBLO),
('https://www.youtube.com/watch?v=5MqKvIOGmE8&t=2s',4,N'GIÁO ÁN HIỂM NGUY',N'Ba Lan',2022,N'Phụ đề Việt',N'Hành động',7,'Daniel Namiotko, Jan Wieczorkowski, Marcin Bosak','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\planLekcji.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\GiaoAnHiemNgu.jpg',@GIAOANHIEMNGUY),
('https://www.youtube.com/watch?v=UH7zOEj-WGw',5,N'CẬU VÀNG',N'Việt Nam',2021,N'Phụ đề Việt',N'Hành động',6,N'Chiến Thắng, Chiều Xuân, Hữu Châu','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\CauVang.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\CauVang.jpg',@CAUVANG),
('https://www.youtube.com/watch?v=hx9APx9-vH8&t=23s',6,N'THỎA THUẬN TRIỆU ĐÔ',N'Âu - Mỹ',2017,N'Phụ đề Việt',N'Hành động',7,'Andrey Ivchenko, Chelsea Gilson, Courtney Gains','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\trieudo.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\PhiVuTrieuDo.jpg',@THOATHUANTRIEUDO),
('https://www.youtube.com/watch?v=MB03jLdV3bY',7,N'HUYỀN THOẠI KUNGFU',N'Trung Quốc',2018,N'Phụ đề Việt',N'Hành động',7,N'An Chí Kiệt, Đỗ Vũ Hàng, Triệu Văn Trác','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\huyenthoaikungfu.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\HuyenThoaiKungFu.jpg',@HUYENTHOAIKUNGFU),
('',8,N'CƠ HỘI ĐƯỢC SỐNG',N'Âu - Mỹ',2016,N'Phụ đề Việt',N'Hành động',8,'Marvin Young','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\cohoiduocsong.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\CoHoiDuocSong.jpg',@COHOIDUOCSONG),

('',9,N'TÔI LÀ NGƯỜI QUA ĐƯỜNG',N'Trung Quốc',2015,N'Phụ đề Việt',N'Tình cảm',8,N'Mạc Văn Khoa, Trấn Thành','https://sphimmoi.net/xem-phim/toi-la-nguoi-qua-duong-tap-1-server-1/','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\ToiLaNguoiQuaDuong.jpg',@TOILANGUOIQUADUONG),
('',10,N'CHẠY TRỐN QUA BIÊN GIỚI',N'Âu - Mỹ',2020,N'Phụ đề Việt',N'Tình cảm',9,'Hansiflick Moyes','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\rumrunners.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\ChayTronQuaBienGioi.jpg',@CHAYTRONQUABIENGIOI),
('',11,N'ĐỘI BÓNG CỦA TRẺ MỒ CÔI',N'Âu - Mỹ',2021,N'Phụ đề Việt',N'Tình cảm',8,'Luke Wilson, Vinessa Shaw, Wayne Knight','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\doibongtremocoi.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\DoiBongCuaTreMoCoi.jpg',@DOIBONGCUATREMOCOI),
('',12,N'XE ĐẨY HOA',N'Âu - Mỹ',2019,N'Phụ đề Việt',N'Tình cảm',7,'Bridey Elliott, Isidora Goreshter, Kaitlyn Black','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\xedayhoa.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\XeDayHoa.jpg',@XEDAYHOA),
('',13,N'THE HOOT OWL',N'Âu - Mỹ',2022,N'Phụ đề Việt',N'Tình cảm',6,'Augustine Frizzell, Carl Bailey, J.D. Brown','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\thehootowl.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\TheHootOwl.jpg',@THEHOOTOWL),
('',14,N'VỢ TÔI LÀ GANGSTER',N'Hàn Quốc',2020,N'Phụ đề Việt',N'Tình cảm',6,'Eun-Kyung Shin, Jae-mo Ahn','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\Votoilagangster.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\VoToiLaGangSter.jpg',@VOTOILAGANGSTER),
('',15,N'CHUNG QUỲ PHỤC MA: TUYẾT YÊU MA LINH',N'Trung Quốc',2015,N'Phụ đề Việt',N'Tình cảm',9,N'Lý Băng Băng, Trần Khôn, Triệu Văn Tuyên','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\chungquyphucma.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\ChungQuyPhucMa.jpg',@CHUNGQUYPHUCMA),
('',16,N'NHIẾP ẨN NƯƠNG',N'Đài Loan, Trung Quốc',2016,N'Phụ đề Việt',N'Tình cảm',7,'Chen Chang, Qi Shu, Satoshi Tsumabuki','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\nhiepannuong.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\NhiepAnNuong.jpg',@NHIEPANNUONG),

('',17,N'NGƯỜI BẠN NGOÀI HÀNH TINH',N'Quốc Gia Khác',2019,N'Phụ đề Việt',N'Hoạt hình',7,'John Sparkes, Justin Fletcher, Kate Harbour','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\nguoibanngoaihanhtinh.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\Farmageddon.jpg',@NGUOIBANNGOAIHANHTINH),
('',18,N'HUYỀN THOẠI XỨ OZ: DOROTHY TRỞ LẠI',N'Quốc Gia Khác',2014,N'Thuyết Minh',N'Hoạt hình',5,'Dan Aykroyd, Kelsey Grammer, Lea Michele','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\Oz.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\HuyenThoaiXuOZ.jpeg',@HUYENTHOAIXUOZ),
('',19,N'TINKER BELL VÀ HẢI TẶC TIÊN',N'Âu - Mỹ',2014,N'Thuyết Minh',N'Hoạt hình',9,'Christina Hendricks, Mae Whitman, Tom Hiddleston','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\TinkerBell_private.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\TinkerBell_HaitacTien.jpg',@HAITACTIEN),
('',20,N'TINKER BELL – CÔ TIÊN GIÚP ÍCH',N'Âu - Mỹ',2008,N'Thuyết Minh',N'Hoạt hình',8,'Kristin Chenoweth, Lucy Liu, Mae Whitman','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\Tinkerbell_Cotiengiupich.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\tinker-bell-CoTienGiupIch.jpg',@COTIENGIUPICH),
('',21,N'TOM AND JERRY SNOWMAN’S LAND',N'Âu - Mỹ',2022,N'Phụ đề Việt',N'Hoạt hình',9,'Doublevay, Larry','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\TomAndJerry.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\TomVaJerry_Snowman.jpg',@TOMANDJERRY),
('',22,N'LÍNH CỨU HỎA SAM SẴN SÀNG HÀNH ĐỘNG',N'Âu - Mỹ',2016,N'Phụ đề Việt',N'Hoạt hình',5,'Sam sameuoti, cassandro messi','https://sphimmoi.net/xem-phim/linh-cuu-hoa-sam-san-sang-hanh-dong-tap-1-server-1/','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\LinhCuuHoa.jpg',@LINHCUUHOA),
('',23,N'CƠ THỂ TÔI ĐÂU RỒI?',N'Đài Loan, Trung Quốc',2019,N'Phụ đề Việt',N'Hoạt hình',7,'Hakim Faris, Patrick dAssumçao, Victoire Du Bois','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\ILostMyBody.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\CoTheToiDauRoi.jpg',@COTHETOIDAUROI),
('',24,N'ĐẶC VỤ KHÔNG GIAN: KHÔNG LÙI BƯỚC',N'Nhật Bản',2009,N'Phụ đề Việt',N'Hoạt hình',6,'Kotono Mitsuishi, Maaya Sakamoto, Megumi Hayas','https://sphimmoi.net/xem-phim/dac-vu-khong-gian-khong-lui-buoc-tap-1-server-1/','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\KhongGian_KhongLuiBuoc.jpg',@DACVUKHONGGIAN),

('',25,N'LINH DUYÊN',N'Quốc Gia Khác',2016,N'Thuyết Minh',N'Tâm lí',5,'Dustin Nguyen, Trương Quỳnh Anh','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\linhduyen.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\LinhDuyen.jpg',@LINHDUYEN),
('',26,N'7 NGÀY YÊU',N'Thái Lan',2018,N'Phụ đề Việt',N'Tâm lí',6,'Ananda Everingham, Lawrence de Stefano, Mew Nittha Jiray','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\7ngayyeu.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\7NgayYeu.jpg',@7NGAYYEU),
('',27,N'NORAH',N'Thái Lan',2016,N'Thuyết Minh',N'Tâm lí',7,'Angelina Jade Fromento, Paisan Khunnu','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\Norah.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\Norah.jpg',@NORATH),
('',28,N'LINH HỒN LẠC LỐI',N'Âu - Mỹ',2016,N'Phụ đề Việt',N'Tâm lí',8,'Elbio Aparisi Nielsen, Marvin Jay Austi','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\LinhHonLacLoi.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\LinhHonLacLoi.jpg',@LINHHONLACLOI),
('',29,N'LỜI MỜI GỌI LÚC NỬA ĐÊM',N'Âu - Mỹ',2017,N'Phụ đề Việt',N'Tâm lí',9,'Alexz Johnson, Lauren McQueen, Shelagh McLeod','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\LoiMoiGoiLucNuaDem.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\LoiMoiGoiLucNuaDem.jpg',@LOIMOIGOILUCNUADEM),
('',30,N'NGƯỜI CỠI TRÂU',N'Âu - Mỹ',2015,N'Phụ đề Việt',N'Tâm lí',8,'Elbio Aparisi Nielsen, Marvin Jay Austi','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\Bufallo_rider.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\NguoiCuoiTrau.jpg',@NGUOICOITRAU),
('',31,N'OAN HỒN TRONG MƯA',N'Thái Lan',2016,N'Phụ đề Việt',N'Tâm lí',9,'Boom Kitkong, Sammy Cowell','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\OanHonTrongMua.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\OanHonTrongMua.jpg',@OANHONTRONGMUA),
('',32,N'KỲ NGHỈ TAI ƯƠNG',N'Âu - Mỹ',2016,N'Phụ đề Việt',N'Tâm lí',8,'Chinawut Indracusin','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\video\KyNghiTaiUong.mp4','P:\CS511\BTH\Movie\MovieWatch\MovieWatch\Image_Film\KyNghiTaiUong.jpg',@KYNGHITAIUONG)
SET IDENTITY_INSERT [FILM] OFF

SELECT * FROM [FILM]
where _film_type = N'Hoạt hình'

SELECT * FROM [FILM]
where [_FILM_NAME] like N'tinker bell'


SELECT * FROM FILM
WHERE _FILM_NAME = ''
