// NX 2027
// Journal created by xuxnb on Mon May 19 11:01:22 2025 中国标准时间

//
using System;
using NXOpen;

public class NXJournal
{
  public static void Main(string[] args)
  {
    NXOpen.Session theSession = NXOpen.Session.GetSession();
    NXOpen.Part workPart = theSession.Parts.Work;
    NXOpen.Part displayPart = theSession.Parts.Display;
    // ----------------------------------------------
    //   菜单：文件(F)->导入(M)->部件(P)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId1;
    markId1 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Import Part");
    
    NXOpen.PartImporter partImporter1;
    partImporter1 = workPart.ImportManager.CreatePartImporter();
    
    partImporter1.FileName = "\\\\APCSO-FS-VP01\\Public\\Engineer\\00 Manufacturing Engineering\\01 Product Transfer\\01 Knee\\07 Persona PS Femoral\\02_Changzhou Documents\\01_Drawing\\模板\\模板.prt";
    
    partImporter1.Scale = 1.0;
    
    partImporter1.CreateNamedGroup = true;
    
    partImporter1.ImportViews = false;
    
    partImporter1.ImportCamObjects = false;
    
    partImporter1.LayerOption = NXOpen.PartImporter.LayerOptionType.Work;
    
    partImporter1.DestinationCoordinateSystemSpecification = NXOpen.PartImporter.DestinationCoordinateSystemSpecificationType.Work;
    
    NXOpen.Matrix3x3 element1 = new NXOpen.Matrix3x3();
    element1.Xx = 1.0;
    element1.Xy = 0.0;
    element1.Xz = 0.0;
    element1.Yx = 0.0;
    element1.Yy = 1.0;
    element1.Yz = 0.0;
    element1.Zx = 0.0;
    element1.Zy = 0.0;
    element1.Zz = 1.0;
    NXOpen.NXMatrix nXMatrix1;
    nXMatrix1 = workPart.NXMatrices.Create(element1);
    
    partImporter1.DestinationCoordinateSystem = nXMatrix1;
    
    NXOpen.Point3d destinationPoint1 = new NXOpen.Point3d(0.0, 0.0, 0.0);
    partImporter1.DestinationPoint = destinationPoint1;
    
    NXOpen.Session.UndoMarkId markId2;
    markId2 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Import Part Commit");
    
    // ----------------------------------------------
    //   对话开始 更新事件列表
    // ----------------------------------------------
    NXOpen.NXObject nXObject1;
    nXObject1 = partImporter1.Commit();
    
    theSession.DeleteUndoMark(markId2, null);
    
    partImporter1.Destroy();
    
    NXOpen.Point3d scaleAboutPoint1 = new NXOpen.Point3d(-169.60212126696797, 112.79163076923058, 0.0);
    NXOpen.Point3d viewCenter1 = new NXOpen.Point3d(169.60212126696874, -112.79163076923103, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1, viewCenter1);
    
    NXOpen.Point3d scaleAboutPoint2 = new NXOpen.Point3d(-212.00265158371008, 140.98953846153825, 0.0);
    NXOpen.Point3d viewCenter2 = new NXOpen.Point3d(212.00265158371084, -140.98953846153876, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint2, viewCenter2);
    
    NXOpen.Point3d scaleAboutPoint3 = new NXOpen.Point3d(-264.3553846153842, 176.88485294117626, 0.0);
    NXOpen.Point3d viewCenter3 = new NXOpen.Point3d(264.35538461538493, -176.88485294117675, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint3, viewCenter3);
    
    NXOpen.Point3d scaleAboutPoint4 = new NXOpen.Point3d(-330.44423076923033, 221.10606617647051, 0.0);
    NXOpen.Point3d viewCenter4 = new NXOpen.Point3d(330.4442307692313, -221.10606617647093, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint4, viewCenter4);
    
    NXOpen.Point3d scaleAboutPoint5 = new NXOpen.Point3d(-453.55090497737518, -111.36294541855234, 0.0);
    NXOpen.Point3d viewCenter5 = new NXOpen.Point3d(453.55090497737621, 111.36294541855183, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint5, viewCenter5);
    
    NXOpen.Point3d scaleAboutPoint6 = new NXOpen.Point3d(-367.70019796380052, -88.280444004525151, 0.0);
    NXOpen.Point3d viewCenter6 = new NXOpen.Point3d(367.70019796380143, 88.280444004524682, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint6, viewCenter6);
    
    NXOpen.Point3d origin1 = new NXOpen.Point3d(466.29526762891828, 320.5556367513783, 0.0);
    workPart.Views.WorkView.SetOrigin(origin1);
    
    NXOpen.Point3d origin2 = new NXOpen.Point3d(466.29526762891828, 320.5556367513783, 0.0);
    workPart.Views.WorkView.SetOrigin(origin2);
    
    NXOpen.Point3d origin3 = new NXOpen.Point3d(578.387134144745, 322.49942634413867, 0.0);
    workPart.Views.WorkView.SetOrigin(origin3);
    
    NXOpen.Point3d origin4 = new NXOpen.Point3d(578.387134144745, 322.49942634413867, 0.0);
    workPart.Views.WorkView.SetOrigin(origin4);
    
    NXOpen.Point3d scaleAboutPoint7 = new NXOpen.Point3d(227.4233823529419, 189.84345022624427, 0.0);
    NXOpen.Point3d viewCenter7 = new NXOpen.Point3d(-227.42338235294091, -189.84345022624461, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint7, viewCenter7);
    
    NXOpen.Point3d scaleAboutPoint8 = new NXOpen.Point3d(181.9387058823535, 151.87476018099528, 0.0);
    NXOpen.Point3d viewCenter8 = new NXOpen.Point3d(-181.93870588235262, -151.87476018099574, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint8, viewCenter8);
    
    NXOpen.Point3d scaleAboutPoint9 = new NXOpen.Point3d(145.55096470588308, 121.49980814479625, 0.0);
    NXOpen.Point3d viewCenter9 = new NXOpen.Point3d(-145.55096470588194, -121.4998081447967, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint9, viewCenter9);
    
    NXOpen.Point3d scaleAboutPoint10 = new NXOpen.Point3d(116.4407717647065, 97.19984651583691, 0.0);
    NXOpen.Point3d viewCenter10 = new NXOpen.Point3d(-116.44077176470547, -97.199846515837379, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint10, viewCenter10);
    
    NXOpen.Point3d scaleAboutPoint11 = new NXOpen.Point3d(93.152617411765348, 77.759877212669522, 0.0);
    NXOpen.Point3d viewCenter11 = new NXOpen.Point3d(-93.152617411764254, -77.759877212669963, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint11, viewCenter11);
    
    NXOpen.Point3d scaleAboutPoint12 = new NXOpen.Point3d(74.522093929412435, 62.207901770135614, 0.0);
    NXOpen.Point3d viewCenter12 = new NXOpen.Point3d(-74.522093929411298, -62.207901770136004, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint12, viewCenter12);
    
    NXOpen.Point3d scaleAboutPoint13 = new NXOpen.Point3d(59.6176751435301, 49.766321416108447, 0.0);
    NXOpen.Point3d viewCenter13 = new NXOpen.Point3d(-59.617675143528949, -49.766321416108902, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint13, viewCenter13);
    
    NXOpen.Point3d scaleAboutPoint14 = new NXOpen.Point3d(47.694140114824172, 39.813057132886726, 0.0);
    NXOpen.Point3d viewCenter14 = new NXOpen.Point3d(-47.694140114823043, -39.813057132887124, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint14, viewCenter14);
    
    NXOpen.Point3d scaleAboutPoint15 = new NXOpen.Point3d(38.590130463276644, 31.633036520600744, 0.0);
    NXOpen.Point3d viewCenter15 = new NXOpen.Point3d(-38.590130463275514, -31.633036520601141, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint15, viewCenter15);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId3;
    markId3 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId4;
    markId4 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects1 = new NXOpen.TaggedObject[1];
    NXOpen.Annotations.Note note1 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-651923"));
    objects1[0] = note1;
    int nErrs1;
    nErrs1 = theSession.UpdateManager.AddObjectsToDeleteList(objects1);
    
    NXOpen.Session.UndoMarkId id1;
    id1 = theSession.NewestVisibleUndoMark;
    
    int nErrs2;
    nErrs2 = theSession.UpdateManager.DoUpdate(id1);
    
    theSession.DeleteUndoMark(markId3, null);
    
    NXOpen.Point3d scaleAboutPoint16 = new NXOpen.Point3d(37.133488919029062, 11.21831398256341, 0.0);
    NXOpen.Point3d viewCenter16 = new NXOpen.Point3d(-37.133488919027933, -11.218313982563869, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint16, viewCenter16);
    
    NXOpen.Point3d scaleAboutPoint17 = new NXOpen.Point3d(46.96038411305765, 14.131597071058643, 0.0);
    NXOpen.Point3d viewCenter17 = new NXOpen.Point3d(-46.960384113056513, -14.131597071059041, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint17, viewCenter17);
    
    NXOpen.Point3d scaleAboutPoint18 = new NXOpen.Point3d(59.651645328797031, 17.936257820959074, 0.0);
    NXOpen.Point3d viewCenter18 = new NXOpen.Point3d(-59.651645328795901, -17.936257820959529, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint18, viewCenter18);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId5;
    markId5 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId6;
    markId6 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects2 = new NXOpen.TaggedObject[1];
    NXOpen.Annotations.Note note2 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-641777"));
    objects2[0] = note2;
    int nErrs3;
    nErrs3 = theSession.UpdateManager.AddObjectsToDeleteList(objects2);
    
    NXOpen.Session.UndoMarkId id2;
    id2 = theSession.NewestVisibleUndoMark;
    
    int nErrs4;
    nErrs4 = theSession.UpdateManager.DoUpdate(id2);
    
    theSession.DeleteUndoMark(markId5, null);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId7;
    markId7 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId8;
    markId8 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects3 = new NXOpen.TaggedObject[1];
    NXOpen.Annotations.Note note3 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-294891"));
    objects3[0] = note3;
    int nErrs5;
    nErrs5 = theSession.UpdateManager.AddObjectsToDeleteList(objects3);
    
    NXOpen.Session.UndoMarkId id3;
    id3 = theSession.NewestVisibleUndoMark;
    
    int nErrs6;
    nErrs6 = theSession.UpdateManager.DoUpdate(id3);
    
    theSession.DeleteUndoMark(markId7, null);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId9;
    markId9 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId10;
    markId10 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects4 = new NXOpen.TaggedObject[1];
    NXOpen.Line line1 = ((NXOpen.Line)workPart.Lines.FindObject("HANDLE R-293882"));
    objects4[0] = line1;
    int nErrs7;
    nErrs7 = theSession.UpdateManager.AddObjectsToDeleteList(objects4);
    
    NXOpen.Session.UndoMarkId id4;
    id4 = theSession.NewestVisibleUndoMark;
    
    int nErrs8;
    nErrs8 = theSession.UpdateManager.DoUpdate(id4);
    
    theSession.DeleteUndoMark(markId9, null);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId11;
    markId11 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId12;
    markId12 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects5 = new NXOpen.TaggedObject[1];
    NXOpen.Line line2 = ((NXOpen.Line)workPart.Lines.FindObject("HANDLE R-293894"));
    objects5[0] = line2;
    int nErrs9;
    nErrs9 = theSession.UpdateManager.AddObjectsToDeleteList(objects5);
    
    NXOpen.Session.UndoMarkId id5;
    id5 = theSession.NewestVisibleUndoMark;
    
    int nErrs10;
    nErrs10 = theSession.UpdateManager.DoUpdate(id5);
    
    theSession.DeleteUndoMark(markId11, null);
    
    NXOpen.Point3d scaleAboutPoint19 = new NXOpen.Point3d(85.604866872760894, 32.95107970895917, 0.0);
    NXOpen.Point3d viewCenter19 = new NXOpen.Point3d(-85.604866872759729, -32.951079708959512, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint19, viewCenter19);
    
    NXOpen.Point3d scaleAboutPoint20 = new NXOpen.Point3d(107.00608359095098, 41.188849636198938, 0.0);
    NXOpen.Point3d viewCenter20 = new NXOpen.Point3d(-107.00608359094984, -41.188849636199393, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint20, viewCenter20);
    
    NXOpen.Point3d scaleAboutPoint21 = new NXOpen.Point3d(133.75760448868851, 51.486062045248659, 0.0);
    NXOpen.Point3d viewCenter21 = new NXOpen.Point3d(-133.75760448868749, -51.486062045249234, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint21, viewCenter21);
    
    NXOpen.Point3d scaleAboutPoint22 = new NXOpen.Point3d(167.19700561086037, 64.357577556560855, 0.0);
    NXOpen.Point3d viewCenter22 = new NXOpen.Point3d(-167.19700561085949, -64.357577556561438, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint22, viewCenter22);
    
    NXOpen.Point3d scaleAboutPoint23 = new NXOpen.Point3d(208.99625701357544, 81.276322171945537, 0.0);
    NXOpen.Point3d viewCenter23 = new NXOpen.Point3d(-208.99625701357439, -81.276322171946063, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint23, viewCenter23);
    
    NXOpen.Point3d scaleAboutPoint24 = new NXOpen.Point3d(257.61691402715002, 106.26049773755638, 0.0);
    NXOpen.Point3d viewCenter24 = new NXOpen.Point3d(-257.61691402714916, -106.2604977375569, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint24, viewCenter24);
    
    NXOpen.Point3d scaleAboutPoint25 = new NXOpen.Point3d(224.18373303167488, 101.7249886877826, 0.0);
    NXOpen.Point3d viewCenter25 = new NXOpen.Point3d(-224.18373303167402, -101.7249886877831, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint25, viewCenter25);
    
    NXOpen.Point3d scaleAboutPoint26 = new NXOpen.Point3d(279.41975395927636, 128.77606052036185, 0.0);
    NXOpen.Point3d viewCenter26 = new NXOpen.Point3d(-279.41975395927568, -128.77606052036231, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint26, viewCenter26);
    
    NXOpen.Point3d scaleAboutPoint27 = new NXOpen.Point3d(349.2746924490956, 161.98246606334823, 0.0);
    NXOpen.Point3d viewCenter27 = new NXOpen.Point3d(-349.27469244909491, -161.98246606334865, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint27, viewCenter27);
    
    NXOpen.Point3d origin5 = new NXOpen.Point3d(376.0222722917577, 158.21320632169221, 0.0);
    workPart.Views.WorkView.SetOrigin(origin5);
    
    NXOpen.Point3d origin6 = new NXOpen.Point3d(376.0222722917577, 158.21320632169221, 0.0);
    workPart.Views.WorkView.SetOrigin(origin6);
    
    NXOpen.Point3d scaleAboutPoint28 = new NXOpen.Point3d(449.24824572256858, -37.964640483597499, 0.0);
    NXOpen.Point3d viewCenter28 = new NXOpen.Point3d(-449.24824572256773, 37.96464048359708, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint28, viewCenter28);
    
    NXOpen.Point3d scaleAboutPoint29 = new NXOpen.Point3d(361.42337740384716, -27.334541148190276, 0.0);
    NXOpen.Point3d viewCenter29 = new NXOpen.Point3d(-361.42337740384619, 27.334541148189938, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint29, viewCenter29);
    
    NXOpen.Point3d scaleAboutPoint30 = new NXOpen.Point3d(289.94861425339445, -21.867632918552285, 0.0);
    NXOpen.Point3d viewCenter30 = new NXOpen.Point3d(-289.94861425339354, 21.867632918551944, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint30, viewCenter30);
    
    NXOpen.Point3d scaleAboutPoint31 = new NXOpen.Point3d(233.90268099547578, -15.550316742081618, 0.0);
    NXOpen.Point3d viewCenter31 = new NXOpen.Point3d(-233.90268099547484, 15.550316742081295, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint31, viewCenter31);
    
    NXOpen.Point3d scaleAboutPoint32 = new NXOpen.Point3d(188.67717647058888, -11.403565610859923, 0.0);
    NXOpen.Point3d viewCenter32 = new NXOpen.Point3d(-188.67717647058797, 11.403565610859577, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint32, viewCenter32);
    
    NXOpen.Point3d scaleAboutPoint33 = new NXOpen.Point3d(152.60044162895977, -8.2935022624436368, 0.0);
    NXOpen.Point3d viewCenter33 = new NXOpen.Point3d(-152.60044162895906, 8.2935022624432921, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint33, viewCenter33);
    
    NXOpen.Point3d scaleAboutPoint34 = new NXOpen.Point3d(62.698877104072935, 33.505749140271362, 0.0);
    NXOpen.Point3d viewCenter34 = new NXOpen.Point3d(-62.698877104072054, -33.505749140271718, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint34, viewCenter34);
    
    NXOpen.Point3d scaleAboutPoint35 = new NXOpen.Point3d(50.15910168325847, 26.804599312217029, 0.0);
    NXOpen.Point3d viewCenter35 = new NXOpen.Point3d(-50.159101683257568, -26.804599312217427, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint35, viewCenter35);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId13;
    markId13 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId14;
    markId14 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects6 = new NXOpen.TaggedObject[1];
    NXOpen.Annotations.Note note4 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-1398"));
    objects6[0] = note4;
    int nErrs11;
    nErrs11 = theSession.UpdateManager.AddObjectsToDeleteList(objects6);
    
    NXOpen.Session.UndoMarkId id6;
    id6 = theSession.NewestVisibleUndoMark;
    
    int nErrs12;
    nErrs12 = theSession.UpdateManager.DoUpdate(id6);
    
    theSession.DeleteUndoMark(markId13, null);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId15;
    markId15 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId16;
    markId16 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects7 = new NXOpen.TaggedObject[1];
    NXOpen.Line line3 = ((NXOpen.Line)workPart.Lines.FindObject("HANDLE R-1557"));
    objects7[0] = line3;
    int nErrs13;
    nErrs13 = theSession.UpdateManager.AddObjectsToDeleteList(objects7);
    
    NXOpen.Session.UndoMarkId id7;
    id7 = theSession.NewestVisibleUndoMark;
    
    int nErrs14;
    nErrs14 = theSession.UpdateManager.DoUpdate(id7);
    
    theSession.DeleteUndoMark(markId15, null);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId17;
    markId17 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId18;
    markId18 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects8 = new NXOpen.TaggedObject[1];
    NXOpen.Line line4 = ((NXOpen.Line)workPart.Lines.FindObject("HANDLE R-1321"));
    objects8[0] = line4;
    int nErrs15;
    nErrs15 = theSession.UpdateManager.AddObjectsToDeleteList(objects8);
    
    NXOpen.Session.UndoMarkId id8;
    id8 = theSession.NewestVisibleUndoMark;
    
    int nErrs16;
    nErrs16 = theSession.UpdateManager.DoUpdate(id8);
    
    theSession.DeleteUndoMark(markId17, null);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId19;
    markId19 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId20;
    markId20 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects9 = new NXOpen.TaggedObject[1];
    NXOpen.Line line5 = ((NXOpen.Line)workPart.Lines.FindObject("HANDLE R-1422"));
    objects9[0] = line5;
    int nErrs17;
    nErrs17 = theSession.UpdateManager.AddObjectsToDeleteList(objects9);
    
    NXOpen.Session.UndoMarkId id9;
    id9 = theSession.NewestVisibleUndoMark;
    
    int nErrs18;
    nErrs18 = theSession.UpdateManager.DoUpdate(id9);
    
    theSession.DeleteUndoMark(markId19, null);
    
    NXOpen.Point3d scaleAboutPoint36 = new NXOpen.Point3d(29.936225766516348, 32.271676003619802, 0.0);
    NXOpen.Point3d viewCenter36 = new NXOpen.Point3d(-29.936225766515463, -32.271676003620115, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint36, viewCenter36);
    
    NXOpen.Point3d scaleAboutPoint37 = new NXOpen.Point3d(37.951066352941723, 40.339595004524796, 0.0);
    NXOpen.Point3d viewCenter37 = new NXOpen.Point3d(-37.951066352940821, -40.339595004525108, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint37, viewCenter37);
    
    NXOpen.Point3d scaleAboutPoint38 = new NXOpen.Point3d(159.56698352941257, -59.381476199095346, 0.0);
    NXOpen.Point3d viewCenter38 = new NXOpen.Point3d(-159.5669835294116, 59.38147619909499, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint38, viewCenter38);
    
    NXOpen.Point3d scaleAboutPoint39 = new NXOpen.Point3d(187.43315113122259, -53.078414479638298, 0.0);
    NXOpen.Point3d viewCenter39 = new NXOpen.Point3d(-187.43315113122171, 53.078414479637956, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint39, viewCenter39);
    
    NXOpen.Point3d scaleAboutPoint40 = new NXOpen.Point3d(235.32812669683361, -66.866361990950537, 0.0);
    NXOpen.Point3d viewCenter40 = new NXOpen.Point3d(-235.32812669683267, 66.866361990950196, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint40, viewCenter40);
    
    NXOpen.Point3d scaleAboutPoint41 = new NXOpen.Point3d(294.80808823529526, -83.582952488688122, 0.0);
    NXOpen.Point3d viewCenter41 = new NXOpen.Point3d(-294.80808823529418, 83.582952488687795, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint41, viewCenter41);
    
    NXOpen.Point3d origin7 = new NXOpen.Point3d(496.68815258581816, 346.44035014647261, 0.0);
    workPart.Views.WorkView.SetOrigin(origin7);
    
    NXOpen.Point3d origin8 = new NXOpen.Point3d(496.68815258581816, 346.44035014647261, 0.0);
    workPart.Views.WorkView.SetOrigin(origin8);
    
    NXOpen.Session.UndoMarkId markId21;
    markId21 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Drawings.DraftingDrawingSheet draftingDrawingSheet1 = ((NXOpen.Drawings.DraftingDrawingSheet)workPart.DraftingDrawingSheets.FindObject("SHEET1"));
    NXOpen.Drawings.DraftingDrawingSheetBuilder draftingDrawingSheetBuilder1;
    draftingDrawingSheetBuilder1 = workPart.DraftingDrawingSheets.CreateDraftingDrawingSheetBuilder(draftingDrawingSheet1);
    
    draftingDrawingSheetBuilder1.MetricSheetTemplateLocation = "C:\\Siemens\\NX2007\\localization\\prc\\simpl_chinese\\startup\\A0++-noviews-template.prt";
    
    draftingDrawingSheetBuilder1.EnglishSheetTemplateLocation = "";
    
    draftingDrawingSheetBuilder1.Height = 558.79999999999995;
    
    draftingDrawingSheetBuilder1.Length = 863.60000000000002;
    
    draftingDrawingSheetBuilder1.StandardMetricScale = NXOpen.Drawings.DrawingSheetBuilder.SheetStandardMetricScale.S11;
    
    draftingDrawingSheetBuilder1.StandardEnglishScale = NXOpen.Drawings.DrawingSheetBuilder.SheetStandardEnglishScale.S11;
    
    draftingDrawingSheetBuilder1.ScaleNumerator = 1.0;
    
    draftingDrawingSheetBuilder1.ScaleDenominator = 1.0;
    
    draftingDrawingSheetBuilder1.Units = NXOpen.Drawings.DrawingSheetBuilder.SheetUnits.Metric;
    
    draftingDrawingSheetBuilder1.ProjectionAngle = NXOpen.Drawings.DrawingSheetBuilder.SheetProjectionAngle.Third;
    
    draftingDrawingSheetBuilder1.Number = "1";
    
    draftingDrawingSheetBuilder1.SecondaryNumber = "";
    
    draftingDrawingSheetBuilder1.Revision = "A";
    
    theSession.SetUndoMarkName(markId21, "图纸页 对话框");
    
    draftingDrawingSheetBuilder1.MetricSheetTemplateLocation = "C:\\Siemens\\NX2007\\localization\\prc\\simpl_chinese\\startup\\A0++-noviews-template.prt";
    
    draftingDrawingSheetBuilder1.Height = 592.90999999999997;
    
    NXOpen.Session.UndoMarkId markId22;
    markId22 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "图纸页");
    
    draftingDrawingSheetBuilder1.Length = 839.53999999999996;
    
    theSession.DeleteUndoMark(markId22, null);
    
    NXOpen.Session.UndoMarkId markId23;
    markId23 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "图纸页");
    
    NXOpen.NXObject nXObject2;
    nXObject2 = draftingDrawingSheetBuilder1.Commit();
    
    theSession.DeleteUndoMark(markId23, null);
    
    theSession.SetUndoMarkName(markId21, "图纸页");
    
    draftingDrawingSheetBuilder1.Destroy();
    
    NXOpen.Point3d origin9 = new NXOpen.Point3d(575.82807041855244, 330.82902432126741, 0.0);
    workPart.Views.WorkView.SetOrigin(origin9);
    
    NXOpen.Point3d origin10 = new NXOpen.Point3d(575.82807041855244, 330.82902432126741, 0.0);
    workPart.Views.WorkView.SetOrigin(origin10);
    
    NXOpen.Point3d scaleAboutPoint42 = new NXOpen.Point3d(191.11957522624439, 173.93256306561088, 0.0);
    NXOpen.Point3d viewCenter42 = new NXOpen.Point3d(-191.11957522624439, -173.93256306561088, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint42, viewCenter42);
    
    NXOpen.Point3d scaleAboutPoint43 = new NXOpen.Point3d(152.89566018099541, 139.14605045248868, 0.0);
    NXOpen.Point3d viewCenter43 = new NXOpen.Point3d(-152.89566018099558, -139.14605045248868, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint43, viewCenter43);
    
    NXOpen.Point3d scaleAboutPoint44 = new NXOpen.Point3d(122.31652814479631, 111.31684036199093, 0.0);
    NXOpen.Point3d viewCenter44 = new NXOpen.Point3d(-122.31652814479652, -111.31684036199093, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint44, viewCenter44);
    
    NXOpen.Point3d scaleAboutPoint45 = new NXOpen.Point3d(97.853222515836762, 89.405462298642462, 0.0);
    NXOpen.Point3d viewCenter45 = new NXOpen.Point3d(-97.853222515837288, -89.405462298642462, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint45, viewCenter45);
    
    NXOpen.Point3d scaleAboutPoint46 = new NXOpen.Point3d(78.282578012669418, 71.524369838914055, 0.0);
    NXOpen.Point3d viewCenter46 = new NXOpen.Point3d(-78.282578012669887, -71.524369838913884, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint46, viewCenter46);
    
    NXOpen.Point3d scaleAboutPoint47 = new NXOpen.Point3d(63.527156833302932, 23.42845500235299, 0.0);
    NXOpen.Point3d viewCenter47 = new NXOpen.Point3d(-63.527156833303387, -23.428455002352877, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint47, viewCenter47);
    
    NXOpen.Point3d scaleAboutPoint48 = new NXOpen.Point3d(78.845762027149092, 27.877608716742074, 0.0);
    NXOpen.Point3d viewCenter48 = new NXOpen.Point3d(-78.845762027149561, -27.877608716742074, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint48, viewCenter48);
    
    NXOpen.Session.UndoMarkId markId24;
    markId24 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Drawings.SectionView sectionView1 = ((NXOpen.Drawings.SectionView)workPart.DraftingViews.FindObject("SX@SECT-LL"));
    NXOpen.Point3d drawingReferencePoint1 = new NXOpen.Point3d(764.72059860405591, 512.23262587605666, 0.0);
    sectionView1.MoveView(drawingReferencePoint1);
    
    int nErrs19;
    nErrs19 = theSession.UpdateManager.DoUpdate(markId24);
    
    NXOpen.Point3d scaleAboutPoint49 = new NXOpen.Point3d(111.22884285972819, 103.48506266063339, 0.0);
    NXOpen.Point3d viewCenter49 = new NXOpen.Point3d(-111.22884285972872, -103.48506266063352, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint49, viewCenter49);
    
    NXOpen.Point3d scaleAboutPoint50 = new NXOpen.Point3d(88.983074287782486, 82.788050128506782, 0.0);
    NXOpen.Point3d viewCenter50 = new NXOpen.Point3d(-88.98307428778314, -82.788050128506782, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint50, viewCenter50);
    
    NXOpen.Point3d scaleAboutPoint51 = new NXOpen.Point3d(89.208347893574327, 65.779892891221692, 0.0);
    NXOpen.Point3d viewCenter51 = new NXOpen.Point3d(-89.208347893574995, -65.779892891221749, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint51, viewCenter51);
    
    NXOpen.Point3d scaleAboutPoint52 = new NXOpen.Point3d(111.51043486696801, 82.224866114027151, 0.0);
    NXOpen.Point3d viewCenter52 = new NXOpen.Point3d(-111.51043486696867, -82.224866114027151, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint52, viewCenter52);
    
    NXOpen.Point3d scaleAboutPoint53 = new NXOpen.Point3d(139.3880435837101, 102.78108264253392, 0.0);
    NXOpen.Point3d viewCenter53 = new NXOpen.Point3d(-139.38804358371078, -102.78108264253397, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint53, viewCenter53);
    
    NXOpen.Point3d scaleAboutPoint54 = new NXOpen.Point3d(174.23505447963763, 128.47635330316737, 0.0);
    NXOpen.Point3d viewCenter54 = new NXOpen.Point3d(-174.23505447963836, -128.47635330316737, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint54, viewCenter54);
    
    NXOpen.Point3d scaleAboutPoint55 = new NXOpen.Point3d(217.79381809954725, 160.59544162895926, 0.0);
    NXOpen.Point3d viewCenter55 = new NXOpen.Point3d(-217.79381809954788, -160.59544162895926, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint55, viewCenter55);
    
    NXOpen.Point3d scaleAboutPoint56 = new NXOpen.Point3d(272.24227262443424, 200.74430203619914, 0.0);
    NXOpen.Point3d viewCenter56 = new NXOpen.Point3d(-272.24227262443469, -200.74430203619909, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint56, viewCenter56);
    
    NXOpen.Point3d scaleAboutPoint57 = new NXOpen.Point3d(334.28738652432105, 250.07102693721717, 0.0);
    NXOpen.Point3d viewCenter57 = new NXOpen.Point3d(-334.28738652432162, -250.07102693721717, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint57, viewCenter57);
    
    NXOpen.Point3d scaleAboutPoint58 = new NXOpen.Point3d(267.42990921945704, 200.05682154977379, 0.0);
    NXOpen.Point3d viewCenter58 = new NXOpen.Point3d(-267.42990921945727, -200.05682154977379, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint58, viewCenter58);
    
    NXOpen.Point3d scaleAboutPoint59 = new NXOpen.Point3d(213.94392737556549, 160.045457239819, 0.0);
    NXOpen.Point3d viewCenter59 = new NXOpen.Point3d(-213.94392737556578, -160.045457239819, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint59, viewCenter59);
    
    NXOpen.Point3d scaleAboutPoint60 = new NXOpen.Point3d(171.15514190045238, 128.03636579185519, 0.0);
    NXOpen.Point3d viewCenter60 = new NXOpen.Point3d(-171.15514190045269, -128.03636579185519, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint60, viewCenter60);
    
    NXOpen.Point3d scaleAboutPoint61 = new NXOpen.Point3d(136.92411352036197, 102.42909263348417, 0.0);
    NXOpen.Point3d viewCenter61 = new NXOpen.Point3d(-136.9241135203622, -102.42909263348423, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint61, viewCenter61);
    
    NXOpen.Point3d scaleAboutPoint62 = new NXOpen.Point3d(140.51441161266968, 81.380090092307739, 0.0);
    NXOpen.Point3d viewCenter62 = new NXOpen.Point3d(-140.51441161266985, -81.380090092307739, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint62, viewCenter62);
    
    NXOpen.Point3d scaleAboutPoint63 = new NXOpen.Point3d(171.77112441628978, 101.37312260633492, 0.0);
    NXOpen.Point3d viewCenter63 = new NXOpen.Point3d(-171.77112441628978, -101.37312260633497, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint63, viewCenter63);
    
    NXOpen.Point3d scaleAboutPoint64 = new NXOpen.Point3d(207.23411782805459, 125.39644072398202, 0.0);
    NXOpen.Point3d viewCenter64 = new NXOpen.Point3d(-207.23411782805454, -125.39644072398202, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint64, viewCenter64);
    
    NXOpen.Point3d scaleAboutPoint65 = new NXOpen.Point3d(247.49297511312264, 155.09559773755677, 0.0);
    NXOpen.Point3d viewCenter65 = new NXOpen.Point3d(-247.49297511312247, -155.09559773755677, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint65, viewCenter65);
    
    NXOpen.Point3d scaleAboutPoint66 = new NXOpen.Point3d(288.05432381221766, 191.80705571266984, 0.0);
    NXOpen.Point3d viewCenter66 = new NXOpen.Point3d(-288.05432381221738, -191.80705571266989, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint66, viewCenter66);
    
    NXOpen.Point3d scaleAboutPoint67 = new NXOpen.Point3d(331.70933470022635, 236.32141720871056, 0.0);
    NXOpen.Point3d viewCenter67 = new NXOpen.Point3d(-331.70933470022652, -236.32141720871056, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint67, viewCenter67);
    
    NXOpen.Point3d scaleAboutPoint68 = new NXOpen.Point3d(353.40793755302622, 290.03083021069028, 0.0);
    NXOpen.Point3d viewCenter68 = new NXOpen.Point3d(-353.40793755302639, -290.03083021069028, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint68, viewCenter68);
    
    NXOpen.Point3d scaleAboutPoint69 = new NXOpen.Point3d(526.35224741940124, 358.51033178821439, 0.0);
    NXOpen.Point3d viewCenter69 = new NXOpen.Point3d(-526.35224741940124, -358.51033178821439, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint69, viewCenter69);
    
    NXOpen.Point3d scaleAboutPoint70 = new NXOpen.Point3d(472.64283441742128, 294.32758325084865, 0.0);
    NXOpen.Point3d viewCenter70 = new NXOpen.Point3d(-472.64283441742128, -294.32758325084865, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint70, viewCenter70);
    
    NXOpen.Point3d scaleAboutPoint71 = new NXOpen.Point3d(381.55166996606368, 235.46206660067898, 0.0);
    NXOpen.Point3d viewCenter71 = new NXOpen.Point3d(-381.55166996606368, -235.4620666006789, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint71, viewCenter71);
    
    NXOpen.Point3d scaleAboutPoint72 = new NXOpen.Point3d(305.92881645927633, 188.3696532805431, 0.0);
    NXOpen.Point3d viewCenter72 = new NXOpen.Point3d(-305.92881645927633, -188.3696532805431, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint72, viewCenter72);
    
    NXOpen.Point3d scaleAboutPoint73 = new NXOpen.Point3d(244.74305316742107, 150.6957226244345, 0.0);
    NXOpen.Point3d viewCenter73 = new NXOpen.Point3d(-244.74305316742107, -150.6957226244345, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint73, viewCenter73);
    
    NXOpen.Point3d scaleAboutPoint74 = new NXOpen.Point3d(195.79444253393697, 120.55657809954762, 0.0);
    NXOpen.Point3d viewCenter74 = new NXOpen.Point3d(-195.79444253393683, -120.55657809954762, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint74, viewCenter74);
    
    NXOpen.Point3d scaleAboutPoint75 = new NXOpen.Point3d(156.63555402714951, 96.445262479638075, 0.0);
    NXOpen.Point3d viewCenter75 = new NXOpen.Point3d(-156.63555402714951, -96.445262479638131, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint75, viewCenter75);
    
    NXOpen.Session.UndoMarkId markId25;
    markId25 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note5 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 29 1"));
    note5.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Note note6 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-811368"));
    note5.InsertIntoStack(note6, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    int nErrs20;
    nErrs20 = theSession.UpdateManager.DoUpdate(markId25);
    
    NXOpen.Point3d scaleAboutPoint76 = new NXOpen.Point3d(68.708449766515869, -19.993032514027167, 0.0);
    NXOpen.Point3d viewCenter76 = new NXOpen.Point3d(-68.708449766515983, 19.993032514027167, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint76, viewCenter76);
    
    NXOpen.Point3d scaleAboutPoint77 = new NXOpen.Point3d(98.205212524886761, -21.119400542986391, 0.0);
    NXOpen.Point3d viewCenter77 = new NXOpen.Point3d(-98.205212524887045, 21.119400542986451, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint77, viewCenter77);
    
    NXOpen.Point3d origin11 = new NXOpen.Point3d(599.90136493016109, 458.65987813391342, 0.0);
    workPart.Views.WorkView.SetOrigin(origin11);
    
    NXOpen.Point3d origin12 = new NXOpen.Point3d(599.90136493016109, 458.65987813391342, 0.0);
    workPart.Views.WorkView.SetOrigin(origin12);
    
    NXOpen.Session.UndoMarkId markId26;
    markId26 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Drawings.SectionView sectionView2 = ((NXOpen.Drawings.SectionView)workPart.DraftingViews.FindObject("SX@SECT-MM"));
    NXOpen.Point3d drawingReferencePoint2 = new NXOpen.Point3d(633.68151596711573, 512.23262587605666, 0.0);
    sectionView2.MoveView(drawingReferencePoint2);
    
    int nErrs21;
    nErrs21 = theSession.UpdateManager.DoUpdate(markId26);
    
    NXOpen.Session.UndoMarkId markId27;
    markId27 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Point3d drawingReferencePoint3 = new NXOpen.Point3d(642.48288260659263, 512.23262587605666, 0.0);
    sectionView2.MoveView(drawingReferencePoint3);
    
    int nErrs22;
    nErrs22 = theSession.UpdateManager.DoUpdate(markId27);
    
    NXOpen.Session.UndoMarkId markId28;
    markId28 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Point3d drawingReferencePoint4 = new NXOpen.Point3d(650.84264532152486, 512.23262587605666, 0.0);
    sectionView2.MoveView(drawingReferencePoint4);
    
    int nErrs23;
    nErrs23 = theSession.UpdateManager.DoUpdate(markId28);
    
    NXOpen.Session.UndoMarkId markId29;
    markId29 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note7 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 28 1"));
    note7.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Note note8 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-811272"));
    note7.InsertIntoStack(note8, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    int nErrs24;
    nErrs24 = theSession.UpdateManager.DoUpdate(markId29);
    
    NXOpen.Point3d scaleAboutPoint78 = new NXOpen.Point3d(140.79600361990958, 10.119712760181041, 0.0);
    NXOpen.Point3d viewCenter78 = new NXOpen.Point3d(-140.79600361990964, -10.119712760180969, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint78, viewCenter78);
    
    NXOpen.Point3d scaleAboutPoint79 = new NXOpen.Point3d(186.9946923076925, 16.499531674208153, 0.0);
    NXOpen.Point3d viewCenter79 = new NXOpen.Point3d(-186.99469230769245, -16.499531674208153, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint79, viewCenter79);
    
    NXOpen.Point3d origin13 = new NXOpen.Point3d(528.26589824464145, 384.63197935563284, 0.0);
    workPart.Views.WorkView.SetOrigin(origin13);
    
    NXOpen.Point3d origin14 = new NXOpen.Point3d(528.26589824464145, 384.63197935563284, 0.0);
    workPart.Views.WorkView.SetOrigin(origin14);
    
    NXOpen.Point3d scaleAboutPoint80 = new NXOpen.Point3d(157.43303139140264, -2.0624414592760467, 0.0);
    NXOpen.Point3d viewCenter80 = new NXOpen.Point3d(-157.43303139140275, 2.0624414592760467, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint80, viewCenter80);
    
    NXOpen.Session.UndoMarkId markId30;
    markId30 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Drawings.ProjectedView projectedView1 = ((NXOpen.Drawings.ProjectedView)workPart.DraftingViews.FindObject("AUXIL@PI-MAIN-VIEW"));
    NXOpen.Point3d drawingReferencePoint5 = new NXOpen.Point3d(764.72059860405591, 364.8052626081373, 0.0);
    projectedView1.MoveView(drawingReferencePoint5);
    
    int nErrs25;
    nErrs25 = theSession.UpdateManager.DoUpdate(markId30);
    
    NXOpen.Point3d scaleAboutPoint81 = new NXOpen.Point3d(138.04608167420801, -102.29709638009058, 0.0);
    NXOpen.Point3d viewCenter81 = new NXOpen.Point3d(-138.04608167420827, 102.29709638009054, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint81, viewCenter81);
    
    NXOpen.Point3d scaleAboutPoint82 = new NXOpen.Point3d(108.67691529411766, -81.397689592760202, 0.0);
    NXOpen.Point3d viewCenter82 = new NXOpen.Point3d(-108.67691529411785, 81.397689592760244, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint82, viewCenter82);
    
    NXOpen.Session.UndoMarkId markId31;
    markId31 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Drawings.SectionView sectionView3 = ((NXOpen.Drawings.SectionView)workPart.DraftingViews.FindObject("SX@SECT-BB"));
    NXOpen.Point3d drawingReferencePoint6 = new NXOpen.Point3d(630.51360588566763, 388.74990714826731, 0.0);
    sectionView3.MoveView(drawingReferencePoint6);
    
    int nErrs26;
    nErrs26 = theSession.UpdateManager.DoUpdate(markId31);
    
    NXOpen.Session.UndoMarkId markId32;
    markId32 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label1 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-81254"));
    label1.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin15 = new NXOpen.Point3d(804.09956893016204, 406.26286538051932, 0.0);
    label1.AnnotationOrigin = origin15;
    
    int nErrs27;
    nErrs27 = theSession.UpdateManager.DoUpdate(markId32);
    
    NXOpen.Point3d scaleAboutPoint83 = new NXOpen.Point3d(145.72386374660636, 14.431590371040762, 0.0);
    NXOpen.Point3d viewCenter83 = new NXOpen.Point3d(-145.72386374660647, -14.431590371040732, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint83, viewCenter83);
    
    NXOpen.Point3d scaleAboutPoint84 = new NXOpen.Point3d(182.1548296832579, 18.479475475113198, 0.0);
    NXOpen.Point3d viewCenter84 = new NXOpen.Point3d(-182.15482968325807, -18.479475475113052, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint84, viewCenter84);
    
    NXOpen.Point3d scaleAboutPoint85 = new NXOpen.Point3d(231.54342782805458, 29.699157013574766, 0.0);
    NXOpen.Point3d viewCenter85 = new NXOpen.Point3d(-231.54342782805449, -29.699157013574627, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint85, viewCenter85);
    
    NXOpen.Point3d scaleAboutPoint86 = new NXOpen.Point3d(296.30408964932138, 47.436153563348483, 0.0);
    NXOpen.Point3d viewCenter86 = new NXOpen.Point3d(-296.30408964932138, -47.43615356334837, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint86, viewCenter86);
    
    NXOpen.Point3d scaleAboutPoint87 = new NXOpen.Point3d(350.61504807692324, 80.778957154977476, 0.0);
    NXOpen.Point3d viewCenter87 = new NXOpen.Point3d(-350.61504807692342, -80.778957154977334, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint87, viewCenter87);
    
    NXOpen.Point3d scaleAboutPoint88 = new NXOpen.Point3d(282.55447992081446, 62.560724264705946, 0.0);
    NXOpen.Point3d viewCenter88 = new NXOpen.Point3d(-282.55447992081469, -62.560724264705776, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint88, viewCenter88);
    
    NXOpen.Point3d scaleAboutPoint89 = new NXOpen.Point3d(227.14355271493196, 48.948610633484243, 0.0);
    NXOpen.Point3d viewCenter89 = new NXOpen.Point3d(-227.14355271493233, -48.948610633484108, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint89, viewCenter89);
    
    NXOpen.Point3d origin16 = new NXOpen.Point3d(654.34569457213922, 373.38617355868672, 0.0);
    workPart.Views.WorkView.SetOrigin(origin16);
    
    NXOpen.Point3d origin17 = new NXOpen.Point3d(654.34569457213922, 373.38617355868672, 0.0);
    workPart.Views.WorkView.SetOrigin(origin17);
    
    NXOpen.Point3d scaleAboutPoint90 = new NXOpen.Point3d(1.3199625339365224, 1.3199625339366692, 0.0);
    NXOpen.Point3d viewCenter90 = new NXOpen.Point3d(-1.319962533936816, -1.3199625339365593, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint90, viewCenter90);
    
    NXOpen.Point3d scaleAboutPoint91 = new NXOpen.Point3d(1.7599500452486965, 0.7039800180996254, 0.0);
    NXOpen.Point3d viewCenter91 = new NXOpen.Point3d(-1.75995004524899, -0.70398001809947863, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint91, viewCenter91);
    
    NXOpen.Point3d scaleAboutPoint92 = new NXOpen.Point3d(1.4079600361989577, 0.56318401447967703, 0.0);
    NXOpen.Point3d viewCenter92 = new NXOpen.Point3d(-1.4079600361992395, -0.56318401447955957, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint92, viewCenter92);
    
    NXOpen.Point3d scaleAboutPoint93 = new NXOpen.Point3d(1.126368028959166, 0.45054721158376032, 0.0);
    NXOpen.Point3d viewCenter93 = new NXOpen.Point3d(-1.1263680289593914, -0.45054721158364763, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint93, viewCenter93);
    
    NXOpen.Point3d scaleAboutPoint94 = new NXOpen.Point3d(38.026184657665034, 5.7670043082715443, 0.0);
    NXOpen.Point3d viewCenter94 = new NXOpen.Point3d(-38.026184657665276, -5.7670043082714235, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint94, viewCenter94);
    
    NXOpen.Point3d scaleAboutPoint95 = new NXOpen.Point3d(47.532730822081348, 7.2087553853394137, 0.0);
    NXOpen.Point3d viewCenter95 = new NXOpen.Point3d(-47.532730822081575, -7.2087553853393009, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint95, viewCenter95);
    
    NXOpen.Point3d scaleAboutPoint96 = new NXOpen.Point3d(59.415913527601724, 9.0109442316742427, 0.0);
    NXOpen.Point3d viewCenter96 = new NXOpen.Point3d(-59.415913527601916, -9.0109442316741255, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint96, viewCenter96);
    
    NXOpen.Point3d scaleAboutPoint97 = new NXOpen.Point3d(73.213921882352821, 11.615670298642572, 0.0);
    NXOpen.Point3d viewCenter97 = new NXOpen.Point3d(-73.213921882353048, -11.615670298642483, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint97, viewCenter97);
    
    NXOpen.Point3d origin18 = new NXOpen.Point3d(629.96053072519135, 372.19292742800633, 0.0);
    workPart.Views.WorkView.SetOrigin(origin18);
    
    NXOpen.Point3d origin19 = new NXOpen.Point3d(629.96053072519135, 372.19292742800633, 0.0);
    workPart.Views.WorkView.SetOrigin(origin19);
    
    NXOpen.Point3d scaleAboutPoint98 = new NXOpen.Point3d(124.95645321266964, 49.278601266968387, 0.0);
    NXOpen.Point3d viewCenter98 = new NXOpen.Point3d(-124.95645321266979, -49.278601266968202, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint98, viewCenter98);
    
    NXOpen.Point3d scaleAboutPoint99 = new NXOpen.Point3d(174.34505135746613, 65.448142307692379, 0.0);
    NXOpen.Point3d viewCenter99 = new NXOpen.Point3d(-174.34505135746605, -65.448142307692194, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint99, viewCenter99);
    
    NXOpen.Point3d scaleAboutPoint100 = new NXOpen.Point3d(266.05494824660644, 98.997190045249027, 0.0);
    NXOpen.Point3d viewCenter100 = new NXOpen.Point3d(-266.05494824660633, -98.997190045248743, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint100, viewCenter100);
    
    NXOpen.Session.UndoMarkId markId33;
    markId33 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Annotations.DraftingSurfaceFinish draftingSurfaceFinish1 = ((NXOpen.Annotations.DraftingSurfaceFinish)workPart.Annotations.DraftingSurfaceFinishSymbols.FindObject("ENTITY 158 1 1"));
    NXOpen.Annotations.DraftingSurfaceFinishBuilder draftingSurfaceFinishBuilder1;
    draftingSurfaceFinishBuilder1 = workPart.Annotations.DraftingSurfaceFinishSymbols.CreateDraftingSurfaceFinishBuilder(draftingSurfaceFinish1);
    
    draftingSurfaceFinishBuilder1.Finish = NXOpen.Annotations.DraftingSurfaceFinishBuilder.FinishType.Modifier;
    
    theSession.SetUndoMarkName(markId33, "表面粗糙度 对话框");
    
    draftingSurfaceFinishBuilder1.Origin.SetInferRelativeToGeometry(true);
    
    NXOpen.Annotations.LeaderData leaderData1;
    leaderData1 = workPart.Annotations.CreateLeaderData();
    
    leaderData1.StubSize = 3.5000000103999995;
    
    leaderData1.Arrowhead = NXOpen.Annotations.LeaderData.ArrowheadType.FilledArrow;
    
    leaderData1.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Center;
    
    draftingSurfaceFinishBuilder1.Leader.Leaders.Append(leaderData1);
    
    leaderData1.StubSide = NXOpen.Annotations.LeaderSide.Inferred;
    
    draftingSurfaceFinishBuilder1.Origin.Anchor = NXOpen.Annotations.OriginBuilder.AlignmentPosition.BottomCenter;
    
    draftingSurfaceFinishBuilder1.Origin.SetInferRelativeToGeometry(true);
    
    draftingSurfaceFinishBuilder1.Origin.SetInferRelativeToGeometry(true);
    
    NXOpen.Session.UndoMarkId markId34;
    markId34 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "表面粗糙度");
    
    // ----------------------------------------------
    //   对话开始 表面粗糙度
    // ----------------------------------------------
    theSession.DeleteUndoMark(markId34, null);
    
    NXOpen.Session.UndoMarkId markId35;
    markId35 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "表面粗糙度");
    
    draftingSurfaceFinishBuilder1.Destroy();
    
    theSession.UndoToMark(markId33, null);
    
    theSession.DeleteUndoMark(markId33, null);
    
    NXOpen.Point3d scaleAboutPoint101 = new NXOpen.Point3d(277.57024639423088, -232.02466416855196, 0.0);
    NXOpen.Point3d viewCenter101 = new NXOpen.Point3d(-277.57024639423076, 232.02466416855219, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint101, viewCenter101);
    
    NXOpen.Point3d scaleAboutPoint102 = new NXOpen.Point3d(227.55604100678738, -186.99469230769216, 0.0);
    NXOpen.Point3d viewCenter102 = new NXOpen.Point3d(-227.55604100678738, 186.99469230769239, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint102, viewCenter102);
    
    NXOpen.Point3d scaleAboutPoint103 = new NXOpen.Point3d(182.04483280542973, -150.14573823529392, 0.0);
    NXOpen.Point3d viewCenter103 = new NXOpen.Point3d(-182.04483280542982, 150.14573823529415, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint103, viewCenter103);
    
    NXOpen.Point3d scaleAboutPoint104 = new NXOpen.Point3d(145.63586624434379, -119.67660307692287, 0.0);
    NXOpen.Point3d viewCenter104 = new NXOpen.Point3d(-145.63586624434393, 119.67660307692317, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint104, viewCenter104);
    
    NXOpen.Point3d scaleAboutPoint105 = new NXOpen.Point3d(116.50869299547504, -95.741282461538276, 0.0);
    NXOpen.Point3d viewCenter105 = new NXOpen.Point3d(-116.50869299547522, 95.741282461538574, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint105, viewCenter105);
    
    NXOpen.Point3d scaleAboutPoint106 = new NXOpen.Point3d(93.206954396380112, -76.593025969230624, 0.0);
    NXOpen.Point3d viewCenter106 = new NXOpen.Point3d(-93.206954396380112, 76.593025969230908, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint106, viewCenter106);
    
    NXOpen.Point3d scaleAboutPoint107 = new NXOpen.Point3d(74.565563517104081, -61.274420775384435, 0.0);
    NXOpen.Point3d viewCenter107 = new NXOpen.Point3d(-74.565563517104081, 61.274420775384755, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint107, viewCenter107);
    
    NXOpen.Point3d scaleAboutPoint108 = new NXOpen.Point3d(39.648154619366508, -6.4878798468052752, 0.0);
    NXOpen.Point3d viewCenter108 = new NXOpen.Point3d(-39.648154619366508, 6.4878798468055603, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint108, viewCenter108);
    
    NXOpen.Point3d scaleAboutPoint109 = new NXOpen.Point3d(49.560193274208146, -8.1098498085066328, 0.0);
    NXOpen.Point3d viewCenter109 = new NXOpen.Point3d(-49.560193274208146, 8.1098498085069153, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint109, viewCenter109);
    
    NXOpen.Point3d scaleAboutPoint110 = new NXOpen.Point3d(-5.0686561303167172, 23.935320615384757, 0.0);
    NXOpen.Point3d viewCenter110 = new NXOpen.Point3d(5.0686561303167172, -23.935320615384452, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint110, viewCenter110);
    
    NXOpen.Point3d scaleAboutPoint111 = new NXOpen.Point3d(-3.8718900995474277, 29.215170751131367, 0.0);
    NXOpen.Point3d viewCenter111 = new NXOpen.Point3d(3.8718900995474863, -29.215170751131076, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint111, viewCenter111);
    
    NXOpen.Point3d scaleAboutPoint112 = new NXOpen.Point3d(-4.8398626244343195, 36.518963438914163, 0.0);
    NXOpen.Point3d viewCenter112 = new NXOpen.Point3d(4.8398626244343195, -36.518963438913865, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint112, viewCenter112);
    
    NXOpen.Session.UndoMarkId markId36;
    markId36 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Hide");
    
    NXOpen.DisplayableObject[] objects10 = new NXOpen.DisplayableObject[8];
    NXOpen.Features.DatumCsys datumCsys1 = ((NXOpen.Features.DatumCsys)workPart.Features.FindObject("DATUM_CSYS(20)"));
    NXOpen.CartesianCoordinateSystem cartesianCoordinateSystem1 = ((NXOpen.CartesianCoordinateSystem)datumCsys1.FindObject("CSYSTEM 1"));
    objects10[0] = cartesianCoordinateSystem1;
    NXOpen.DatumPlane datumPlane1 = ((NXOpen.DatumPlane)workPart.Datums.FindObject("DATUM_CSYS(20) XY plane"));
    objects10[1] = datumPlane1;
    NXOpen.DatumAxis datumAxis1 = ((NXOpen.DatumAxis)workPart.Datums.FindObject("DATUM_CSYS(20) Y axis"));
    objects10[2] = datumAxis1;
    NXOpen.DatumPlane datumPlane2 = ((NXOpen.DatumPlane)workPart.Datums.FindObject("DATUM_CSYS(20) YZ plane"));
    objects10[3] = datumPlane2;
    NXOpen.Point point3 = ((NXOpen.Point)datumCsys1.FindObject("POINT 1"));
    objects10[4] = point3;
    NXOpen.DatumAxis datumAxis2 = ((NXOpen.DatumAxis)workPart.Datums.FindObject("DATUM_CSYS(20) Z axis"));
    objects10[5] = datumAxis2;
    NXOpen.DatumPlane datumPlane3 = ((NXOpen.DatumPlane)workPart.Datums.FindObject("DATUM_CSYS(20) XZ plane"));
    objects10[6] = datumPlane3;
    NXOpen.DatumAxis datumAxis3 = ((NXOpen.DatumAxis)workPart.Datums.FindObject("DATUM_CSYS(20) X axis"));
    objects10[7] = datumAxis3;
    theSession.DisplayManager.BlankObjects(objects10);
    
    int nErrs28;
    nErrs28 = theSession.UpdateManager.DoUpdate(markId36);
    
    workPart.Views.WorkView.FitAfterShowOrHide(NXOpen.View.ShowOrHideType.HideOnly);
    
    NXOpen.Point3d scaleAboutPoint113 = new NXOpen.Point3d(21.449391176470598, 11.549672171945808, 0.0);
    NXOpen.Point3d viewCenter113 = new NXOpen.Point3d(-21.449391176470598, -11.549672171945533, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint113, viewCenter113);
    
    NXOpen.Point3d scaleAboutPoint114 = new NXOpen.Point3d(32.31158286199112, 12.374648755656276, 0.0);
    NXOpen.Point3d viewCenter114 = new NXOpen.Point3d(-32.311582861990885, -12.374648755655931, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint114, viewCenter114);
    
    NXOpen.Point3d scaleAboutPoint115 = new NXOpen.Point3d(42.967530401583801, 14.608960336538679, 0.0);
    NXOpen.Point3d viewCenter115 = new NXOpen.Point3d(-42.967530401583801, -14.60896033653832, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint115, viewCenter115);
    
    NXOpen.Point3d origin20 = new NXOpen.Point3d(508.94589537722885, 207.91849172429855, 0.0);
    workPart.Views.WorkView.SetOrigin(origin20);
    
    NXOpen.Point3d origin21 = new NXOpen.Point3d(508.94589537722885, 207.91849172429855, 0.0);
    workPart.Views.WorkView.SetOrigin(origin21);
    
    NXOpen.Point3d scaleAboutPoint116 = new NXOpen.Point3d(87.009249063207193, 169.72174508625577, 0.0);
    NXOpen.Point3d viewCenter116 = new NXOpen.Point3d(-87.009249063207292, -169.72174508625542, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint116, viewCenter116);
    
    NXOpen.Point3d scaleAboutPoint117 = new NXOpen.Point3d(64.45129560237541, 129.76194181278294, 0.0);
    NXOpen.Point3d viewCenter117 = new NXOpen.Point3d(-64.451295602375694, -129.76194181278265, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint117, viewCenter117);
    
    NXOpen.Point3d scaleAboutPoint118 = new NXOpen.Point3d(247.49297511312201, 41.936309671945722, 0.0);
    NXOpen.Point3d viewCenter118 = new NXOpen.Point3d(-247.49297511312224, -41.936309671945551, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint118, viewCenter118);
    
    NXOpen.Point3d scaleAboutPoint119 = new NXOpen.Point3d(196.89441131221707, 33.54904773755662, 0.0);
    NXOpen.Point3d viewCenter119 = new NXOpen.Point3d(-196.89441131221727, -33.549047737556442, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint119, viewCenter119);
    
    NXOpen.Point3d scaleAboutPoint120 = new NXOpen.Point3d(157.51552904977339, 26.839238190045251, 0.0);
    NXOpen.Point3d viewCenter120 = new NXOpen.Point3d(-157.51552904977396, -26.83923819004514, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint120, viewCenter120);
    
    NXOpen.Point3d scaleAboutPoint121 = new NXOpen.Point3d(60.190291547511031, 96.445262479637989, 0.0);
    NXOpen.Point3d viewCenter121 = new NXOpen.Point3d(-60.190291547511499, -96.445262479637876, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint121, viewCenter121);
    
    NXOpen.Point3d scaleAboutPoint122 = new NXOpen.Point3d(47.025865209049527, 78.564170019909497, 0.0);
    NXOpen.Point3d viewCenter122 = new NXOpen.Point3d(-47.025865209049996, -78.564170019909383, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint122, viewCenter122);
    
    NXOpen.Point3d scaleAboutPoint123 = new NXOpen.Point3d(37.395418561447705, 63.076609621719463, 0.0);
    NXOpen.Point3d viewCenter123 = new NXOpen.Point3d(-37.395418561448174, -63.076609621719349, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint123, viewCenter123);
    
    NXOpen.Point3d scaleAboutPoint124 = new NXOpen.Point3d(29.736115964524647, 50.641506582009086, 0.0);
    NXOpen.Point3d viewCenter124 = new NXOpen.Point3d(-29.736115964525126, -50.641506582008972, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint124, viewCenter124);
    
    NXOpen.Point3d scaleAboutPoint125 = new NXOpen.Point3d(16.003436955453164, 35.322901388162926, 0.0);
    NXOpen.Point3d viewCenter125 = new NXOpen.Point3d(-16.003436955453608, -35.322901388162805, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint125, viewCenter125);
    
    NXOpen.Point3d scaleAboutPoint126 = new NXOpen.Point3d(20.004296194316478, 44.153626735203623, 0.0);
    NXOpen.Point3d viewCenter126 = new NXOpen.Point3d(-20.004296194316957, -44.153626735203503, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint126, viewCenter126);
    
    NXOpen.Point3d scaleAboutPoint127 = new NXOpen.Point3d(25.005370242895669, 55.192033419004495, 0.0);
    NXOpen.Point3d viewCenter127 = new NXOpen.Point3d(-25.00537024289612, -55.192033419004382, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint127, viewCenter127);
    
    NXOpen.Point3d scaleAboutPoint128 = new NXOpen.Point3d(127.56117927963757, 2.5343280651584248, 0.0);
    NXOpen.Point3d viewCenter128 = new NXOpen.Point3d(-127.56117927963804, -2.5343280651583076, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint128, viewCenter128);
    
    NXOpen.Point3d scaleAboutPoint129 = new NXOpen.Point3d(159.45147409954703, 3.1679100814480017, 0.0);
    NXOpen.Point3d viewCenter129 = new NXOpen.Point3d(-159.45147409954748, -3.1679100814478844, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint129, viewCenter129);
    
    NXOpen.Point3d scaleAboutPoint130 = new NXOpen.Point3d(199.31434262443383, 3.9598876018099656, 0.0);
    NXOpen.Point3d viewCenter130 = new NXOpen.Point3d(-199.31434262443429, -3.9598876018098554, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint130, viewCenter130);
    
    NXOpen.Point3d scaleAboutPoint131 = new NXOpen.Point3d(249.14292828054244, 4.9498595022624574, 0.0);
    NXOpen.Point3d viewCenter131 = new NXOpen.Point3d(-249.1429282805428, -4.9498595022623659, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint131, viewCenter131);
    
    NXOpen.Point3d scaleAboutPoint132 = new NXOpen.Point3d(310.7411798642525, 112.05931928733008, 0.0);
    NXOpen.Point3d viewCenter132 = new NXOpen.Point3d(-310.74117986425307, -112.05931928733014, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint132, viewCenter132);
    
    NXOpen.Point3d scaleAboutPoint133 = new NXOpen.Point3d(245.84302194570066, 85.247580316741818, 0.0);
    NXOpen.Point3d viewCenter133 = new NXOpen.Point3d(-245.84302194570122, -85.247580316741946, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint133, viewCenter133);
    
    NXOpen.Point3d scaleAboutPoint134 = new NXOpen.Point3d(195.79444253393606, 66.878101719456851, 0.0);
    NXOpen.Point3d viewCenter134 = new NXOpen.Point3d(-195.79444253393663, -66.878101719456922, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint134, viewCenter134);
    
    NXOpen.Point3d scaleAboutPoint135 = new NXOpen.Point3d(99.96516257013522, 41.534821067873231, 0.0);
    NXOpen.Point3d viewCenter135 = new NXOpen.Point3d(-99.965162570135931, -41.534821067873231, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint135, viewCenter135);
    
    NXOpen.Point3d scaleAboutPoint136 = new NXOpen.Point3d(79.127354034388659, 32.101488825339317, 0.0);
    NXOpen.Point3d viewCenter136 = new NXOpen.Point3d(-79.12735403438937, -32.101488825339317, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint136, viewCenter136);
    
    NXOpen.Point3d scaleAboutPoint137 = new NXOpen.Point3d(62.400788804343456, 25.005370242895893, 0.0);
    NXOpen.Point3d viewCenter137 = new NXOpen.Point3d(-62.400788804344138, -25.005370242895893, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint137, viewCenter137);
    
    NXOpen.Point3d scaleAboutPoint138 = new NXOpen.Point3d(49.019536620307292, 19.46363954041626, 0.0);
    NXOpen.Point3d viewCenter138 = new NXOpen.Point3d(-49.019536620307967, -19.46363954041626, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint138, viewCenter138);
    
    NXOpen.Point3d scaleAboutPoint139 = new NXOpen.Point3d(39.071454188539008, 15.426736524626229, 0.0);
    NXOpen.Point3d viewCenter139 = new NXOpen.Point3d(-39.071454188539683, -15.426736524626229, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint139, viewCenter139);
    
    NXOpen.Session.UndoMarkId markId37;
    markId37 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label2 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-84923"));
    label2.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin22 = new NXOpen.Point3d(703.22479047874708, 420.65949698382957, 0.0);
    label2.AnnotationOrigin = origin22;
    
    int nErrs29;
    nErrs29 = theSession.UpdateManager.DoUpdate(markId37);
    
    NXOpen.Point3d scaleAboutPoint140 = new NXOpen.Point3d(44.636613346020972, 13.379449995189846, 0.0);
    NXOpen.Point3d viewCenter140 = new NXOpen.Point3d(-44.636613346021662, -13.379449995189846, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint140, viewCenter140);
    
    NXOpen.Point3d scaleAboutPoint141 = new NXOpen.Point3d(51.326338343615923, 17.589363140228034, 0.0);
    NXOpen.Point3d viewCenter141 = new NXOpen.Point3d(-51.326338343616598, -17.589363140228034, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint141, viewCenter141);
    
    NXOpen.Point3d scaleAboutPoint142 = new NXOpen.Point3d(72.628210507293758, -17.301012924814465, 0.0);
    NXOpen.Point3d viewCenter142 = new NXOpen.Point3d(-72.628210507294426, 17.301012924814465, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint142, viewCenter142);
    
    NXOpen.Point3d scaleAboutPoint143 = new NXOpen.Point3d(89.20834789357427, -20.049350915475095, 0.0);
    NXOpen.Point3d viewCenter143 = new NXOpen.Point3d(-89.208347893574938, 20.049350915475095, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint143, viewCenter143);
    
    NXOpen.Point3d scaleAboutPoint144 = new NXOpen.Point3d(110.94725085248832, -23.935320615384615, 0.0);
    NXOpen.Point3d viewCenter144 = new NXOpen.Point3d(-110.94725085248898, 23.935320615384615, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint144, viewCenter144);
    
    NXOpen.Point3d origin23 = new NXOpen.Point3d(622.03719668259043, 353.23735950638672, 0.0);
    workPart.Views.WorkView.SetOrigin(origin23);
    
    NXOpen.Point3d origin24 = new NXOpen.Point3d(622.03719668259043, 353.23735950638672, 0.0);
    workPart.Views.WorkView.SetOrigin(origin24);
    
    NXOpen.Point3d scaleAboutPoint145 = new NXOpen.Point3d(101.37312260633455, -42.590791095022624, 0.0);
    NXOpen.Point3d viewCenter145 = new NXOpen.Point3d(-101.37312260633519, 42.590791095022624, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint145, viewCenter145);
    
    NXOpen.Point3d scaleAboutPoint146 = new NXOpen.Point3d(128.03636579185482, -50.598563800904962, 0.0);
    NXOpen.Point3d viewCenter146 = new NXOpen.Point3d(-128.03636579185556, 50.598563800904962, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint146, viewCenter146);
    
    NXOpen.Point3d scaleAboutPoint147 = new NXOpen.Point3d(160.59544162895892, -62.698220361990948, 0.0);
    NXOpen.Point3d viewCenter147 = new NXOpen.Point3d(-160.59544162895949, 62.698220361990899, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint147, viewCenter147);
    
    NXOpen.Point3d origin25 = new NXOpen.Point3d(524.53596417580297, 290.46214132991707, 0.0);
    workPart.Views.WorkView.SetOrigin(origin25);
    
    NXOpen.Point3d origin26 = new NXOpen.Point3d(524.53596417580297, 290.46214132991707, 0.0);
    workPart.Views.WorkView.SetOrigin(origin26);
    
    NXOpen.Point3d scaleAboutPoint148 = new NXOpen.Point3d(221.36871662895919, -21.311895079185501, 0.0);
    NXOpen.Point3d viewCenter148 = new NXOpen.Point3d(-221.36871662895953, 21.311895079185444, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint148, viewCenter148);
    
    NXOpen.Point3d scaleAboutPoint149 = new NXOpen.Point3d(177.09497330316714, -17.049516063348442, 0.0);
    NXOpen.Point3d viewCenter149 = new NXOpen.Point3d(-177.09497330316768, 17.049516063348307, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint149, viewCenter149);
    
    NXOpen.Point3d scaleAboutPoint150 = new NXOpen.Point3d(141.67597864253372, -13.63961285067883, 0.0);
    NXOpen.Point3d viewCenter150 = new NXOpen.Point3d(-141.6759786425342, 13.63961285067861, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint150, viewCenter150);
    
    NXOpen.Point3d scaleAboutPoint151 = new NXOpen.Point3d(113.34078291402702, -10.911690280543096, 0.0);
    NXOpen.Point3d viewCenter151 = new NXOpen.Point3d(-113.34078291402743, 10.911690280542862, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint151, viewCenter151);
    
    NXOpen.Point3d scaleAboutPoint152 = new NXOpen.Point3d(99.401978555655901, -25.906464666063474, 0.0);
    NXOpen.Point3d viewCenter152 = new NXOpen.Point3d(-99.40197855565637, 25.90646466606324, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint152, viewCenter152);
    
    NXOpen.Point3d scaleAboutPoint153 = new NXOpen.Point3d(124.25247319456983, -32.383080832579303, 0.0);
    NXOpen.Point3d viewCenter153 = new NXOpen.Point3d(-124.25247319457036, 32.383080832579068, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint153, viewCenter153);
    
    NXOpen.Session.UndoMarkId markId38;
    markId38 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note9 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 30 1"));
    note9.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Note note10 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-6044"));
    note9.InsertIntoStack(note10, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    int nErrs30;
    nErrs30 = theSession.UpdateManager.DoUpdate(markId38);
    
    NXOpen.Point3d origin27 = new NXOpen.Point3d(582.59891610612124, 216.77413290412841, 0.0);
    workPart.Views.WorkView.SetOrigin(origin27);
    
    NXOpen.Point3d origin28 = new NXOpen.Point3d(582.59891610612124, 216.77413290412841, 0.0);
    workPart.Views.WorkView.SetOrigin(origin28);
    
    NXOpen.Point3d origin29 = new NXOpen.Point3d(581.27895357218529, 199.61461996295455, 0.0);
    workPart.Views.WorkView.SetOrigin(origin29);
    
    NXOpen.Point3d origin30 = new NXOpen.Point3d(581.27895357218529, 199.61461996295455, 0.0);
    workPart.Views.WorkView.SetOrigin(origin30);
    
    NXOpen.Session.UndoMarkId markId39;
    markId39 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Drawings.SectionView sectionView4 = ((NXOpen.Drawings.SectionView)workPart.DraftingViews.FindObject("SX@SECT-CC"));
    NXOpen.Point3d drawingReferencePoint7 = new NXOpen.Point3d(666.56539089617888, 263.08794088731582, 0.0);
    sectionView4.MoveView(drawingReferencePoint7);
    
    int nErrs31;
    nErrs31 = theSession.UpdateManager.DoUpdate(markId39);
    
    NXOpen.Point3d scaleAboutPoint154 = new NXOpen.Point3d(87.11752723981877, 65.998126696832458, 0.0);
    NXOpen.Point3d viewCenter154 = new NXOpen.Point3d(-87.117527239819253, -65.998126696832671, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint154, viewCenter154);
    
    NXOpen.Point3d scaleAboutPoint155 = new NXOpen.Point3d(68.990041773755507, 52.798501357465952, 0.0);
    NXOpen.Point3d viewCenter155 = new NXOpen.Point3d(-68.99004177375592, -52.798501357466186, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint155, viewCenter155);
    
    NXOpen.Point3d scaleAboutPoint156 = new NXOpen.Point3d(55.192033419004304, 42.238801085972732, 0.0);
    NXOpen.Point3d viewCenter156 = new NXOpen.Point3d(-55.192033419004773, -42.238801085972966, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint156, viewCenter156);
    
    NXOpen.Point3d scaleAboutPoint157 = new NXOpen.Point3d(41.675617071493008, -17.571341251764792, 0.0);
    NXOpen.Point3d viewCenter157 = new NXOpen.Point3d(-41.675617071493463, 17.571341251764604, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint157, viewCenter157);
    
    NXOpen.Point3d scaleAboutPoint158 = new NXOpen.Point3d(52.094521339366317, -21.964176564705969, 0.0);
    NXOpen.Point3d viewCenter158 = new NXOpen.Point3d(-52.094521339366786, 21.964176564705781, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint158, viewCenter158);
    
    NXOpen.Session.UndoMarkId markId40;
    markId40 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Point3d drawingReferencePoint8 = new NXOpen.Point3d(659.69791885005554, 264.49590092351497, 0.0);
    sectionView4.MoveView(drawingReferencePoint8);
    
    int nErrs32;
    nErrs32 = theSession.UpdateManager.DoUpdate(markId40);
    
    NXOpen.Point3d scaleAboutPoint159 = new NXOpen.Point3d(152.76366392760147, -2.4639300633485273, 0.0);
    NXOpen.Point3d viewCenter159 = new NXOpen.Point3d(-152.76366392760201, 2.4639300633482923, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint159, viewCenter159);
    
    NXOpen.Point3d scaleAboutPoint160 = new NXOpen.Point3d(122.21093114208122, -1.9711440506788225, 0.0);
    NXOpen.Point3d viewCenter160 = new NXOpen.Point3d(-122.21093114208169, 1.9711440506786346, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint160, viewCenter160);
    
    NXOpen.Point3d scaleAboutPoint161 = new NXOpen.Point3d(97.768744913664918, -1.5769152405430766, 0.0);
    NXOpen.Point3d viewCenter161 = new NXOpen.Point3d(-97.768744913665373, 1.5769152405428888, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint161, viewCenter161);
    
    NXOpen.Session.UndoMarkId markId41;
    markId41 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note11 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 31 1"));
    note11.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Label label3 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-164299"));
    note11.InsertIntoStack(label3, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    int nErrs33;
    nErrs33 = theSession.UpdateManager.DoUpdate(markId41);
    
    NXOpen.Point3d scaleAboutPoint162 = new NXOpen.Point3d(37.845965773031423, 39.287716850099422, 0.0);
    NXOpen.Point3d viewCenter162 = new NXOpen.Point3d(-37.845965773031899, -39.287716850099649, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint162, viewCenter162);
    
    NXOpen.Point3d scaleAboutPoint163 = new NXOpen.Point3d(40.999796254117406, 49.560193274207975, 0.0);
    NXOpen.Point3d viewCenter163 = new NXOpen.Point3d(-40.999796254117875, -49.560193274208238, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint163, viewCenter163);
    
    NXOpen.Point3d scaleAboutPoint164 = new NXOpen.Point3d(48.152233238008776, 62.513425607239668, 0.0);
    NXOpen.Point3d viewCenter164 = new NXOpen.Point3d(-48.152233238009195, -62.51342560723986, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint164, viewCenter164);
    
    NXOpen.Point3d scaleAboutPoint165 = new NXOpen.Point3d(59.838301538461351, 79.901732054298492, 0.0);
    NXOpen.Point3d viewCenter165 = new NXOpen.Point3d(-59.838301538461764, -79.901732054298691, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint165, viewCenter165);
    
    NXOpen.Point3d origin31 = new NXOpen.Point3d(620.89613307075774, 213.92653373092091, 0.0);
    workPart.Views.WorkView.SetOrigin(origin31);
    
    NXOpen.Point3d origin32 = new NXOpen.Point3d(620.89613307075774, 213.92653373092091, 0.0);
    workPart.Views.WorkView.SetOrigin(origin32);
    
    NXOpen.Session.UndoMarkId markId42;
    markId42 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Drawings.DetailView detailView1 = ((NXOpen.Drawings.DetailView)workPart.DraftingViews.FindObject("DETAIL@YY"));
    NXOpen.Point3d drawingReferencePoint9 = new NXOpen.Point3d(620.09904283195613, 149.28464259591388, 0.0);
    detailView1.MoveView(drawingReferencePoint9);
    
    int nErrs34;
    nErrs34 = theSession.UpdateManager.DoUpdate(markId42);
    
    NXOpen.Session.UndoMarkId markId43;
    markId43 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label4 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-201444"));
    label4.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin33 = new NXOpen.Point3d(597.64705619564597, 97.769830744495451, 0.0);
    label4.AnnotationOrigin = origin33;
    
    int nErrs35;
    nErrs35 = theSession.UpdateManager.DoUpdate(markId43);
    
    NXOpen.Point3d scaleAboutPoint166 = new NXOpen.Point3d(14.959575384615231, -62.47822660633485, 0.0);
    NXOpen.Point3d viewCenter166 = new NXOpen.Point3d(-14.959575384615636, 62.478226606334665, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint166, viewCenter166);
    
    NXOpen.Point3d scaleAboutPoint167 = new NXOpen.Point3d(14.431590371040539, -54.206461393665229, 0.0);
    NXOpen.Point3d viewCenter167 = new NXOpen.Point3d(-14.431590371040949, 54.206461393664995, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint167, viewCenter167);
    
    NXOpen.Point3d scaleAboutPoint168 = new NXOpen.Point3d(12.108456311311961, -46.46268119457018, 0.0);
    NXOpen.Point3d viewCenter168 = new NXOpen.Point3d(-12.108456311312432, 46.462681194569967, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint168, viewCenter168);
    
    NXOpen.Session.UndoMarkId markId44;
    markId44 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label5 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-166626"));
    label5.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin34 = new NXOpen.Point3d(654.42670133283912, 180.84651268042268, 0.0);
    label5.AnnotationOrigin = origin34;
    
    int nErrs36;
    nErrs36 = theSession.UpdateManager.DoUpdate(markId44);
    
    NXOpen.Session.UndoMarkId markId45;
    markId45 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Point3d drawingReferencePoint10 = new NXOpen.Point3d(616.94521235087007, 155.81757716387764, 0.0);
    detailView1.MoveView(drawingReferencePoint10);
    
    int nErrs37;
    nErrs37 = theSession.UpdateManager.DoUpdate(markId45);
    
    NXOpen.Point3d scaleAboutPoint169 = new NXOpen.Point3d(53.615118178461238, -45.505268369954777, 0.0);
    NXOpen.Point3d viewCenter169 = new NXOpen.Point3d(-53.615118178461763, 45.505268369954571, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint169, viewCenter169);
    
    NXOpen.Point3d scaleAboutPoint170 = new NXOpen.Point3d(61.668649585520072, -58.571137505882412, 0.0);
    NXOpen.Point3d viewCenter170 = new NXOpen.Point3d(-61.668649585520498, 58.571137505882177, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint170, viewCenter170);
    
    NXOpen.Point3d scaleAboutPoint171 = new NXOpen.Point3d(75.325861936651336, -74.269891909502363, 0.0);
    NXOpen.Point3d viewCenter171 = new NXOpen.Point3d(-75.325861936651748, 74.269891909502064, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint171, viewCenter171);
    
    NXOpen.Point3d scaleAboutPoint172 = new NXOpen.Point3d(92.837364886877452, -93.717339909502286, 0.0);
    NXOpen.Point3d viewCenter172 = new NXOpen.Point3d(-92.837364886877978, 93.717339909501987, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint172, viewCenter172);
    
    NXOpen.Point3d scaleAboutPoint173 = new NXOpen.Point3d(119.89659683257894, 31.899094570135585, 0.0);
    NXOpen.Point3d viewCenter173 = new NXOpen.Point3d(-119.89659683257935, -31.899094570135862, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint173, viewCenter173);
    
    NXOpen.Point3d scaleAboutPoint174 = new NXOpen.Point3d(96.357264977375138, 25.519275656108459, 0.0);
    NXOpen.Point3d viewCenter174 = new NXOpen.Point3d(-96.35726497737565, -25.519275656108679, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint174, viewCenter174);
    
    NXOpen.Session.UndoMarkId markId46;
    markId46 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Point3d drawingReferencePoint11 = new NXOpen.Point3d(659.69791885005554, 270.12774106831137, 0.0);
    sectionView4.MoveView(drawingReferencePoint11);
    
    int nErrs38;
    nErrs38 = theSession.UpdateManager.DoUpdate(markId46);
    
    NXOpen.Session.UndoMarkId markId47;
    markId47 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note12 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 19 1"));
    note12.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    note12.InsertIntoStack(label5, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    int nErrs39;
    nErrs39 = theSession.UpdateManager.DoUpdate(markId47);
    
    NXOpen.Point3d scaleAboutPoint175 = new NXOpen.Point3d(-17.247510443439069, -83.421632144796419, 0.0);
    NXOpen.Point3d viewCenter175 = new NXOpen.Point3d(17.247510443438657, 83.421632144796192, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint175, viewCenter175);
    
    NXOpen.Point3d scaleAboutPoint176 = new NXOpen.Point3d(-13.798008354751344, -66.737305715837124, 0.0);
    NXOpen.Point3d viewCenter176 = new NXOpen.Point3d(13.798008354750873, 66.737305715836911, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint176, viewCenter176);
    
    NXOpen.Point3d scaleAboutPoint177 = new NXOpen.Point3d(-11.038406683801114, -53.389844572669716, 0.0);
    NXOpen.Point3d viewCenter177 = new NXOpen.Point3d(11.0384066838007, 53.389844572669531, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint177, viewCenter177);
    
    NXOpen.Session.UndoMarkId markId48;
    markId48 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note12.InsertIntoStack(label5, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    label5.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin35 = new NXOpen.Point3d(654.98337353215118, 190.71120867904713, 0.0);
    label5.AnnotationOrigin = origin35;
    
    int nErrs40;
    nErrs40 = theSession.UpdateManager.DoUpdate(markId48);
    
    NXOpen.Point3d scaleAboutPoint178 = new NXOpen.Point3d(16.760356270913782, 1.6219699617012722, 0.0);
    NXOpen.Point3d viewCenter178 = new NXOpen.Point3d(-16.760356270914265, -1.6219699617014376, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint178, viewCenter178);
    
    NXOpen.Point3d scaleAboutPoint179 = new NXOpen.Point3d(20.9504453386423, 3.829651298461441, 0.0);
    NXOpen.Point3d viewCenter179 = new NXOpen.Point3d(-20.950445338642751, -3.8296512984616289, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint179, viewCenter179);
    
    NXOpen.Point3d scaleAboutPoint180 = new NXOpen.Point3d(26.188056673302917, 6.1950241592759205, 0.0);
    NXOpen.Point3d viewCenter180 = new NXOpen.Point3d(-26.188056673303389, -6.1950241592761079, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint180, viewCenter180);
    
    NXOpen.Point3d scaleAboutPoint181 = new NXOpen.Point3d(32.735070841628705, 10.911690280542873, 0.0);
    NXOpen.Point3d viewCenter181 = new NXOpen.Point3d(-32.735070841629174, -10.911690280543048, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint181, viewCenter181);
    
    NXOpen.Point3d scaleAboutPoint182 = new NXOpen.Point3d(39.59887601809929, 19.359450497737434, 0.0);
    NXOpen.Point3d viewCenter182 = new NXOpen.Point3d(-39.59887601809973, -19.35945049773758, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint182, viewCenter182);
    
    NXOpen.Point3d scaleAboutPoint183 = new NXOpen.Point3d(46.748673076922849, 37.94892285067862, 0.0);
    NXOpen.Point3d viewCenter183 = new NXOpen.Point3d(-46.748673076923261, -37.948922850678755, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint183, viewCenter183);
    
    NXOpen.Point3d origin36 = new NXOpen.Point3d(548.79788752083937, 243.43148025700373, 0.0);
    workPart.Views.WorkView.SetOrigin(origin36);
    
    NXOpen.Point3d origin37 = new NXOpen.Point3d(548.79788752083937, 243.43148025700373, 0.0);
    workPart.Views.WorkView.SetOrigin(origin37);
    
    NXOpen.Point3d scaleAboutPoint184 = new NXOpen.Point3d(228.93100197963724, -116.87168269230759, 0.0);
    NXOpen.Point3d viewCenter184 = new NXOpen.Point3d(-228.93100197963781, 116.87168269230742, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint184, viewCenter184);
    
    NXOpen.Point3d scaleAboutPoint185 = new NXOpen.Point3d(183.14480158370995, -93.497346153846053, 0.0);
    NXOpen.Point3d viewCenter185 = new NXOpen.Point3d(-183.14480158371032, 93.497346153845911, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint185, viewCenter185);
    
    NXOpen.Point3d scaleAboutPoint186 = new NXOpen.Point3d(146.51584126696775, -74.797876923076856, 0.0);
    NXOpen.Point3d viewCenter186 = new NXOpen.Point3d(-146.51584126696835, 74.7978769230767, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint186, viewCenter186);
    
    NXOpen.Point3d scaleAboutPoint187 = new NXOpen.Point3d(117.21267301357408, -59.838301538461479, 0.0);
    NXOpen.Point3d viewCenter187 = new NXOpen.Point3d(-117.21267301357479, 59.838301538461359, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint187, viewCenter187);
    
    NXOpen.Session.UndoMarkId markId49;
    markId49 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Drawings.ProjectedView projectedView2 = ((NXOpen.Drawings.ProjectedView)workPart.DraftingViews.FindObject("AUXIL@PI-RIGHT-VIEW"));
    NXOpen.Point3d drawingReferencePoint12 = new NXOpen.Point3d(780.7974638854181, 133.98635319608877, 0.0);
    projectedView2.MoveView(drawingReferencePoint12);
    
    int nErrs41;
    nErrs41 = theSession.UpdateManager.DoUpdate(markId49);
    
    NXOpen.Point3d scaleAboutPoint188 = new NXOpen.Point3d(129.25073132307628, -8.7293522244344093, 0.0);
    NXOpen.Point3d viewCenter188 = new NXOpen.Point3d(-129.25073132307699, 8.7293522244343151, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint188, viewCenter188);
    
    NXOpen.Point3d scaleAboutPoint189 = new NXOpen.Point3d(102.95003784687729, -6.983481779547529, 0.0);
    NXOpen.Point3d viewCenter189 = new NXOpen.Point3d(-102.95003784687798, 6.9834817795474535, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint189, viewCenter189);
    
    NXOpen.Point3d scaleAboutPoint190 = new NXOpen.Point3d(82.360030277501778, -5.5867854236380534, 0.0);
    NXOpen.Point3d viewCenter190 = new NXOpen.Point3d(-82.360030277502432, 5.5867854236379326, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint190, viewCenter190);
    
    NXOpen.Session.UndoMarkId markId50;
    markId50 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label6 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-81374"));
    label6.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin38 = new NXOpen.Point3d(807.15468408438971, 162.66470994052835, 0.0);
    label6.AnnotationOrigin = origin38;
    
    int nErrs42;
    nErrs42 = theSession.UpdateManager.DoUpdate(markId50);
    
    NXOpen.Session.UndoMarkId markId51;
    markId51 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note13 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 18 1"));
    note13.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Label label7 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-83063"));
    note13.InsertIntoStack(label7, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    int nErrs43;
    nErrs43 = theSession.UpdateManager.DoUpdate(markId51);
    
    NXOpen.Session.UndoMarkId markId52;
    markId52 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note14 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 14 1"));
    note14.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    note14.InsertIntoStack(label6, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    int nErrs44;
    nErrs44 = theSession.UpdateManager.DoUpdate(markId52);
    
    NXOpen.Session.UndoMarkId markId53;
    markId53 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note14.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin39 = new NXOpen.Point3d(812.47058498569686, 156.76222989320985, 0.0);
    note14.AnnotationOrigin = origin39;
    
    int nErrs45;
    nErrs45 = theSession.UpdateManager.DoUpdate(markId53);
    
    NXOpen.Session.UndoMarkId markId54;
    markId54 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Annotations.DraftingNoteBuilder draftingNoteBuilder1;
    draftingNoteBuilder1 = workPart.Annotations.CreateDraftingNoteBuilder(note14);
    
    draftingNoteBuilder1.Text.TextBlock.CustomSymbolScale = 1.0;
    
    draftingNoteBuilder1.Origin.SetInferRelativeToGeometry(true);
    
    theSession.SetUndoMarkName(markId54, "注释 对话框");
    
    draftingNoteBuilder1.Origin.SetInferRelativeToGeometry(true);
    
    NXOpen.Annotations.LeaderData leaderData2;
    leaderData2 = workPart.Annotations.CreateLeaderData();
    
    leaderData2.StubSize = 3.5000000103999995;
    
    leaderData2.Arrowhead = NXOpen.Annotations.LeaderData.ArrowheadType.FilledArrow;
    
    leaderData2.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Center;
    
    draftingNoteBuilder1.Leader.Leaders.Append(leaderData2);
    
    leaderData2.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Legacy;
    
    leaderData2.StubSide = NXOpen.Annotations.LeaderSide.Inferred;
    
    double symbolscale1;
    symbolscale1 = draftingNoteBuilder1.Text.TextBlock.SymbolScale;
    
    double symbolaspectratio1;
    symbolaspectratio1 = draftingNoteBuilder1.Text.TextBlock.SymbolAspectRatio;
    
    draftingNoteBuilder1.Origin.SetInferRelativeToGeometry(true);
    
    draftingNoteBuilder1.Origin.SetInferRelativeToGeometry(true);
    
    // ----------------------------------------------
    //   对话开始 注释
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId55;
    markId55 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.DeleteUndoMark(markId55, null);
    
    NXOpen.Session.UndoMarkId markId56;
    markId56 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId56, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId56, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId54, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId57;
    markId57 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId57, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId57, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId54, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId58;
    markId58 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    string[] text1 = new string[1];
    text1[0] = "<F34><C1.0>ID平台面<C><F>";
    draftingNoteBuilder1.Text.TextBlock.SetText(text1);
    
    theSession.SetUndoMarkName(markId58, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId58, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId54, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId59;
    markId59 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    NXOpen.Session.UndoMarkId markId60;
    markId60 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    NXOpen.NXObject nXObject3;
    nXObject3 = draftingNoteBuilder1.Commit();
    
    theSession.DeleteUndoMark(markId60, null);
    
    theSession.SetUndoMarkName(markId54, "注释");
    
    draftingNoteBuilder1.Destroy();
    
    theSession.DeleteUndoMark(markId59, null);
    
    theSession.SetUndoMarkVisibility(markId54, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.DeleteUndoMark(markId58, null);
    
    theSession.DeleteUndoMark(markId57, null);
    
    theSession.DeleteUndoMark(markId56, null);
    
    NXOpen.Session.UndoMarkId markId61;
    markId61 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label8 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-84658"));
    label8.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin40 = new NXOpen.Point3d(739.40860051205266, 175.40196621531209, 0.0);
    label8.AnnotationOrigin = origin40;
    
    int nErrs46;
    nErrs46 = theSession.UpdateManager.DoUpdate(markId61);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->复制(C)
    // ----------------------------------------------
    workPart.PmiManager.RestoreUnpastedObjects();
    
    // ----------------------------------------------
    //   菜单：编辑(E)->粘贴(P)
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId62;
    markId62 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder1;
    cutCopyPasteBuilder1 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder1.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder1.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation1 = new NXOpen.Point3d(746.87091097910877, 170.17051490994126, 0.0);
    cutCopyPasteBuilder1.SetDefaultToPoint(droplocation1);
    
    cutCopyPasteBuilder1.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects11 = new NXOpen.TaggedObject[1];
    NXOpen.Annotations.Note note15 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 17 1"));
    objects11[0] = note15;
    bool added1;
    added1 = cutCopyPasteBuilder1.ObjectsToCopy.Add(objects11);
    
    NXOpen.Point3d origin41 = new NXOpen.Point3d(746.87091097910877, 170.17051490994126, 0.0);
    NXOpen.Vector3d normal1 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane1;
    plane1 = workPart.Planes.CreatePlane(origin41, normal1, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder1.PlaneToRestrictMotion = plane1;
    
    cutCopyPasteBuilder1.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder1.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder1.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder1.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder1.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder1.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder1.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder1.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder1.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId62, "粘贴 对话框");
    
    cutCopyPasteBuilder1.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder1.Transform.SetMotionToTwoDimensions(plane1);
    
    cutCopyPasteBuilder1.InitPaste();
    
    cutCopyPasteBuilder1.CutCopyPasteLeader.IsLeaderSelection = false;
    
    NXOpen.Point3d coordinates4 = new NXOpen.Point3d(714.43151174508171, 146.81414746144156, 0.0);
    NXOpen.Point point4;
    point4 = workPart.Points.CreatePoint(coordinates4);
    
    NXOpen.Point3d point5 = new NXOpen.Point3d(714.43151174508171, 146.81414746144156, 0.0);
    cutCopyPasteBuilder1.CutCopyPasteLeader.Selection.SetValue(point4, workPart.Views.WorkView, point5);
    
    NXOpen.Session.UndoMarkId markId63;
    markId63 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "粘贴");
    
    NXOpen.Matrix3x3 rot1 = new NXOpen.Matrix3x3();
    rot1.Xx = 1.0;
    rot1.Xy = 0.0;
    rot1.Xz = 0.0;
    rot1.Yx = 0.0;
    rot1.Yy = 1.0;
    rot1.Yz = 0.0;
    rot1.Zx = 0.0;
    rot1.Zy = 0.0;
    rot1.Zz = 1.0;
    NXOpen.Vector3d trans1 = new NXOpen.Vector3d(-32.439399234027064, -23.356367448499697, 0.0);
    cutCopyPasteBuilder1.CutCopyPasteLeader.SetMoveOnCommit(rot1, trans1);
    
    NXOpen.NXObject nXObject4;
    nXObject4 = cutCopyPasteBuilder1.Commit();
    
    theSession.DeleteUndoMark(markId63, null);
    
    theSession.SetUndoMarkName(markId62, "粘贴");
    
    cutCopyPasteBuilder1.Destroy();
    
    workPart.Points.DeletePoint(point4);
    
    NXOpen.Session.UndoMarkId markId64;
    markId64 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Start");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder2;
    cutCopyPasteBuilder2 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder2.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder2.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation2 = new NXOpen.Point3d(746.87091097910877, 170.17051490994126, 0.0);
    cutCopyPasteBuilder2.SetDefaultToPoint(droplocation2);
    
    cutCopyPasteBuilder2.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects12 = new NXOpen.TaggedObject[1];
    objects12[0] = note15;
    bool added2;
    added2 = cutCopyPasteBuilder2.ObjectsToCopy.Add(objects12);
    
    NXOpen.Point3d origin42 = new NXOpen.Point3d(746.87091097910877, 170.17051490994126, 0.0);
    NXOpen.Vector3d normal2 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane2;
    plane2 = workPart.Planes.CreatePlane(origin42, normal2, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder2.PlaneToRestrictMotion = plane2;
    
    cutCopyPasteBuilder2.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder2.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder2.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder2.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder2.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder2.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder2.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder2.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder2.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId64, "粘贴 对话框");
    
    cutCopyPasteBuilder2.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder2.Transform.SetMotionToTwoDimensions(plane2);
    
    cutCopyPasteBuilder2.InitPaste();
    
    cutCopyPasteBuilder2.CutCopyPasteLeader.IsLeaderSelection = false;
    
    // ----------------------------------------------
    //   对话开始 粘贴
    // ----------------------------------------------
    cutCopyPasteBuilder2.Destroy();
    
    theSession.UndoToMark(markId64, null);
    
    theSession.DeleteUndoMark(markId64, null);
    
    int nErrs47;
    nErrs47 = theSession.UpdateManager.DoUpdate(markId62);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId65;
    markId65 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId66;
    markId66 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects13 = new NXOpen.TaggedObject[1];
    objects13[0] = note15;
    int nErrs48;
    nErrs48 = theSession.UpdateManager.AddObjectsToDeleteList(objects13);
    
    NXOpen.Session.UndoMarkId id10;
    id10 = theSession.NewestVisibleUndoMark;
    
    int nErrs49;
    nErrs49 = theSession.UpdateManager.DoUpdate(id10);
    
    theSession.DeleteUndoMark(markId65, null);
    
    NXOpen.Session.UndoMarkId markId67;
    markId67 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note16 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 1 1"));
    note16.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Label label9 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-84111"));
    note16.InsertIntoStack(label9, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    int nErrs50;
    nErrs50 = theSession.UpdateManager.DoUpdate(markId67);
    
    NXOpen.Session.UndoMarkId markId68;
    markId68 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note16.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin43 = new NXOpen.Point3d(721.9286173458346, 146.52579724602799, 0.0);
    note16.AnnotationOrigin = origin43;
    
    int nErrs51;
    nErrs51 = theSession.UpdateManager.DoUpdate(markId68);
    
    NXOpen.Point3d scaleAboutPoint191 = new NXOpen.Point3d(-12.254884155077253, 4.757778554323929, 0.0);
    NXOpen.Point3d viewCenter191 = new NXOpen.Point3d(12.254884155076555, -4.7577785543240365, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint191, viewCenter191);
    
    NXOpen.Point3d scaleAboutPoint192 = new NXOpen.Point3d(-12.074665270443738, 6.3076609621718731, 0.0);
    NXOpen.Point3d viewCenter192 = new NXOpen.Point3d(12.074665270443061, -6.307660962171993, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint192, viewCenter192);
    
    NXOpen.Point3d scaleAboutPoint193 = new NXOpen.Point3d(-1.5769152405433176, 5.1812929332126227, 0.0);
    NXOpen.Point3d viewCenter193 = new NXOpen.Point3d(1.5769152405426414, -5.1812929332127169, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint193, viewCenter193);
    
    NXOpen.Point3d scaleAboutPoint194 = new NXOpen.Point3d(10.982088282352549, 5.9134321520361253, 0.0);
    NXOpen.Point3d viewCenter194 = new NXOpen.Point3d(-10.982088282353253, -5.9134321520361954, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint194, viewCenter194);
    
    NXOpen.Point3d scaleAboutPoint195 = new NXOpen.Point3d(14.431590371040402, 7.3917901900451879, 0.0);
    NXOpen.Point3d viewCenter195 = new NXOpen.Point3d(-14.431590371041047, -7.3917901900452465, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint195, viewCenter195);
    
    NXOpen.Point3d origin44 = new NXOpen.Point3d(395.4440859438356, 166.30242630249168, 0.0);
    workPart.Views.WorkView.SetOrigin(origin44);
    
    NXOpen.Point3d origin45 = new NXOpen.Point3d(395.4440859438356, 166.30242630249168, 0.0);
    workPart.Views.WorkView.SetOrigin(origin45);
    
    NXOpen.Point3d scaleAboutPoint196 = new NXOpen.Point3d(116.5966904977369, -11.439675294117713, 0.0);
    NXOpen.Point3d viewCenter196 = new NXOpen.Point3d(-116.59669049773767, 11.439675294117567, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint196, viewCenter196);
    
    NXOpen.Point3d scaleAboutPoint197 = new NXOpen.Point3d(155.09559773755583, -9.8997190045249539, 0.0);
    NXOpen.Point3d viewCenter197 = new NXOpen.Point3d(-155.09559773755657, 9.8997190045247692, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint197, viewCenter197);
    
    NXOpen.Point3d origin46 = new NXOpen.Point3d(372.20724550266664, 379.94386226403526, 0.0);
    workPart.Views.WorkView.SetOrigin(origin46);
    
    NXOpen.Point3d origin47 = new NXOpen.Point3d(372.20724550266664, 379.94386226403526, 0.0);
    workPart.Views.WorkView.SetOrigin(origin47);
    
    NXOpen.Point3d scaleAboutPoint198 = new NXOpen.Point3d(-49.498595022624649, 141.62098020361947, 0.0);
    NXOpen.Point3d viewCenter198 = new NXOpen.Point3d(49.498595022623959, -141.62098020361969, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint198, viewCenter198);
    
    NXOpen.Point3d scaleAboutPoint199 = new NXOpen.Point3d(-39.048891628959595, 112.74679977375528, 0.0);
    NXOpen.Point3d viewCenter199 = new NXOpen.Point3d(39.048891628958771, -112.74679977375551, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint199, viewCenter199);
    
    NXOpen.Session.UndoMarkId markId69;
    markId69 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Drawings.DetailView detailView2 = ((NXOpen.Drawings.DetailView)workPart.DraftingViews.FindObject("DETAIL@DD"));
    NXOpen.Point3d drawingReferencePoint13 = new NXOpen.Point3d(241.37203837779347, 536.74885389978124, 0.0);
    detailView2.MoveView(drawingReferencePoint13);
    
    int nErrs52;
    nErrs52 = theSession.UpdateManager.DoUpdate(markId69);
    
    NXOpen.Session.UndoMarkId markId70;
    markId70 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label10 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-217325"));
    label10.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin48 = new NXOpen.Point3d(86.770261441592766, 481.75912798012786, 0.0);
    label10.AnnotationOrigin = origin48;
    
    int nErrs53;
    nErrs53 = theSession.UpdateManager.DoUpdate(markId70);
    
    NXOpen.Session.UndoMarkId markId71;
    markId71 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label11 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-216620"));
    label11.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin49 = new NXOpen.Point3d(186.7788205120504, 481.59483599036031, 0.0);
    label11.AnnotationOrigin = origin49;
    
    int nErrs54;
    nErrs54 = theSession.UpdateManager.DoUpdate(markId71);
    
    NXOpen.Session.UndoMarkId markId72;
    markId72 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label12 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-217173"));
    label12.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin50 = new NXOpen.Point3d(317.65428549601188, 482.3731861782565, 0.0);
    label12.AnnotationOrigin = origin50;
    
    int nErrs55;
    nErrs55 = theSession.UpdateManager.DoUpdate(markId72);
    
    NXOpen.Point3d scaleAboutPoint200 = new NXOpen.Point3d(-156.19556651583719, 30.799125791855062, 0.0);
    NXOpen.Point3d viewCenter200 = new NXOpen.Point3d(156.1955665158363, -30.799125791855211, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint200, viewCenter200);
    
    NXOpen.Point3d scaleAboutPoint201 = new NXOpen.Point3d(-124.9564532126698, 24.63930063348408, 0.0);
    NXOpen.Point3d viewCenter201 = new NXOpen.Point3d(124.95645321266898, -24.63930063348414, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint201, viewCenter201);
    
    NXOpen.Point3d scaleAboutPoint202 = new NXOpen.Point3d(-99.965162570135917, 19.711440506787238, 0.0);
    NXOpen.Point3d viewCenter202 = new NXOpen.Point3d(99.965162570135078, -19.711440506787355, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint202, viewCenter202);
    
    NXOpen.Point3d scaleAboutPoint203 = new NXOpen.Point3d(-79.972130056108838, 15.769152405429733, 0.0);
    NXOpen.Point3d viewCenter203 = new NXOpen.Point3d(79.972130056107943, -15.769152405429901, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint203, viewCenter203);
    
    NXOpen.Session.UndoMarkId markId73;
    markId73 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label13 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-216415"));
    label13.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin51 = new NXOpen.Point3d(227.22263727243984, 490.32872077234805, 0.0);
    label13.AnnotationOrigin = origin51;
    
    int nErrs56;
    nErrs56 = theSession.UpdateManager.DoUpdate(markId73);
    
    NXOpen.Session.UndoMarkId markId74;
    markId74 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.RadiusDimension radiusDimension1 = ((NXOpen.Annotations.RadiusDimension)workPart.FindObject("HANDLE R-523878"));
    radiusDimension1.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    radiusDimension1.IsOriginCentered = false;
    
    NXOpen.Point3d origin52;
    origin52 = radiusDimension1.AnnotationOrigin;
    
    NXOpen.Annotations.AngularDimensionUtils theAnnotationsAngularDimensionUtils = NXOpen.Annotations.AngularDimensionUtils.GetAngularDimensionUtils(theSession);
    
    NXOpen.Point3d location1 = new NXOpen.Point3d(232.9042075061418, 471.34836382157295, 0.0);
    bool changed1;
    changed1 = theAnnotationsAngularDimensionUtils.InferQuadrantAngleFromLocation(radiusDimension1, location1);
    
    NXOpen.Point3d origin53 = new NXOpen.Point3d(232.9042075061418, 471.34836382157295, 0.0);
    radiusDimension1.AnnotationOrigin = origin53;
    
    int nErrs57;
    nErrs57 = theSession.UpdateManager.DoUpdate(markId74);
    
    NXOpen.Session.UndoMarkId markId75;
    markId75 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    label13.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin54 = new NXOpen.Point3d(225.81445944190162, 486.92907875562958, 0.0);
    label13.AnnotationOrigin = origin54;
    
    int nErrs58;
    nErrs58 = theSession.UpdateManager.DoUpdate(markId75);
    
    NXOpen.Point3d scaleAboutPoint204 = new NXOpen.Point3d(-36.584433580597633, -0.5406566539005937, 0.0);
    NXOpen.Point3d viewCenter204 = new NXOpen.Point3d(36.58443358059673, 0.54065665390030815, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint204, viewCenter204);
    
    NXOpen.Point3d scaleAboutPoint205 = new NXOpen.Point3d(-51.362382120543295, -5.8571137505883257, 0.0);
    NXOpen.Point3d viewCenter205 = new NXOpen.Point3d(51.362382120542392, 5.8571137505881561, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint205, viewCenter205);
    
    NXOpen.Session.UndoMarkId markId76;
    markId76 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    label12.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin55 = new NXOpen.Point3d(316.1443304376499, 486.56382155411507, 0.0);
    label12.AnnotationOrigin = origin55;
    
    int nErrs59;
    nErrs59 = theSession.UpdateManager.DoUpdate(markId76);
    
    NXOpen.Session.UndoMarkId markId77;
    markId77 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    label11.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin56 = new NXOpen.Point3d(185.10141099768043, 485.64446078960594, 0.0);
    label11.AnnotationOrigin = origin56;
    
    int nErrs60;
    nErrs60 = theSession.UpdateManager.DoUpdate(markId77);
    
    NXOpen.Session.UndoMarkId markId78;
    markId78 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    label10.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin57 = new NXOpen.Point3d(88.881543354378181, 486.66242896217898, 0.0);
    label10.AnnotationOrigin = origin57;
    
    int nErrs61;
    nErrs61 = theSession.UpdateManager.DoUpdate(markId78);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->复制(C)
    // ----------------------------------------------
    workPart.PmiManager.RestoreUnpastedObjects();
    
    // ----------------------------------------------
    //   菜单：编辑(E)->粘贴(P)
    // ----------------------------------------------
    // ----------------------------------------------
    //   菜单：编辑(E)->复制(C)
    // ----------------------------------------------
    workPart.PmiManager.RestoreUnpastedObjects();
    
    // ----------------------------------------------
    //   菜单：编辑(E)->粘贴(P)
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId79;
    markId79 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder3;
    cutCopyPasteBuilder3 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder3.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder3.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation3 = new NXOpen.Point3d(284.26658962668472, 450.6006647281439, 0.0);
    cutCopyPasteBuilder3.SetDefaultToPoint(droplocation3);
    
    cutCopyPasteBuilder3.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects14 = new NXOpen.TaggedObject[1];
    NXOpen.Annotations.Note note17 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 41 1"));
    objects14[0] = note17;
    bool added3;
    added3 = cutCopyPasteBuilder3.ObjectsToCopy.Add(objects14);
    
    NXOpen.Point3d origin58 = new NXOpen.Point3d(284.26658962668472, 450.6006647281439, 0.0);
    NXOpen.Vector3d normal3 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane3;
    plane3 = workPart.Planes.CreatePlane(origin58, normal3, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder3.PlaneToRestrictMotion = plane3;
    
    cutCopyPasteBuilder3.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder3.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder3.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder3.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder3.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder3.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder3.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder3.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder3.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId79, "粘贴 对话框");
    
    cutCopyPasteBuilder3.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder3.Transform.SetMotionToTwoDimensions(plane3);
    
    cutCopyPasteBuilder3.InitPaste();
    
    cutCopyPasteBuilder3.CutCopyPasteLeader.IsLeaderSelection = false;
    
    NXOpen.Point3d coordinates5 = new NXOpen.Point3d(193.03077928098355, 553.1001553634369, 0.0);
    NXOpen.Point point6;
    point6 = workPart.Points.CreatePoint(coordinates5);
    
    NXOpen.Point3d point7 = new NXOpen.Point3d(193.03077928098355, 553.1001553634369, 0.0);
    cutCopyPasteBuilder3.CutCopyPasteLeader.Selection.SetValue(point6, workPart.Views.WorkView, point7);
    
    NXOpen.Session.UndoMarkId markId80;
    markId80 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "粘贴");
    
    NXOpen.Matrix3x3 rot2 = new NXOpen.Matrix3x3();
    rot2.Xx = 1.0;
    rot2.Xy = 0.0;
    rot2.Xz = 0.0;
    rot2.Yx = 0.0;
    rot2.Yy = 1.0;
    rot2.Yz = 0.0;
    rot2.Zx = 0.0;
    rot2.Zy = 0.0;
    rot2.Zz = 1.0;
    NXOpen.Vector3d trans2 = new NXOpen.Vector3d(-91.235810345701168, 102.499490635293, 0.0);
    cutCopyPasteBuilder3.CutCopyPasteLeader.SetMoveOnCommit(rot2, trans2);
    
    NXOpen.NXObject nXObject5;
    nXObject5 = cutCopyPasteBuilder3.Commit();
    
    theSession.DeleteUndoMark(markId80, null);
    
    theSession.SetUndoMarkName(markId79, "粘贴");
    
    cutCopyPasteBuilder3.Destroy();
    
    workPart.Points.DeletePoint(point6);
    
    NXOpen.Session.UndoMarkId markId81;
    markId81 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Start");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder4;
    cutCopyPasteBuilder4 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder4.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder4.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation4 = new NXOpen.Point3d(284.26658962668472, 450.6006647281439, 0.0);
    cutCopyPasteBuilder4.SetDefaultToPoint(droplocation4);
    
    cutCopyPasteBuilder4.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects15 = new NXOpen.TaggedObject[1];
    objects15[0] = note17;
    bool added4;
    added4 = cutCopyPasteBuilder4.ObjectsToCopy.Add(objects15);
    
    NXOpen.Point3d origin59 = new NXOpen.Point3d(284.26658962668472, 450.6006647281439, 0.0);
    NXOpen.Vector3d normal4 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane4;
    plane4 = workPart.Planes.CreatePlane(origin59, normal4, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder4.PlaneToRestrictMotion = plane4;
    
    cutCopyPasteBuilder4.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder4.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder4.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder4.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder4.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder4.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder4.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder4.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder4.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId81, "粘贴 对话框");
    
    cutCopyPasteBuilder4.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder4.Transform.SetMotionToTwoDimensions(plane4);
    
    cutCopyPasteBuilder4.InitPaste();
    
    cutCopyPasteBuilder4.CutCopyPasteLeader.IsLeaderSelection = false;
    
    // ----------------------------------------------
    //   对话开始 粘贴
    // ----------------------------------------------
    cutCopyPasteBuilder4.Destroy();
    
    theSession.UndoToMark(markId81, null);
    
    theSession.DeleteUndoMark(markId81, null);
    
    int nErrs62;
    nErrs62 = theSession.UpdateManager.DoUpdate(markId79);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId82;
    markId82 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId83;
    markId83 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects16 = new NXOpen.TaggedObject[1];
    objects16[0] = note17;
    int nErrs63;
    nErrs63 = theSession.UpdateManager.AddObjectsToDeleteList(objects16);
    
    NXOpen.Session.UndoMarkId id11;
    id11 = theSession.NewestVisibleUndoMark;
    
    int nErrs64;
    nErrs64 = theSession.UpdateManager.DoUpdate(id11);
    
    theSession.DeleteUndoMark(markId82, null);
    
    NXOpen.Session.UndoMarkId markId84;
    markId84 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note18 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 1 1"));
    note18.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.HorizontalDimension horizontalDimension1 = ((NXOpen.Annotations.HorizontalDimension)workPart.FindObject("HANDLE R-215759"));
    note18.InsertIntoStack(horizontalDimension1, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    int nErrs65;
    nErrs65 = theSession.UpdateManager.DoUpdate(markId84);
    
    NXOpen.Point3d scaleAboutPoint206 = new NXOpen.Point3d(-99.120386548416505, 116.01590698280501, 0.0);
    NXOpen.Point3d viewCenter206 = new NXOpen.Point3d(99.12038654841561, -116.01590698280529, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint206, viewCenter206);
    
    NXOpen.Point3d scaleAboutPoint207 = new NXOpen.Point3d(-80.422677267692535, 93.037999192035898, 0.0);
    NXOpen.Point3d viewCenter207 = new NXOpen.Point3d(80.422677267691711, -93.037999192036068, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint207, viewCenter207);
    
    NXOpen.Point3d scaleAboutPoint208 = new NXOpen.Point3d(-64.338141814154085, 74.610618238262177, 0.0);
    NXOpen.Point3d viewCenter208 = new NXOpen.Point3d(64.338141814153289, -74.610618238262376, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint208, viewCenter208);
    
    NXOpen.Point3d scaleAboutPoint209 = new NXOpen.Point3d(-51.470513451323384, 59.6884945906097, 0.0);
    NXOpen.Point3d viewCenter209 = new NXOpen.Point3d(51.470513451322518, -59.68849459060992, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint209, viewCenter209);
    
    NXOpen.Point3d scaleAboutPoint210 = new NXOpen.Point3d(-41.176410761058797, 47.750795672487726, 0.0);
    NXOpen.Point3d viewCenter210 = new NXOpen.Point3d(41.17641076105793, -47.750795672487961, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint210, viewCenter210);
    
    NXOpen.Session.UndoMarkId markId85;
    markId85 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Annotations.DraftingNoteBuilder draftingNoteBuilder2;
    draftingNoteBuilder2 = workPart.Annotations.CreateDraftingNoteBuilder(note18);
    
    draftingNoteBuilder2.Text.TextBlock.CustomSymbolScale = 1.0;
    
    draftingNoteBuilder2.Origin.SetInferRelativeToGeometry(true);
    
    theSession.SetUndoMarkName(markId85, "注释 对话框");
    
    draftingNoteBuilder2.Origin.SetInferRelativeToGeometry(true);
    
    NXOpen.Annotations.LeaderData leaderData3;
    leaderData3 = workPart.Annotations.CreateLeaderData();
    
    leaderData3.StubSize = 3.5000000103999995;
    
    leaderData3.Arrowhead = NXOpen.Annotations.LeaderData.ArrowheadType.FilledArrow;
    
    leaderData3.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Center;
    
    draftingNoteBuilder2.Leader.Leaders.Append(leaderData3);
    
    leaderData3.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Legacy;
    
    leaderData3.StubSide = NXOpen.Annotations.LeaderSide.Inferred;
    
    double symbolscale2;
    symbolscale2 = draftingNoteBuilder2.Text.TextBlock.SymbolScale;
    
    double symbolaspectratio2;
    symbolaspectratio2 = draftingNoteBuilder2.Text.TextBlock.SymbolAspectRatio;
    
    draftingNoteBuilder2.Origin.SetInferRelativeToGeometry(true);
    
    draftingNoteBuilder2.Origin.SetInferRelativeToGeometry(true);
    
    NXOpen.Session.UndoMarkId markId86;
    markId86 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.DeleteUndoMark(markId86, null);
    
    NXOpen.Session.UndoMarkId markId87;
    markId87 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.DeleteUndoMark(markId87, null);
    
    NXOpen.Session.UndoMarkId markId88;
    markId88 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    draftingNoteBuilder2.Destroy();
    
    theSession.UndoToMark(markId85, null);
    
    theSession.DeleteUndoMark(markId85, null);
    
    NXOpen.Session.UndoMarkId markId89;
    markId89 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Annotations.DraftingNoteBuilder draftingNoteBuilder3;
    draftingNoteBuilder3 = workPart.Annotations.CreateDraftingNoteBuilder(note18);
    
    draftingNoteBuilder3.Text.TextBlock.CustomSymbolScale = 1.0;
    
    draftingNoteBuilder3.Origin.SetInferRelativeToGeometry(true);
    
    theSession.SetUndoMarkName(markId89, "注释 对话框");
    
    draftingNoteBuilder3.Origin.SetInferRelativeToGeometry(true);
    
    NXOpen.Annotations.LeaderData leaderData4;
    leaderData4 = workPart.Annotations.CreateLeaderData();
    
    leaderData4.StubSize = 3.5000000103999995;
    
    leaderData4.Arrowhead = NXOpen.Annotations.LeaderData.ArrowheadType.FilledArrow;
    
    leaderData4.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Center;
    
    draftingNoteBuilder3.Leader.Leaders.Append(leaderData4);
    
    leaderData4.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Legacy;
    
    leaderData4.StubSide = NXOpen.Annotations.LeaderSide.Inferred;
    
    double symbolscale3;
    symbolscale3 = draftingNoteBuilder3.Text.TextBlock.SymbolScale;
    
    double symbolaspectratio3;
    symbolaspectratio3 = draftingNoteBuilder3.Text.TextBlock.SymbolAspectRatio;
    
    draftingNoteBuilder3.Origin.SetInferRelativeToGeometry(true);
    
    draftingNoteBuilder3.Origin.SetInferRelativeToGeometry(true);
    
    // ----------------------------------------------
    //   对话开始 注释
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId90;
    markId90 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.DeleteUndoMark(markId90, null);
    
    NXOpen.Session.UndoMarkId markId91;
    markId91 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    draftingNoteBuilder3.Destroy();
    
    theSession.UndoToMark(markId89, null);
    
    theSession.DeleteUndoMark(markId89, null);
    
    NXOpen.Session.UndoMarkId markId92;
    markId92 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note18.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin60 = new NXOpen.Point3d(201.36698400859004, 555.94941592949249, 0.0);
    note18.AnnotationOrigin = origin60;
    
    int nErrs66;
    nErrs66 = theSession.UpdateManager.DoUpdate(markId92);
    
    NXOpen.Point3d scaleAboutPoint211 = new NXOpen.Point3d(-18.454413786469157, 15.040347235971902, 0.0);
    NXOpen.Point3d viewCenter211 = new NXOpen.Point3d(18.454413786468297, -15.040347235972133, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint211, viewCenter211);
    
    NXOpen.Point3d scaleAboutPoint212 = new NXOpen.Point3d(-23.068017233086316, 18.800434044964906, 0.0);
    NXOpen.Point3d viewCenter212 = new NXOpen.Point3d(23.068017233085495, -18.800434044965137, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint212, viewCenter212);
    
    NXOpen.Point3d scaleAboutPoint213 = new NXOpen.Point3d(-28.690846433651011, 23.500542556206181, 0.0);
    NXOpen.Point3d viewCenter213 = new NXOpen.Point3d(28.690846433650169, -23.500542556206362, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint213, viewCenter213);
    
    NXOpen.Point3d scaleAboutPoint214 = new NXOpen.Point3d(-35.863558042063666, 29.37567819525772, 0.0);
    NXOpen.Point3d viewCenter214 = new NXOpen.Point3d(35.86355804206282, -29.375678195257944, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint214, viewCenter214);
    
    NXOpen.Point3d scaleAboutPoint215 = new NXOpen.Point3d(-44.829447552579495, 36.719597744072175, 0.0);
    NXOpen.Point3d viewCenter215 = new NXOpen.Point3d(44.829447552578593, -36.719597744072402, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint215, viewCenter215);
    
    NXOpen.Point3d scaleAboutPoint216 = new NXOpen.Point3d(-56.036809440724269, 46.181089187330045, 0.0);
    NXOpen.Point3d viewCenter216 = new NXOpen.Point3d(56.036809440723324, -46.181089187330322, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint216, viewCenter216);
    
    NXOpen.Session.UndoMarkId markId93;
    markId93 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label14 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-221054"));
    label14.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin61 = new NXOpen.Point3d(321.84722814681459, 461.42571477989884, 0.0);
    label14.AnnotationOrigin = origin61;
    
    int nErrs67;
    nErrs67 = theSession.UpdateManager.DoUpdate(markId93);
    
    NXOpen.Point3d scaleAboutPoint217 = new NXOpen.Point3d(106.65297274208071, -23.231340597285111, 0.0);
    NXOpen.Point3d viewCenter217 = new NXOpen.Point3d(-106.65297274208166, 23.231340597284877, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint217, viewCenter217);
    
    NXOpen.Session.UndoMarkId markId94;
    markId94 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note19 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 13 1"));
    note19.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin62 = new NXOpen.Point3d(310.30195584998199, 478.67322522333751, 0.0);
    note19.AnnotationOrigin = origin62;
    
    int nErrs68;
    nErrs68 = theSession.UpdateManager.DoUpdate(markId94);
    
    NXOpen.Point3d scaleAboutPoint218 = new NXOpen.Point3d(-37.170144955656419, -32.10148882533948, 0.0);
    NXOpen.Point3d viewCenter218 = new NXOpen.Point3d(37.170144955655616, 32.101488825339082, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint218, viewCenter218);
    
    NXOpen.Point3d scaleAboutPoint219 = new NXOpen.Point3d(-43.998751131221958, -38.014920977375638, 0.0);
    NXOpen.Point3d viewCenter219 = new NXOpen.Point3d(43.998751131221248, 38.014920977375283, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint219, viewCenter219);
    
    NXOpen.Session.UndoMarkId markId95;
    markId95 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note20 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 35 1"));
    note20.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Note note21 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-214214"));
    note20.InsertIntoStack(note21, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    int nErrs69;
    nErrs69 = theSession.UpdateManager.DoUpdate(markId95);
    
    NXOpen.Point3d origin63 = new NXOpen.Point3d(310.3195553504346, 377.86328663149902, 0.0);
    workPart.Views.WorkView.SetOrigin(origin63);
    
    NXOpen.Point3d origin64 = new NXOpen.Point3d(310.3195553504346, 377.86328663149902, 0.0);
    workPart.Views.WorkView.SetOrigin(origin64);
    
    NXOpen.Session.UndoMarkId markId96;
    markId96 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note22 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 40 1"));
    note22.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Note note23 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-341610"));
    note22.InsertIntoStack(note23, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    int nErrs70;
    nErrs70 = theSession.UpdateManager.DoUpdate(markId96);
    
    NXOpen.Session.UndoMarkId markId97;
    markId97 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note24 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 41 1"));
    note24.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Note note25 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-341646"));
    note24.InsertIntoStack(note25, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    int nErrs71;
    nErrs71 = theSession.UpdateManager.DoUpdate(markId97);
    
    NXOpen.Session.UndoMarkId markId98;
    markId98 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Drawings.DetailView detailView3 = ((NXOpen.Drawings.DetailView)workPart.DraftingViews.FindObject("DETAIL@EE"));
    NXOpen.Point3d drawingReferencePoint14 = new NXOpen.Point3d(266.97046848658943, 361.55771734444312, 0.0);
    detailView3.MoveView(drawingReferencePoint14);
    
    int nErrs72;
    nErrs72 = theSession.UpdateManager.DoUpdate(markId98);
    
    NXOpen.Session.UndoMarkId markId99;
    markId99 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Point3d drawingReferencePoint15 = new NXOpen.Point3d(266.97046848658943, 377.83725526299503, 0.0);
    detailView3.MoveView(drawingReferencePoint15);
    
    int nErrs73;
    nErrs73 = theSession.UpdateManager.DoUpdate(markId99);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->撤消
    // ----------------------------------------------
    bool marksRecycled1;
    bool undoUnavailable1;
    theSession.UndoLastNVisibleMarks(1, out marksRecycled1, out undoUnavailable1);
    
    NXOpen.Session.UndoMarkId markId100;
    markId100 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note24.InsertIntoStack(note25, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    note25.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin65 = new NXOpen.Point3d(135.20452584817269, 448.70127595276438, 0.0);
    note25.AnnotationOrigin = origin65;
    
    int nErrs74;
    nErrs74 = theSession.UpdateManager.DoUpdate(markId100);
    
    NXOpen.Session.UndoMarkId markId101;
    markId101 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note22.InsertIntoStack(note23, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    note23.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin66 = new NXOpen.Point3d(277.76047951333067, 447.38131341882769, 0.0);
    note23.AnnotationOrigin = origin66;
    
    int nErrs75;
    nErrs75 = theSession.UpdateManager.DoUpdate(markId101);
    
    NXOpen.Session.UndoMarkId markId102;
    markId102 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label15 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-225184"));
    label15.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin67 = new NXOpen.Point3d(82.943754490729361, 375.61382447784746, 0.0);
    label15.AnnotationOrigin = origin67;
    
    int nErrs76;
    nErrs76 = theSession.UpdateManager.DoUpdate(markId102);
    
    NXOpen.Session.UndoMarkId markId103;
    markId103 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label16 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-224652"));
    label16.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin68 = new NXOpen.Point3d(184.45418929563272, 376.34908886579507, 0.0);
    label16.AnnotationOrigin = origin68;
    
    int nErrs77;
    nErrs77 = theSession.UpdateManager.DoUpdate(markId103);
    
    NXOpen.Point3d scaleAboutPoint220 = new NXOpen.Point3d(-64.2381766515838, -34.319025882353024, 0.0);
    NXOpen.Point3d viewCenter220 = new NXOpen.Point3d(64.238176651583146, 34.319025882352619, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint220, viewCenter220);
    
    NXOpen.Point3d scaleAboutPoint221 = new NXOpen.Point3d(-53.502481375565793, -28.511190733031867, 0.0);
    NXOpen.Point3d viewCenter221 = new NXOpen.Point3d(53.50248137556509, 28.51119073303137, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint221, viewCenter221);
    
    NXOpen.Point3d scaleAboutPoint222 = new NXOpen.Point3d(-44.773129151131371, -23.935320615384782, 0.0);
    NXOpen.Point3d viewCenter222 = new NXOpen.Point3d(44.773129151130782, 23.935320615384335, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint222, viewCenter222);
    
    NXOpen.Session.UndoMarkId markId104;
    markId104 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label17 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-224789"));
    label17.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin69 = new NXOpen.Point3d(225.69051848220471, 375.77195547503885, 0.0);
    label17.AnnotationOrigin = origin69;
    
    int nErrs78;
    nErrs78 = theSession.UpdateManager.DoUpdate(markId104);
    
    NXOpen.Session.UndoMarkId markId105;
    markId105 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label18 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-225333"));
    label18.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin70 = new NXOpen.Point3d(326.88998605344807, 376.69935953643665, 0.0);
    label18.AnnotationOrigin = origin70;
    
    int nErrs79;
    nErrs79 = theSession.UpdateManager.DoUpdate(markId105);
    
    NXOpen.Point3d scaleAboutPoint223 = new NXOpen.Point3d(18.472435674931777, 1.8021888463346047, 0.0);
    NXOpen.Point3d viewCenter223 = new NXOpen.Point3d(-18.472435674932399, -1.8021888463350555, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint223, viewCenter223);
    
    NXOpen.Point3d scaleAboutPoint224 = new NXOpen.Point3d(25.343280651583328, 2.2527360579183258, 0.0);
    NXOpen.Point3d viewCenter224 = new NXOpen.Point3d(-25.343280651583889, -2.2527360579187721, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint224, viewCenter224);
    
    NXOpen.Point3d scaleAboutPoint225 = new NXOpen.Point3d(32.031090823529084, 2.8159200723979376, 0.0);
    NXOpen.Point3d viewCenter225 = new NXOpen.Point3d(-32.031090823529702, -2.8159200723983782, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint225, viewCenter225);
    
    NXOpen.Point3d scaleAboutPoint226 = new NXOpen.Point3d(-116.5966904977375, -8.3597627149323532, 0.0);
    NXOpen.Point3d viewCenter226 = new NXOpen.Point3d(116.59669049773684, 8.3597627149318026, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint226, viewCenter226);
    
    NXOpen.Point3d scaleAboutPoint227 = new NXOpen.Point3d(-93.277352398190118, -6.3358201628962023, 0.0);
    NXOpen.Point3d viewCenter227 = new NXOpen.Point3d(93.277352398189407, 6.3358201628956152, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint227, viewCenter227);
    
    NXOpen.Point3d scaleAboutPoint228 = new NXOpen.Point3d(-74.62188191855212, -4.7870641230771955, 0.0);
    NXOpen.Point3d viewCenter228 = new NXOpen.Point3d(74.621881918551523, 4.7870641230766324, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint228, viewCenter228);
    
    NXOpen.Session.UndoMarkId markId106;
    markId106 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label19 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-411231"));
    label19.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin71 = new NXOpen.Point3d(152.17044428437191, 360.30250508000449, 0.0);
    label19.AnnotationOrigin = origin71;
    
    int nErrs80;
    nErrs80 = theSession.UpdateManager.DoUpdate(markId106);
    
    NXOpen.Session.UndoMarkId markId107;
    markId107 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note26 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 34 1"));
    note26.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Note note27 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-222822"));
    note26.InsertIntoStack(note27, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    int nErrs81;
    nErrs81 = theSession.UpdateManager.DoUpdate(markId107);
    
    NXOpen.Point3d scaleAboutPoint229 = new NXOpen.Point3d(-10.81313307800932, -41.900890677285254, 0.0);
    NXOpen.Point3d viewCenter229 = new NXOpen.Point3d(10.813133078008681, 41.900890677284686, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint229, viewCenter229);
    
    NXOpen.Point3d scaleAboutPoint230 = new NXOpen.Point3d(-15.205968390950554, -52.376113346606481, 0.0);
    NXOpen.Point3d viewCenter230 = new NXOpen.Point3d(15.205968390949851, 52.376113346605912, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint230, viewCenter230);
    
    NXOpen.Session.UndoMarkId markId108;
    markId108 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label20 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-223611"));
    label20.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin72 = new NXOpen.Point3d(301.38604892075148, 333.13095334083215, 0.0);
    label20.AnnotationOrigin = origin72;
    
    int nErrs82;
    nErrs82 = theSession.UpdateManager.DoUpdate(markId108);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->撤消
    // ----------------------------------------------
    bool marksRecycled2;
    bool undoUnavailable2;
    theSession.UndoLastNVisibleMarks(1, out marksRecycled2, out undoUnavailable2);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->复制(C)
    // ----------------------------------------------
    workPart.PmiManager.RestoreUnpastedObjects();
    
    // ----------------------------------------------
    //   菜单：编辑(E)->复制(C)
    // ----------------------------------------------
    workPart.PmiManager.RestoreUnpastedObjects();
    
    // ----------------------------------------------
    //   菜单：编辑(E)->复制(C)
    // ----------------------------------------------
    workPart.PmiManager.RestoreUnpastedObjects();
    
    // ----------------------------------------------
    //   菜单：编辑(E)->粘贴(P)
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId109;
    markId109 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder5;
    cutCopyPasteBuilder5 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder5.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder5.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation5 = new NXOpen.Point3d(208.46068653161149, 378.46518954697427, 0.0);
    cutCopyPasteBuilder5.SetDefaultToPoint(droplocation5);
    
    cutCopyPasteBuilder5.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects17 = new NXOpen.TaggedObject[1];
    NXOpen.Annotations.Note note28 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 14 1"));
    objects17[0] = note28;
    bool added5;
    added5 = cutCopyPasteBuilder5.ObjectsToCopy.Add(objects17);
    
    NXOpen.Point3d origin73 = new NXOpen.Point3d(208.46068653161149, 378.46518954697427, 0.0);
    NXOpen.Vector3d normal5 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane5;
    plane5 = workPart.Planes.CreatePlane(origin73, normal5, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder5.PlaneToRestrictMotion = plane5;
    
    cutCopyPasteBuilder5.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder5.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder5.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder5.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder5.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder5.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder5.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder5.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder5.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId109, "粘贴 对话框");
    
    cutCopyPasteBuilder5.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder5.Transform.SetMotionToTwoDimensions(plane5);
    
    cutCopyPasteBuilder5.InitPaste();
    
    cutCopyPasteBuilder5.CutCopyPasteLeader.IsLeaderSelection = false;
    
    NXOpen.Point3d coordinates6 = new NXOpen.Point3d(285.89848852256148, 368.96145930262895, 0.0);
    NXOpen.Point point8;
    point8 = workPart.Points.CreatePoint(coordinates6);
    
    NXOpen.Point3d point9 = new NXOpen.Point3d(285.89848852256148, 368.96145930262895, 0.0);
    cutCopyPasteBuilder5.CutCopyPasteLeader.Selection.SetValue(point8, workPart.Views.WorkView, point9);
    
    NXOpen.Session.UndoMarkId markId110;
    markId110 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "粘贴");
    
    NXOpen.Matrix3x3 rot3 = new NXOpen.Matrix3x3();
    rot3.Xx = 1.0;
    rot3.Xy = 0.0;
    rot3.Xz = 0.0;
    rot3.Yx = 0.0;
    rot3.Yy = 1.0;
    rot3.Yz = 0.0;
    rot3.Zx = 0.0;
    rot3.Zy = 0.0;
    rot3.Zz = 1.0;
    NXOpen.Vector3d trans3 = new NXOpen.Vector3d(77.437801990949993, -9.50373024434532, 0.0);
    cutCopyPasteBuilder5.CutCopyPasteLeader.SetMoveOnCommit(rot3, trans3);
    
    NXOpen.NXObject nXObject6;
    nXObject6 = cutCopyPasteBuilder5.Commit();
    
    theSession.DeleteUndoMark(markId110, null);
    
    theSession.SetUndoMarkName(markId109, "粘贴");
    
    cutCopyPasteBuilder5.Destroy();
    
    workPart.Points.DeletePoint(point8);
    
    NXOpen.Session.UndoMarkId markId111;
    markId111 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Start");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder6;
    cutCopyPasteBuilder6 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder6.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder6.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation6 = new NXOpen.Point3d(208.46068653161149, 378.46518954697427, 0.0);
    cutCopyPasteBuilder6.SetDefaultToPoint(droplocation6);
    
    cutCopyPasteBuilder6.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects18 = new NXOpen.TaggedObject[1];
    objects18[0] = note28;
    bool added6;
    added6 = cutCopyPasteBuilder6.ObjectsToCopy.Add(objects18);
    
    NXOpen.Point3d origin74 = new NXOpen.Point3d(208.46068653161149, 378.46518954697427, 0.0);
    NXOpen.Vector3d normal6 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane6;
    plane6 = workPart.Planes.CreatePlane(origin74, normal6, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder6.PlaneToRestrictMotion = plane6;
    
    cutCopyPasteBuilder6.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder6.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder6.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder6.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder6.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder6.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder6.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder6.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder6.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId111, "粘贴 对话框");
    
    cutCopyPasteBuilder6.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder6.Transform.SetMotionToTwoDimensions(plane6);
    
    cutCopyPasteBuilder6.InitPaste();
    
    cutCopyPasteBuilder6.CutCopyPasteLeader.IsLeaderSelection = false;
    
    // ----------------------------------------------
    //   对话开始 粘贴
    // ----------------------------------------------
    cutCopyPasteBuilder6.Destroy();
    
    theSession.UndoToMark(markId111, null);
    
    theSession.DeleteUndoMark(markId111, null);
    
    int nErrs83;
    nErrs83 = theSession.UpdateManager.DoUpdate(markId109);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId112;
    markId112 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId113;
    markId113 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects19 = new NXOpen.TaggedObject[1];
    objects19[0] = note28;
    int nErrs84;
    nErrs84 = theSession.UpdateManager.AddObjectsToDeleteList(objects19);
    
    NXOpen.Session.UndoMarkId id12;
    id12 = theSession.NewestVisibleUndoMark;
    
    int nErrs85;
    nErrs85 = theSession.UpdateManager.DoUpdate(id12);
    
    theSession.DeleteUndoMark(markId112, null);
    
    NXOpen.Session.UndoMarkId markId114;
    markId114 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    label20.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin75 = new NXOpen.Point3d(305.60992902934879, 349.60200880489157, 0.0);
    label20.AnnotationOrigin = origin75;
    
    int nErrs86;
    nErrs86 = theSession.UpdateManager.DoUpdate(markId114);
    
    NXOpen.Point3d origin76 = new NXOpen.Point3d(218.31640678500884, 291.17166730263904, 0.0);
    workPart.Views.WorkView.SetOrigin(origin76);
    
    NXOpen.Point3d origin77 = new NXOpen.Point3d(218.31640678500884, 291.17166730263904, 0.0);
    workPart.Views.WorkView.SetOrigin(origin77);
    
    NXOpen.Point3d scaleAboutPoint231 = new NXOpen.Point3d(30.975120796379677, 6.6878101719454115, 0.0);
    NXOpen.Point3d viewCenter231 = new NXOpen.Point3d(-30.975120796380384, -6.6878101719459684, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint231, viewCenter231);
    
    NXOpen.Point3d scaleAboutPoint232 = new NXOpen.Point3d(37.398938461538002, 7.9197752036195901, 0.0);
    NXOpen.Point3d viewCenter232 = new NXOpen.Point3d(-37.398938461538734, -7.9197752036201408, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint232, viewCenter232);
    
    NXOpen.Session.UndoMarkId markId115;
    markId115 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Drawings.DetailView detailView4 = ((NXOpen.Drawings.DetailView)workPart.DraftingViews.FindObject("DETAIL@ZZ"));
    NXOpen.Point3d drawingReferencePoint16 = new NXOpen.Point3d(106.89042509011442, 305.00558738118758, 0.0);
    detailView4.MoveView(drawingReferencePoint16);
    
    int nErrs87;
    nErrs87 = theSession.UpdateManager.DoUpdate(markId115);
    
    NXOpen.Point3d scaleAboutPoint233 = new NXOpen.Point3d(-52.248516968325895, 39.598876018099091, 0.0);
    NXOpen.Point3d viewCenter233 = new NXOpen.Point3d(52.248516968325347, -39.598876018099688, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint233, viewCenter233);
    
    NXOpen.Point3d scaleAboutPoint234 = new NXOpen.Point3d(-41.798813574660734, 31.679100814479217, 0.0);
    NXOpen.Point3d viewCenter234 = new NXOpen.Point3d(41.798813574660223, -31.679100814479838, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint234, viewCenter234);
    
    NXOpen.Point3d scaleAboutPoint235 = new NXOpen.Point3d(-33.439050859728653, 25.343280651583289, 0.0);
    NXOpen.Point3d viewCenter235 = new NXOpen.Point3d(33.439050859728184, -25.343280651583992, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint235, viewCenter235);
    
    NXOpen.Point3d scaleAboutPoint236 = new NXOpen.Point3d(-26.751240687782971, 20.27462452126656, 0.0);
    NXOpen.Point3d viewCenter236 = new NXOpen.Point3d(26.751240687782502, -20.274624521267242, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint236, viewCenter236);
    
    NXOpen.Session.UndoMarkId markId116;
    markId116 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.ParallelDimension parallelDimension1 = ((NXOpen.Annotations.ParallelDimension)workPart.FindObject("HANDLE R-133776"));
    parallelDimension1.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    parallelDimension1.IsOriginCentered = false;
    
    NXOpen.Point3d origin78;
    origin78 = parallelDimension1.AnnotationOrigin;
    
    NXOpen.Point3d location2 = new NXOpen.Point3d(180.06213260147959, 330.49775106372351, 0.0);
    bool changed2;
    changed2 = theAnnotationsAngularDimensionUtils.InferQuadrantAngleFromLocation(parallelDimension1, location2);
    
    NXOpen.Point3d origin79 = new NXOpen.Point3d(180.06213260147959, 330.49775106372351, 0.0);
    parallelDimension1.AnnotationOrigin = origin79;
    
    int nErrs88;
    nErrs88 = theSession.UpdateManager.DoUpdate(markId116);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->撤消
    // ----------------------------------------------
    bool marksRecycled3;
    bool undoUnavailable3;
    theSession.UndoLastNVisibleMarks(1, out marksRecycled3, out undoUnavailable3);
    
    NXOpen.Session.UndoMarkId markId117;
    markId117 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Point3d drawingReferencePoint17 = new NXOpen.Point3d(106.89042509011442, 300.7253888711424, 0.0);
    detailView4.MoveView(drawingReferencePoint17);
    
    int nErrs89;
    nErrs89 = theSession.UpdateManager.DoUpdate(markId117);
    
    NXOpen.Point3d scaleAboutPoint237 = new NXOpen.Point3d(13.516416347511049, 12.39004831855166, 0.0);
    NXOpen.Point3d viewCenter237 = new NXOpen.Point3d(-13.5164163475115, -12.390048318552337, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint237, viewCenter237);
    
    NXOpen.Point3d scaleAboutPoint238 = new NXOpen.Point3d(16.613928427149116, 16.332336419909115, 0.0);
    NXOpen.Point3d viewCenter238 = new NXOpen.Point3d(-16.613928427149538, -16.332336419909794, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint238, viewCenter238);
    
    NXOpen.Point3d scaleAboutPoint239 = new NXOpen.Point3d(-51.742531330316822, -94.68531243438926, 0.0);
    NXOpen.Point3d viewCenter239 = new NXOpen.Point3d(51.742531330316353, 94.685312434388564, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint239, viewCenter239);
    
    NXOpen.Point3d scaleAboutPoint240 = new NXOpen.Point3d(-41.112433057013732, -74.621881918552191, 0.0);
    NXOpen.Point3d viewCenter240 = new NXOpen.Point3d(41.11243305701317, 74.621881918551509, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint240, viewCenter240);
    
    NXOpen.Session.UndoMarkId markId118;
    markId118 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note29 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 33 1"));
    note29.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Note note30 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-129497"));
    note29.InsertIntoStack(note30, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    int nErrs90;
    nErrs90 = theSession.UpdateManager.DoUpdate(markId118);
    
    NXOpen.Session.UndoMarkId markId119;
    markId119 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note31 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 6 1"));
    note31.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Label label21 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-225643"));
    note31.InsertIntoStack(label21, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    int nErrs91;
    nErrs91 = theSession.UpdateManager.DoUpdate(markId119);
    
    NXOpen.Session.UndoMarkId markId120;
    markId120 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note32 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 17 1"));
    note32.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Label label22 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-132704"));
    note32.InsertIntoStack(label22, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    int nErrs92;
    nErrs92 = theSession.UpdateManager.DoUpdate(markId120);
    
    NXOpen.Point3d scaleAboutPoint241 = new NXOpen.Point3d(19.82407730968292, 19.373530098099135, 0.0);
    NXOpen.Point3d viewCenter241 = new NXOpen.Point3d(-19.824077309683485, -19.373530098099828, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint241, viewCenter241);
    
    NXOpen.Point3d scaleAboutPoint242 = new NXOpen.Point3d(26.751240687782467, 32.664672839818557, 0.0);
    NXOpen.Point3d viewCenter242 = new NXOpen.Point3d(-26.751240687782985, -32.664672839819232, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint242, viewCenter242);
    
    NXOpen.Point3d scaleAboutPoint243 = new NXOpen.Point3d(41.53482106787289, 58.782331511311725, 0.0);
    NXOpen.Point3d viewCenter243 = new NXOpen.Point3d(-41.534821067873473, -58.7823315113124, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint243, viewCenter243);
    
    NXOpen.Point3d scaleAboutPoint244 = new NXOpen.Point3d(53.238488868777914, 76.117839457013019, 0.0);
    NXOpen.Point3d viewCenter244 = new NXOpen.Point3d(-53.238488868778354, -76.117839457013687, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint244, viewCenter244);
    
    NXOpen.Point3d origin80 = new NXOpen.Point3d(279.979776520418, 226.97220955205219, 0.0);
    workPart.Views.WorkView.SetOrigin(origin80);
    
    NXOpen.Point3d origin81 = new NXOpen.Point3d(279.979776520418, 226.97220955205219, 0.0);
    workPart.Views.WorkView.SetOrigin(origin81);
    
    NXOpen.Point3d origin82 = new NXOpen.Point3d(487.32389122630741, 334.21916543441461, 0.0);
    workPart.Views.WorkView.SetOrigin(origin82);
    
    NXOpen.Point3d origin83 = new NXOpen.Point3d(487.32389122630741, 334.21916543441461, 0.0);
    workPart.Views.WorkView.SetOrigin(origin83);
    
    NXOpen.Point3d origin84 = new NXOpen.Point3d(474.67425027608584, 389.21760434845015, 0.0);
    workPart.Views.WorkView.SetOrigin(origin84);
    
    NXOpen.Point3d origin85 = new NXOpen.Point3d(474.67425027608584, 389.21760434845015, 0.0);
    workPart.Views.WorkView.SetOrigin(origin85);
    
    NXOpen.Point3d origin86 = new NXOpen.Point3d(470.27437516296413, 444.21604326248428, 0.0);
    workPart.Views.WorkView.SetOrigin(origin86);
    
    NXOpen.Point3d origin87 = new NXOpen.Point3d(470.27437516296413, 444.21604326248428, 0.0);
    workPart.Views.WorkView.SetOrigin(origin87);
    
    NXOpen.Point3d scaleAboutPoint245 = new NXOpen.Point3d(54.998438914026842, 91.847392986424694, 0.0);
    NXOpen.Point3d viewCenter245 = new NXOpen.Point3d(-54.998438914027204, -91.847392986425419, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint245, viewCenter245);
    
    NXOpen.Point3d scaleAboutPoint246 = new NXOpen.Point3d(42.678788597284736, 73.477914389139684, 0.0);
    NXOpen.Point3d viewCenter246 = new NXOpen.Point3d(-42.678788597285035, -73.477914389140381, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint246, viewCenter246);
    
    NXOpen.Session.UndoMarkId markId121;
    markId121 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Drawings.ProjectedView projectedView3 = ((NXOpen.Drawings.ProjectedView)workPart.DraftingViews.FindObject("ORTHO@POSITION-VIEW"));
    NXOpen.Point3d drawingReferencePoint18 = new NXOpen.Point3d(496.6457309666327, 501.74406666260046, 0.0);
    projectedView3.MoveView(drawingReferencePoint18);
    
    int nErrs93;
    nErrs93 = theSession.UpdateManager.DoUpdate(markId121);
    
    NXOpen.Session.UndoMarkId markId122;
    markId122 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Point3d drawingReferencePoint19 = new NXOpen.Point3d(496.6457309666327, 494.35227647255527, 0.0);
    projectedView3.MoveView(drawingReferencePoint19);
    
    int nErrs94;
    nErrs94 = theSession.UpdateManager.DoUpdate(markId122);
    
    NXOpen.Point3d scaleAboutPoint247 = new NXOpen.Point3d(51.390541321266738, 57.022381466062861, 0.0);
    NXOpen.Point3d viewCenter247 = new NXOpen.Point3d(-51.390541321266973, -57.022381466063536, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint247, viewCenter247);
    
    NXOpen.Point3d scaleAboutPoint248 = new NXOpen.Point3d(39.14128900633461, 47.307457216289066, 0.0);
    NXOpen.Point3d viewCenter248 = new NXOpen.Point3d(-39.141289006334894, -47.307457216289819, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint248, viewCenter248);
    
    NXOpen.Point3d scaleAboutPoint249 = new NXOpen.Point3d(31.087757599275829, 38.071239378823044, 0.0);
    NXOpen.Point3d viewCenter249 = new NXOpen.Point3d(-31.087757599276053, -38.07123937882379, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint249, viewCenter249);
    
    NXOpen.Point3d scaleAboutPoint250 = new NXOpen.Point3d(24.689987194787133, 30.637210387691901, 0.0);
    NXOpen.Point3d viewCenter250 = new NXOpen.Point3d(-24.689987194787371, -30.637210387692534, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint250, viewCenter250);
    
    NXOpen.Point3d scaleAboutPoint251 = new NXOpen.Point3d(19.75198975582968, 24.798118525567006, 0.0);
    NXOpen.Point3d viewCenter251 = new NXOpen.Point3d(-19.751989755829921, -24.798118525567691, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint251, viewCenter251);
    
    NXOpen.Session.UndoMarkId markId123;
    markId123 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note33 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 27 1"));
    note33.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.MinorAngularDimension minorAngularDimension1 = ((NXOpen.Annotations.MinorAngularDimension)workPart.FindObject("HANDLE R-193284"));
    note33.InsertIntoStack(minorAngularDimension1, NXOpen.Annotations.StackAlignmentPosition.Right);
    
    int nErrs95;
    nErrs95 = theSession.UpdateManager.DoUpdate(markId123);
    
    NXOpen.Point3d scaleAboutPoint252 = new NXOpen.Point3d(45.213313776848317, 9.8039073240611749, 0.0);
    NXOpen.Point3d viewCenter252 = new NXOpen.Point3d(-45.213313776848473, -9.8039073240618482, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint252, viewCenter252);
    
    NXOpen.Point3d scaleAboutPoint253 = new NXOpen.Point3d(57.093342651887497, 13.264109909024057, 0.0);
    NXOpen.Point3d viewCenter253 = new NXOpen.Point3d(-57.093342651887738, -13.264109909024741, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint253, viewCenter253);
    
    NXOpen.Session.UndoMarkId markId124;
    markId124 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label23 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-195583"));
    label23.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin88 = new NXOpen.Point3d(568.63192896376722, 532.34721021096152, 0.0);
    label23.AnnotationOrigin = origin88;
    
    int nErrs96;
    nErrs96 = theSession.UpdateManager.DoUpdate(markId124);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->复制(C)
    // ----------------------------------------------
    workPart.PmiManager.RestoreUnpastedObjects();
    
    // ----------------------------------------------
    //   菜单：编辑(E)->粘贴(P)
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId125;
    markId125 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder7;
    cutCopyPasteBuilder7 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder7.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder7.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation7 = new NXOpen.Point3d(497.44546953354114, 511.08138182421322, 0.0);
    cutCopyPasteBuilder7.SetDefaultToPoint(droplocation7);
    
    cutCopyPasteBuilder7.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects20 = new NXOpen.TaggedObject[1];
    NXOpen.Annotations.Note note34 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 26 1"));
    objects20[0] = note34;
    bool added7;
    added7 = cutCopyPasteBuilder7.ObjectsToCopy.Add(objects20);
    
    NXOpen.Point3d origin89 = new NXOpen.Point3d(497.44546953354114, 511.08138182421322, 0.0);
    NXOpen.Vector3d normal7 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane7;
    plane7 = workPart.Planes.CreatePlane(origin89, normal7, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder7.PlaneToRestrictMotion = plane7;
    
    cutCopyPasteBuilder7.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder7.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder7.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder7.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder7.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder7.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder7.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder7.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder7.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId125, "粘贴 对话框");
    
    cutCopyPasteBuilder7.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder7.Transform.SetMotionToTwoDimensions(plane7);
    
    cutCopyPasteBuilder7.InitPaste();
    
    cutCopyPasteBuilder7.CutCopyPasteLeader.IsLeaderSelection = false;
    
    NXOpen.Point3d coordinates7 = new NXOpen.Point3d(545.92434949994833, 525.67911147952259, 0.0);
    NXOpen.Point point10;
    point10 = workPart.Points.CreatePoint(coordinates7);
    
    NXOpen.Point3d point11 = new NXOpen.Point3d(545.92434949994833, 525.67911147952259, 0.0);
    cutCopyPasteBuilder7.CutCopyPasteLeader.Selection.SetValue(point10, workPart.Views.WorkView, point11);
    
    NXOpen.Session.UndoMarkId markId126;
    markId126 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "粘贴");
    
    NXOpen.Matrix3x3 rot4 = new NXOpen.Matrix3x3();
    rot4.Xx = 1.0;
    rot4.Xy = 0.0;
    rot4.Xz = 0.0;
    rot4.Yx = 0.0;
    rot4.Yy = 1.0;
    rot4.Yz = 0.0;
    rot4.Zx = 0.0;
    rot4.Zy = 0.0;
    rot4.Zz = 1.0;
    NXOpen.Vector3d trans4 = new NXOpen.Vector3d(48.478879966407192, 14.597729655309365, 0.0);
    cutCopyPasteBuilder7.CutCopyPasteLeader.SetMoveOnCommit(rot4, trans4);
    
    NXOpen.NXObject nXObject7;
    nXObject7 = cutCopyPasteBuilder7.Commit();
    
    theSession.DeleteUndoMark(markId126, null);
    
    theSession.SetUndoMarkName(markId125, "粘贴");
    
    cutCopyPasteBuilder7.Destroy();
    
    workPart.Points.DeletePoint(point10);
    
    NXOpen.Session.UndoMarkId markId127;
    markId127 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Start");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder8;
    cutCopyPasteBuilder8 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder8.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder8.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation8 = new NXOpen.Point3d(497.44546953354114, 511.08138182421322, 0.0);
    cutCopyPasteBuilder8.SetDefaultToPoint(droplocation8);
    
    cutCopyPasteBuilder8.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects21 = new NXOpen.TaggedObject[1];
    objects21[0] = note34;
    bool added8;
    added8 = cutCopyPasteBuilder8.ObjectsToCopy.Add(objects21);
    
    NXOpen.Point3d origin90 = new NXOpen.Point3d(497.44546953354114, 511.08138182421322, 0.0);
    NXOpen.Vector3d normal8 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane8;
    plane8 = workPart.Planes.CreatePlane(origin90, normal8, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder8.PlaneToRestrictMotion = plane8;
    
    cutCopyPasteBuilder8.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder8.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder8.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder8.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder8.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder8.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder8.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder8.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder8.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId127, "粘贴 对话框");
    
    cutCopyPasteBuilder8.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder8.Transform.SetMotionToTwoDimensions(plane8);
    
    cutCopyPasteBuilder8.InitPaste();
    
    cutCopyPasteBuilder8.CutCopyPasteLeader.IsLeaderSelection = false;
    
    // ----------------------------------------------
    //   对话开始 粘贴
    // ----------------------------------------------
    cutCopyPasteBuilder8.Destroy();
    
    theSession.UndoToMark(markId127, null);
    
    theSession.DeleteUndoMark(markId127, null);
    
    int nErrs97;
    nErrs97 = theSession.UpdateManager.DoUpdate(markId125);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId128;
    markId128 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId129;
    markId129 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects22 = new NXOpen.TaggedObject[1];
    objects22[0] = note34;
    int nErrs98;
    nErrs98 = theSession.UpdateManager.AddObjectsToDeleteList(objects22);
    
    NXOpen.Session.UndoMarkId id13;
    id13 = theSession.NewestVisibleUndoMark;
    
    int nErrs99;
    nErrs99 = theSession.UpdateManager.DoUpdate(id13);
    
    theSession.DeleteUndoMark(markId128, null);
    
    NXOpen.Session.UndoMarkId markId130;
    markId130 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note35 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 1 1"));
    note35.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    note35.InsertIntoStack(label23, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    int nErrs100;
    nErrs100 = theSession.UpdateManager.DoUpdate(markId130);
    
    NXOpen.Session.UndoMarkId markId131;
    markId131 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.IdSymbol idSymbol1 = ((NXOpen.Annotations.IdSymbol)workPart.FindObject("HANDLE R-775579"));
    idSymbol1.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin91 = new NXOpen.Point3d(560.88251692452741, 497.20452770743236, 0.0);
    idSymbol1.AnnotationOrigin = origin91;
    
    int nErrs101;
    nErrs101 = theSession.UpdateManager.DoUpdate(markId131);
    
    NXOpen.Session.UndoMarkId markId132;
    markId132 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.TargetPoint targetPoint1 = ((NXOpen.Annotations.TargetPoint)workPart.Annotations.TargetPoints.FindObject("HANDLE R-750952"));
    targetPoint1.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin92 = new NXOpen.Point3d(528.26289880586694, 508.73853632397527, 0.0);
    targetPoint1.AnnotationOrigin = origin92;
    
    int nErrs102;
    nErrs102 = theSession.UpdateManager.DoUpdate(markId132);
    
    NXOpen.Point3d scaleAboutPoint254 = new NXOpen.Point3d(38.747060196198866, 2.8835021541353965, 0.0);
    NXOpen.Point3d viewCenter254 = new NXOpen.Point3d(-38.747060196199108, -2.8835021541360879, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint254, viewCenter254);
    
    NXOpen.Point3d scaleAboutPoint255 = new NXOpen.Point3d(30.853473049252273, 2.1626266156014604, 0.0);
    NXOpen.Point3d viewCenter255 = new NXOpen.Point3d(-30.853473049252511, -2.1626266156021456, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint255, viewCenter255);
    
    NXOpen.Point3d scaleAboutPoint256 = new NXOpen.Point3d(24.336758180905537, 1.4994211201502459, 0.0);
    NXOpen.Point3d viewCenter256 = new NXOpen.Point3d(-24.336758180905768, -1.4994211201509191, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint256, viewCenter256);
    
    NXOpen.Point3d scaleAboutPoint257 = new NXOpen.Point3d(19.284862406859709, 1.0149927582554426, 0.0);
    NXOpen.Point3d viewCenter257 = new NXOpen.Point3d(-19.28486240685994, -1.0149927582561196, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint257, viewCenter257);
    
    NXOpen.Point3d scaleAboutPoint258 = new NXOpen.Point3d(15.28025461519595, 0.66435889631256284, 0.0);
    NXOpen.Point3d viewCenter258 = new NXOpen.Point3d(-15.280254615196233, -0.66435889631318445, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint258, viewCenter258);
    
    NXOpen.Point3d scaleAboutPoint259 = new NXOpen.Point3d(12.047041319806709, 0.35432474469985992, 0.0);
    NXOpen.Point3d viewCenter259 = new NXOpen.Point3d(-12.047041319806887, -0.35432474470053943, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint259, viewCenter259);
    
    NXOpen.Point3d scaleAboutPoint260 = new NXOpen.Point3d(9.3069299607918037, 0.094486598586375842, 0.0);
    NXOpen.Point3d viewCenter260 = new NXOpen.Point3d(-9.3069299607920275, -0.094486598587061238, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint260, viewCenter260);
    
    NXOpen.Point3d scaleAboutPoint261 = new NXOpen.Point3d(1.3228123802139693, -6.1983208672891692, 0.0);
    NXOpen.Point3d viewCenter261 = new NXOpen.Point3d(-1.322812380214196, 6.1983208672884889, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint261, viewCenter261);
    
    NXOpen.Point3d scaleAboutPoint262 = new NXOpen.Point3d(1.0582499041711242, -4.9586566938313164, 0.0);
    NXOpen.Point3d viewCenter262 = new NXOpen.Point3d(-1.0582499041714091, 4.9586566938308048, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint262, viewCenter262);
    
    NXOpen.Point3d scaleAboutPoint263 = new NXOpen.Point3d(0.82241135409869837, -3.9669253550651371, 0.0);
    NXOpen.Point3d viewCenter263 = new NXOpen.Point3d(-0.82241135409892629, 3.9669253550645682, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint263, viewCenter263);
    
    NXOpen.Point3d scaleAboutPoint264 = new NXOpen.Point3d(0.63857822788837448, -3.1735402840521663, 0.0);
    NXOpen.Point3d viewCenter264 = new NXOpen.Point3d(-0.63857822788860363, 3.1735402840515965, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint264, viewCenter264);
    
    NXOpen.Point3d scaleAboutPoint265 = new NXOpen.Point3d(0.47990121368578231, -2.5233515429293516, 0.0);
    NXOpen.Point3d viewCenter265 = new NXOpen.Point3d(-0.47990121368601074, 2.5233515429287836, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint265, viewCenter265);
    
    NXOpen.Session.UndoMarkId markId133;
    markId133 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    targetPoint1.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin93 = new NXOpen.Point3d(528.33067428515494, 508.32996721942726, 0.0);
    targetPoint1.AnnotationOrigin = origin93;
    
    int nErrs103;
    nErrs103 = theSession.UpdateManager.DoUpdate(markId133);
    
    NXOpen.Point3d scaleAboutPoint266 = new NXOpen.Point3d(2.0186812343431315, 1.5480684312445347, 0.0);
    NXOpen.Point3d viewCenter266 = new NXOpen.Point3d(-2.0186812343433598, -1.5480684312451027, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint266, viewCenter266);
    
    NXOpen.Point3d scaleAboutPoint267 = new NXOpen.Point3d(2.5233515429289306, 1.9505662233681784, 0.0);
    NXOpen.Point3d viewCenter267 = new NXOpen.Point3d(-2.523351542929158, -1.9505662233687464, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint267, viewCenter267);
    
    NXOpen.Point3d scaleAboutPoint268 = new NXOpen.Point3d(3.1541894286611867, 2.4382077792102894, 0.0);
    NXOpen.Point3d viewCenter268 = new NXOpen.Point3d(-3.1541894286614141, -2.4382077792108592, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint268, viewCenter268);
    
    NXOpen.Point3d scaleAboutPoint269 = new NXOpen.Point3d(3.9185482165883152, 3.0477597240129368, 0.0);
    NXOpen.Point3d viewCenter269 = new NXOpen.Point3d(-3.9185482165885412, -3.0477597240135057, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint269, viewCenter269);
    
    NXOpen.Point3d scaleAboutPoint270 = new NXOpen.Point3d(4.8679495591876663, 3.8399353665639895, 0.0);
    NXOpen.Point3d viewCenter270 = new NXOpen.Point3d(-4.8679495591878901, -3.8399353665645566, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint270, viewCenter270);
    
    NXOpen.Point3d scaleAboutPoint271 = new NXOpen.Point3d(6.0093476701152282, 4.7999192082051367, 0.0);
    NXOpen.Point3d viewCenter271 = new NXOpen.Point3d(-6.0093476701154582, -4.7999192082055337, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint271, viewCenter271);
    
    NXOpen.Point3d scaleAboutPoint272 = new NXOpen.Point3d(5.0077897250960106, 8.0313608798709382, 0.0);
    NXOpen.Point3d viewCenter272 = new NXOpen.Point3d(-5.0077897250962353, -8.0313608798713361, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint272, viewCenter272);
    
    NXOpen.Point3d scaleAboutPoint273 = new NXOpen.Point3d(5.6101417910863427, 10.039201099838721, 0.0);
    NXOpen.Point3d viewCenter273 = new NXOpen.Point3d(-5.610141791086579, -10.03920109983912, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint273, viewCenter273);
    
    NXOpen.Point3d scaleAboutPoint274 = new NXOpen.Point3d(6.5697713079827089, 12.401366064506645, 0.0);
    NXOpen.Point3d viewCenter274 = new NXOpen.Point3d(-6.5697713079829372, -12.401366064507156, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint274, viewCenter274);
    
    NXOpen.Point3d scaleAboutPoint275 = new NXOpen.Point3d(7.9353979281814153, 15.317163442768681, 0.0);
    NXOpen.Point3d viewCenter275 = new NXOpen.Point3d(-7.9353979281816001, -15.317163442769189, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint275, viewCenter275);
    
    NXOpen.Point3d scaleAboutPoint276 = new NXOpen.Point3d(9.8039073240613277, 19.03111421729551, 0.0);
    NXOpen.Point3d viewCenter276 = new NXOpen.Point3d(-9.8039073240615586, -19.031114217295961, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint276, viewCenter276);
    
    NXOpen.Point3d scaleAboutPoint277 = new NXOpen.Point3d(12.110709047369911, 23.788892771619352, 0.0);
    NXOpen.Point3d viewCenter277 = new NXOpen.Point3d(-12.110709047370127, -23.788892771619974, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint277, viewCenter277);
    
    NXOpen.Point3d scaleAboutPoint278 = new NXOpen.Point3d(14.958167424578921, 29.555897079890837, 0.0);
    NXOpen.Point3d viewCenter278 = new NXOpen.Point3d(-14.958167424579161, -29.555897079891349, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint278, viewCenter278);
    
    NXOpen.Point3d scaleAboutPoint279 = new NXOpen.Point3d(18.697709280723682, 36.944871349863625, 0.0);
    NXOpen.Point3d viewCenter279 = new NXOpen.Point3d(-18.697709280723906, -36.94487134986408, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint279, viewCenter279);
    
    NXOpen.Session.UndoMarkId markId134;
    markId134 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note36 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 28 1"));
    note36.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin94 = new NXOpen.Point3d(419.13348658214306, 500.66738544853791, 0.0);
    note36.AnnotationOrigin = origin94;
    
    int nErrs104;
    nErrs104 = theSession.UpdateManager.DoUpdate(markId134);
    
    NXOpen.Session.UndoMarkId markId135;
    markId135 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note33.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin95 = new NXOpen.Point3d(535.71257757942692, 538.68230642591345, 0.0);
    note33.AnnotationOrigin = origin95;
    
    int nErrs105;
    nErrs105 = theSession.UpdateManager.DoUpdate(markId135);
    
    NXOpen.Point3d scaleAboutPoint280 = new NXOpen.Point3d(58.007953491401963, 49.841785281447208, 0.0);
    NXOpen.Point3d viewCenter280 = new NXOpen.Point3d(-58.007953491402198, -49.841785281447606, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint280, viewCenter280);
    
    NXOpen.Point3d scaleAboutPoint281 = new NXOpen.Point3d(75.67785194570051, 67.934071746605369, 0.0);
    NXOpen.Point3d viewCenter281 = new NXOpen.Point3d(-75.677851945700681, -67.934071746605838, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint281, viewCenter281);
    
    NXOpen.Point3d origin96 = new NXOpen.Point3d(456.30363153780132, 395.10558173451648, 0.0);
    workPart.Views.WorkView.SetOrigin(origin96);
    
    NXOpen.Point3d origin97 = new NXOpen.Point3d(456.30363153780132, 395.10558173451648, 0.0);
    workPart.Views.WorkView.SetOrigin(origin97);
    
    NXOpen.Session.UndoMarkId markId136;
    markId136 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Drawings.ProjectedView projectedView4 = ((NXOpen.Drawings.ProjectedView)workPart.DraftingViews.FindObject("ORTHO@ML-TOP"));
    NXOpen.Point3d drawingReferencePoint20 = new NXOpen.Point3d(496.6457309666327, 374.1348518361724, 0.0);
    projectedView4.MoveView(drawingReferencePoint20);
    
    int nErrs106;
    nErrs106 = theSession.UpdateManager.DoUpdate(markId136);
    
    NXOpen.Session.UndoMarkId markId137;
    markId137 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Point3d drawingReferencePoint21 = new NXOpen.Point3d(496.6457309666327, 364.80526260813724, 0.0);
    projectedView4.MoveView(drawingReferencePoint21);
    
    int nErrs107;
    nErrs107 = theSession.UpdateManager.DoUpdate(markId137);
    
    NXOpen.Point3d scaleAboutPoint282 = new NXOpen.Point3d(-56.318401447963303, 40.03886352941111, 0.0);
    NXOpen.Point3d viewCenter282 = new NXOpen.Point3d(56.318401447963012, -40.038863529411515, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint282, viewCenter282);
    
    NXOpen.Point3d scaleAboutPoint283 = new NXOpen.Point3d(-45.054721158370597, 32.031090823528835, 0.0);
    NXOpen.Point3d viewCenter283 = new NXOpen.Point3d(45.054721158370484, -32.031090823529304, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint283, viewCenter283);
    
    NXOpen.Point3d scaleAboutPoint284 = new NXOpen.Point3d(9.2925362389138648, -22.245768571945685, 0.0);
    NXOpen.Point3d viewCenter284 = new NXOpen.Point3d(-9.2925362389140531, 22.245768571945284, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint284, viewCenter284);
    
    NXOpen.Point3d scaleAboutPoint285 = new NXOpen.Point3d(11.263680289592534, -26.399250678732951, 0.0);
    NXOpen.Point3d viewCenter285 = new NXOpen.Point3d(-11.26368028959277, 26.399250678732571, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint285, viewCenter285);
    
    NXOpen.Point3d scaleAboutPoint286 = new NXOpen.Point3d(14.079600361990744, -29.919150769230715, 0.0);
    NXOpen.Point3d viewCenter286 = new NXOpen.Point3d(-14.079600361990927, 29.919150769230239, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint286, viewCenter286);
    
    NXOpen.Session.UndoMarkId markId138;
    markId138 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.IdSymbol idSymbol2 = ((NXOpen.Annotations.IdSymbol)workPart.FindObject("HANDLE R-780826"));
    idSymbol2.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin98 = new NXOpen.Point3d(446.06952202467937, 315.31384655804965, 0.0);
    idSymbol2.AnnotationOrigin = origin98;
    
    int nErrs108;
    nErrs108 = theSession.UpdateManager.DoUpdate(markId138);
    
    NXOpen.Session.UndoMarkId markId139;
    markId139 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    idSymbol2.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin99 = new NXOpen.Point3d(429.02000596133115, 332.36336262139804, 0.0);
    idSymbol2.AnnotationOrigin = origin99;
    
    int nErrs109;
    nErrs109 = theSession.UpdateManager.DoUpdate(markId139);
    
    NXOpen.Point3d scaleAboutPoint287 = new NXOpen.Point3d(36.848954072397675, -153.99562895927457, 0.0);
    NXOpen.Point3d viewCenter287 = new NXOpen.Point3d(-36.848954072397902, 153.99562895927409, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint287, viewCenter287);
    
    NXOpen.Point3d scaleAboutPoint288 = new NXOpen.Point3d(29.919150769230303, -123.6364906787319, 0.0);
    NXOpen.Point3d viewCenter288 = new NXOpen.Point3d(-29.919150769230633, 123.63649067873143, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint288, viewCenter288);
    
    NXOpen.Point3d scaleAboutPoint289 = new NXOpen.Point3d(8.0957702081445628, -108.41292278732931, 0.0);
    NXOpen.Point3d viewCenter289 = new NXOpen.Point3d(-8.0957702081449732, 108.41292278732887, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint289, viewCenter289);
    
    NXOpen.Point3d scaleAboutPoint290 = new NXOpen.Point3d(6.476616166515603, -86.730338229863506, 0.0);
    NXOpen.Point3d viewCenter290 = new NXOpen.Point3d(-6.4766161665159787, 86.730338229863037, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint290, viewCenter290);
    
    NXOpen.Point3d scaleAboutPoint291 = new NXOpen.Point3d(5.1812929332124815, -69.384270583890839, 0.0);
    NXOpen.Point3d viewCenter291 = new NXOpen.Point3d(-5.1812929332128199, 69.384270583890398, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint291, viewCenter291);
    
    NXOpen.Point3d scaleAboutPoint292 = new NXOpen.Point3d(4.1450343465699246, -55.507416467112712, 0.0);
    NXOpen.Point3d viewCenter292 = new NXOpen.Point3d(-4.1450343465702852, 55.507416467112257, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint292, viewCenter292);
    
    NXOpen.Session.UndoMarkId markId140;
    markId140 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.IdSymbol idSymbol3 = ((NXOpen.Annotations.IdSymbol)workPart.FindObject("HANDLE R-67169"));
    idSymbol3.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin100 = new NXOpen.Point3d(457.75830064820133, 308.32962559948436, 0.0);
    idSymbol3.AnnotationOrigin = origin100;
    
    int nErrs110;
    nErrs110 = theSession.UpdateManager.DoUpdate(markId140);
    
    NXOpen.Point3d origin101 = new NXOpen.Point3d(454.73062338636544, 326.35151406283802, 0.0);
    workPart.Views.WorkView.SetOrigin(origin101);
    
    NXOpen.Point3d origin102 = new NXOpen.Point3d(454.73062338636544, 326.35151406283802, 0.0);
    workPart.Views.WorkView.SetOrigin(origin102);
    
    NXOpen.Point3d scaleAboutPoint293 = new NXOpen.Point3d(35.322901388162308, 22.923842125378712, 0.0);
    NXOpen.Point3d viewCenter293 = new NXOpen.Point3d(-35.322901388162705, -22.923842125379135, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint293, viewCenter293);
    
    NXOpen.Point3d scaleAboutPoint294 = new NXOpen.Point3d(28.027640938198896, 17.070332752483257, 0.0);
    NXOpen.Point3d viewCenter294 = new NXOpen.Point3d(-28.027640938199358, -17.070332752483594, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint294, viewCenter294);
    
    NXOpen.Session.UndoMarkId markId141;
    markId141 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.TargetPoint targetPoint2 = ((NXOpen.Annotations.TargetPoint)workPart.Annotations.TargetPoints.FindObject("HANDLE R-780818"));
    targetPoint2.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin103 = new NXOpen.Point3d(487.0546825342268, 354.37338799673267, 0.0);
    targetPoint2.AnnotationOrigin = origin103;
    
    int nErrs111;
    nErrs111 = theSession.UpdateManager.DoUpdate(markId141);
    
    NXOpen.Point3d scaleAboutPoint295 = new NXOpen.Point3d(19.746222751521049, 19.008046200062431, 0.0);
    NXOpen.Point3d viewCenter295 = new NXOpen.Point3d(-19.746222751521632, -19.008046200062772, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint295, viewCenter295);
    
    NXOpen.Point3d scaleAboutPoint296 = new NXOpen.Point3d(15.944613511508575, 15.280254615195785, 0.0);
    NXOpen.Point3d viewCenter296 = new NXOpen.Point3d(-15.944613511509091, -15.280254615196123, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint296, viewCenter296);
    
    NXOpen.Point3d scaleAboutPoint297 = new NXOpen.Point3d(12.814744933323542, 12.224203692156602, 0.0);
    NXOpen.Point3d viewCenter297 = new NXOpen.Point3d(-12.814744933323995, -12.224203692156941, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint297, viewCenter297);
    
    NXOpen.Point3d scaleAboutPoint298 = new NXOpen.Point3d(10.251795946658891, 9.8266062530186211, 0.0);
    NXOpen.Point3d viewCenter298 = new NXOpen.Point3d(-10.251795946659175, -9.826606253018964, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint298, viewCenter298);
    
    NXOpen.Point3d scaleAboutPoint299 = new NXOpen.Point3d(8.2392313967617472, 7.8612850024148671, 0.0);
    NXOpen.Point3d viewCenter299 = new NXOpen.Point3d(-8.2392313967620918, -7.8612850024152099, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint299, viewCenter299);
    
    NXOpen.Point3d scaleAboutPoint300 = new NXOpen.Point3d(6.5913851174093683, 6.2890280019318663, 0.0);
    NXOpen.Point3d viewCenter300 = new NXOpen.Point3d(-6.5913851174097111, -6.2890280019322065, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint300, viewCenter300);
    
    NXOpen.Point3d scaleAboutPoint301 = new NXOpen.Point3d(5.273108093927469, 5.0554109707836634, 0.0);
    NXOpen.Point3d viewCenter301 = new NXOpen.Point3d(-5.2731080939278083, -5.0554109707840045, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint301, viewCenter301);
    
    NXOpen.Point3d scaleAboutPoint302 = new NXOpen.Point3d(4.2378373305324955, 4.0443287766268927, 0.0);
    NXOpen.Point3d viewCenter302 = new NXOpen.Point3d(-4.2378373305328356, -4.0443287766272329, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint302, viewCenter302);
    
    NXOpen.Session.UndoMarkId markId142;
    markId142 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    targetPoint2.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin104 = new NXOpen.Point3d(487.25598268926825, 354.44796650521346, 0.0);
    targetPoint2.AnnotationOrigin = origin104;
    
    int nErrs112;
    nErrs112 = theSession.UpdateManager.DoUpdate(markId142);
    
    NXOpen.Point3d scaleAboutPoint303 = new NXOpen.Point3d(3.1735402840516933, 1.0681672175587491, 0.0);
    NXOpen.Point3d viewCenter303 = new NXOpen.Point3d(-3.1735402840520339, -1.0681672175590899, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint303, viewCenter303);
    
    NXOpen.Point3d scaleAboutPoint304 = new NXOpen.Point3d(3.9669253550646544, 1.3352090219484776, 0.0);
    NXOpen.Point3d viewCenter304 = new NXOpen.Point3d(-3.9669253550649946, -1.335209021948818, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint304, viewCenter304);
    
    NXOpen.Point3d scaleAboutPoint305 = new NXOpen.Point3d(4.9344681245926481, 1.6690112774356345, 0.0);
    NXOpen.Point3d viewCenter305 = new NXOpen.Point3d(-4.9344681245929909, -1.6690112774359753, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint305, viewCenter305);
    
    NXOpen.Point3d scaleAboutPoint306 = new NXOpen.Point3d(6.1680851557408518, 2.0862640967945874, 0.0);
    NXOpen.Point3d viewCenter306 = new NXOpen.Point3d(-6.1680851557411946, -2.0862640967949275, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint306, viewCenter306);
    
    NXOpen.Point3d scaleAboutPoint307 = new NXOpen.Point3d(7.6723118052414545, 2.6078301209932766, 0.0);
    NXOpen.Point3d viewCenter307 = new NXOpen.Point3d(-7.6723118052417387, -2.6078301209936168, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint307, viewCenter307);
    
    NXOpen.Point3d scaleAboutPoint308 = new NXOpen.Point3d(9.5903897565518434, 3.3070309505349975, 0.0);
    NXOpen.Point3d viewCenter308 = new NXOpen.Point3d(-9.5903897565521259, -3.3070309505353364, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint308, viewCenter308);
    
    NXOpen.Point3d scaleAboutPoint309 = new NXOpen.Point3d(11.987987195689849, 4.1337886881687886, 0.0);
    NXOpen.Point3d viewCenter309 = new NXOpen.Point3d(-11.987987195690129, -4.1337886881691333, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint309, viewCenter309);
    
    NXOpen.Point3d scaleAboutPoint310 = new NXOpen.Point3d(14.911166339466531, 5.1672358602110329, 0.0);
    NXOpen.Point3d viewCenter310 = new NXOpen.Point3d(-14.911166339466703, -5.1672358602113713, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint310, viewCenter310);
    
    NXOpen.Point3d scaleAboutPoint311 = new NXOpen.Point3d(18.915774131130206, 7.1972213767225757, 0.0);
    NXOpen.Point3d viewCenter311 = new NXOpen.Point3d(-18.915774131130391, -7.197221376722915, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint311, viewCenter311);
    
    NXOpen.Point3d scaleAboutPoint312 = new NXOpen.Point3d(24.106078008574595, 9.3425469793995504, 0.0);
    NXOpen.Point3d viewCenter312 = new NXOpen.Point3d(-24.106078008574642, -9.3425469793998968, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint312, viewCenter312);
    
    NXOpen.Point3d scaleAboutPoint313 = new NXOpen.Point3d(10.957308185715689, -10.524782862595542, 0.0);
    NXOpen.Point3d viewCenter313 = new NXOpen.Point3d(-10.957308185715798, 10.524782862595204, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint313, viewCenter313);
    
    NXOpen.Point3d scaleAboutPoint314 = new NXOpen.Point3d(13.696635232144608, -13.155978578244394, 0.0);
    NXOpen.Point3d viewCenter314 = new NXOpen.Point3d(-13.696635232144729, 13.155978578244049, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint314, viewCenter314);
    
    NXOpen.Point3d scaleAboutPoint315 = new NXOpen.Point3d(17.120794040180801, -16.444973222805441, 0.0);
    NXOpen.Point3d viewCenter315 = new NXOpen.Point3d(-17.120794040180876, 16.4449732228051, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint315, viewCenter315);
    
    NXOpen.Point3d scaleAboutPoint316 = new NXOpen.Point3d(21.400992550225943, -20.556216528506766, 0.0);
    NXOpen.Point3d viewCenter316 = new NXOpen.Point3d(-21.400992550226082, 20.556216528506415, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint316, viewCenter316);
    
    NXOpen.Session.UndoMarkId markId143;
    markId143 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.IdSymbol idSymbol4 = ((NXOpen.Annotations.IdSymbol)workPart.FindObject("HANDLE R-67063"));
    idSymbol4.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin105 = new NXOpen.Point3d(540.7790981698588, 307.73746190162916, 0.0);
    idSymbol4.AnnotationOrigin = origin105;
    
    int nErrs113;
    nErrs113 = theSession.UpdateManager.DoUpdate(markId143);
    
    NXOpen.Session.UndoMarkId markId144;
    markId144 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    idSymbol4.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin106 = new NXOpen.Point3d(549.57884839610301, 307.03348188352959, 0.0);
    idSymbol4.AnnotationOrigin = origin106;
    
    int nErrs114;
    nErrs114 = theSession.UpdateManager.DoUpdate(markId144);
    
    NXOpen.Session.UndoMarkId markId145;
    markId145 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.HorizontalDimension horizontalDimension2 = ((NXOpen.Annotations.HorizontalDimension)workPart.FindObject("HANDLE R-62661"));
    horizontalDimension2.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    horizontalDimension2.IsOriginCentered = true;
    
    NXOpen.Point3d origin107;
    origin107 = horizontalDimension2.AnnotationOrigin;
    
    NXOpen.Point3d location3 = new NXOpen.Point3d(493.8891862275816, 290.48995145819032, 0.0);
    bool changed3;
    changed3 = theAnnotationsAngularDimensionUtils.InferQuadrantAngleFromLocation(horizontalDimension2, location3);
    
    NXOpen.Point3d origin108 = new NXOpen.Point3d(493.8891862275816, 290.48995145819032, 0.0);
    horizontalDimension2.AnnotationOrigin = origin108;
    
    int nErrs115;
    nErrs115 = theSession.UpdateManager.DoUpdate(markId145);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->撤消
    // ----------------------------------------------
    bool marksRecycled4;
    bool undoUnavailable4;
    theSession.UndoLastNVisibleMarks(1, out marksRecycled4, out undoUnavailable4);
    
    NXOpen.Point3d scaleAboutPoint317 = new NXOpen.Point3d(72.157951855202711, -82.365662117646323, 0.0);
    NXOpen.Point3d viewCenter317 = new NXOpen.Point3d(-72.157951855202938, 82.365662117645982, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint317, viewCenter317);
    
    NXOpen.Point3d scaleAboutPoint318 = new NXOpen.Point3d(57.444769476922389, -65.89252969411713, 0.0);
    NXOpen.Point3d viewCenter318 = new NXOpen.Point3d(-57.444769476922573, 65.892529694116774, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint318, viewCenter318);
    
    NXOpen.Point3d scaleAboutPoint319 = new NXOpen.Point3d(45.955815581537877, -52.714023755293717, 0.0);
    NXOpen.Point3d viewCenter319 = new NXOpen.Point3d(-45.955815581538097, 52.714023755293375, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint319, viewCenter319);
    
    NXOpen.Point3d scaleAboutPoint320 = new NXOpen.Point3d(36.764652465230284, -42.171219004235034, 0.0);
    NXOpen.Point3d viewCenter320 = new NXOpen.Point3d(-36.764652465230519, 42.171219004234686, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint320, viewCenter320);
    
    NXOpen.Point3d scaleAboutPoint321 = new NXOpen.Point3d(29.411721972184232, -33.736975203388056, 0.0);
    NXOpen.Point3d viewCenter321 = new NXOpen.Point3d(-29.411721972184449, 33.736975203387722, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint321, viewCenter321);
    
    NXOpen.Point3d scaleAboutPoint322 = new NXOpen.Point3d(23.529377577747347, -26.989580162710485, 0.0);
    NXOpen.Point3d viewCenter322 = new NXOpen.Point3d(-23.529377577747578, 26.989580162710137, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint322, viewCenter322);
    
    NXOpen.Point3d scaleAboutPoint323 = new NXOpen.Point3d(18.823502062197889, -21.591664130168414, 0.0);
    NXOpen.Point3d viewCenter323 = new NXOpen.Point3d(-18.823502062198074, 21.591664130168109, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint323, viewCenter323);
    
    NXOpen.Session.UndoMarkId markId146;
    markId146 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note37 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-5880"));
    note37.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin109 = new NXOpen.Point3d(492.78205141340806, 310.57707625188482, 0.0);
    note37.AnnotationOrigin = origin109;
    
    int nErrs116;
    nErrs116 = theSession.UpdateManager.DoUpdate(markId146);
    
    NXOpen.Point3d scaleAboutPoint324 = new NXOpen.Point3d(-2.3621649646680885, -14.172989788008076, 0.0);
    NXOpen.Point3d viewCenter324 = new NXOpen.Point3d(2.3621649646678611, 14.172989788007701, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint324, viewCenter324);
    
    NXOpen.Point3d scaleAboutPoint325 = new NXOpen.Point3d(-2.8604341369027395, -18.269869648604075, 0.0);
    NXOpen.Point3d viewCenter325 = new NXOpen.Point3d(2.8604341369025166, 18.26986964860377, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint325, viewCenter325);
    
    NXOpen.Point3d scaleAboutPoint326 = new NXOpen.Point3d(-3.4602025849629694, -23.529377577747656, 0.0);
    NXOpen.Point3d viewCenter326 = new NXOpen.Point3d(3.4602025849627389, 23.529377577747312, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint326, viewCenter326);
    
    NXOpen.Point3d scaleAboutPoint327 = new NXOpen.Point3d(-4.3252532312036189, -29.700072187598114, 0.0);
    NXOpen.Point3d viewCenter327 = new NXOpen.Point3d(4.3252532312035106, 29.700072187597776, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint327, viewCenter327);
    
    NXOpen.Point3d scaleAboutPoint328 = new NXOpen.Point3d(-5.4065665390045252, -37.485528003764578, 0.0);
    NXOpen.Point3d viewCenter328 = new NXOpen.Point3d(5.4065665390044044, 37.485528003764237, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint328, viewCenter328);
    
    NXOpen.Point3d scaleAboutPoint329 = new NXOpen.Point3d(-6.758208173755655, -46.856910004705661, 0.0);
    NXOpen.Point3d viewCenter329 = new NXOpen.Point3d(6.7582081737555049, 46.85691000470532, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint329, viewCenter329);
    
    NXOpen.Point3d scaleAboutPoint330 = new NXOpen.Point3d(-8.4477602171945669, -59.134321520361688, 0.0);
    NXOpen.Point3d viewCenter330 = new NXOpen.Point3d(8.4477602171943786, 59.134321520361333, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint330, viewCenter330);
    
    NXOpen.Point3d scaleAboutPoint331 = new NXOpen.Point3d(-12.671640325791749, 65.118151674207439, 0.0);
    NXOpen.Point3d viewCenter331 = new NXOpen.Point3d(12.671640325791721, -65.118151674207795, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint331, viewCenter331);
    
    NXOpen.Point3d scaleAboutPoint332 = new NXOpen.Point3d(-10.137312260633443, 51.249745317646443, 0.0);
    NXOpen.Point3d viewCenter332 = new NXOpen.Point3d(10.137312260633326, -51.249745317646799, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint332, viewCenter332);
    
    NXOpen.Point3d scaleAboutPoint333 = new NXOpen.Point3d(-8.1098498085067536, 40.774522648325267, 0.0);
    NXOpen.Point3d viewCenter333 = new NXOpen.Point3d(8.1098498085066595, -40.774522648325608, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint333, viewCenter333);
    
    NXOpen.Point3d scaleAboutPoint334 = new NXOpen.Point3d(-6.4878798468054306, 32.259180349393198, 0.0);
    NXOpen.Point3d viewCenter334 = new NXOpen.Point3d(6.4878798468053107, -32.259180349393546, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint334, viewCenter334);
    
    NXOpen.Session.UndoMarkId markId147;
    markId147 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note38 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-5870"));
    note38.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin110 = new NXOpen.Point3d(497.59282333075868, 423.80922772772635, 0.0);
    note38.AnnotationOrigin = origin110;
    
    int nErrs117;
    nErrs117 = theSession.UpdateManager.DoUpdate(markId147);
    
    NXOpen.Point3d scaleAboutPoint335 = new NXOpen.Point3d(-13.840810339851528, 12.110709047369856, 0.0);
    NXOpen.Point3d viewCenter335 = new NXOpen.Point3d(13.840810339851359, -12.110709047370191, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint335, viewCenter335);
    
    NXOpen.Point3d scaleAboutPoint336 = new NXOpen.Point3d(-15.138386309212597, 15.679042963112805, 0.0);
    NXOpen.Point3d viewCenter336 = new NXOpen.Point3d(15.138386309212477, -15.679042963113151, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint336, viewCenter336);
    
    NXOpen.Point3d scaleAboutPoint337 = new NXOpen.Point3d(-17.120794040180868, 19.82407730968292, 0.0);
    NXOpen.Point3d viewCenter337 = new NXOpen.Point3d(17.120794040180776, -19.824077309683258, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint337, viewCenter337);
    
    NXOpen.Point3d scaleAboutPoint338 = new NXOpen.Point3d(40.26765703529373, 36.888552948415771, 0.0);
    NXOpen.Point3d viewCenter338 = new NXOpen.Point3d(-40.267657035293844, -36.88855294841612, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint338, viewCenter338);
    
    NXOpen.Point3d scaleAboutPoint339 = new NXOpen.Point3d(51.390541321266625, 50.334571294117062, 0.0);
    NXOpen.Point3d viewCenter339 = new NXOpen.Point3d(-51.390541321266568, -50.334571294117389, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint339, viewCenter339);
    
    NXOpen.Point3d scaleAboutPoint340 = new NXOpen.Point3d(66.878101719456467, 69.078039276017336, 0.0);
    NXOpen.Point3d viewCenter340 = new NXOpen.Point3d(-66.878101719456467, -69.078039276017662, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint340, viewCenter340);
    
    NXOpen.Point3d scaleAboutPoint341 = new NXOpen.Point3d(85.797564705881726, 91.297408597284132, 0.0);
    NXOpen.Point3d viewCenter341 = new NXOpen.Point3d(-85.797564705881683, -91.297408597284459, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint341, viewCenter341);
    
    NXOpen.Point3d scaleAboutPoint342 = new NXOpen.Point3d(28.87418042986393, -142.99594117646939, 0.0);
    NXOpen.Point3d viewCenter342 = new NXOpen.Point3d(-28.874180429864044, 142.99594117646916, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint342, viewCenter342);
    
    NXOpen.Point3d scaleAboutPoint343 = new NXOpen.Point3d(23.09934434389114, -114.94673733031581, 0.0);
    NXOpen.Point3d viewCenter343 = new NXOpen.Point3d(-23.099344343891325, 114.94673733031563, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint343, viewCenter343);
    
    NXOpen.Session.UndoMarkId markId148;
    markId148 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Drawings.ProjectedView projectedView5 = ((NXOpen.Drawings.ProjectedView)workPart.DraftingViews.FindObject("ORTHO@AP-SAGITTAL"));
    NXOpen.Point3d drawingReferencePoint22 = new NXOpen.Point3d(496.6457309666327, 201.62100184579319, 0.0);
    projectedView5.MoveView(drawingReferencePoint22);
    
    int nErrs118;
    nErrs118 = theSession.UpdateManager.DoUpdate(markId148);
    
    NXOpen.Session.UndoMarkId markId149;
    markId149 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Point3d drawingReferencePoint23 = new NXOpen.Point3d(496.6457309666327, 220.98045234353063, 0.0);
    projectedView5.MoveView(drawingReferencePoint23);
    
    int nErrs119;
    nErrs119 = theSession.UpdateManager.DoUpdate(markId149);
    
    NXOpen.Session.UndoMarkId markId150;
    markId150 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Point3d drawingReferencePoint24 = new NXOpen.Point3d(496.6457309666327, 208.66080202678862, 0.0);
    projectedView5.MoveView(drawingReferencePoint24);
    
    int nErrs120;
    nErrs120 = theSession.UpdateManager.DoUpdate(markId150);
    
    NXOpen.Session.UndoMarkId markId151;
    markId151 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Point3d drawingReferencePoint25 = new NXOpen.Point3d(507.20543123812575, 209.10078953810083, 0.0);
    projectedView5.MoveView(drawingReferencePoint25);
    
    int nErrs121;
    nErrs121 = theSession.UpdateManager.DoUpdate(markId151);
    
    NXOpen.Point3d scaleAboutPoint344 = new NXOpen.Point3d(113.9567654298631, -29.039175746606208, 0.0);
    NXOpen.Point3d viewCenter344 = new NXOpen.Point3d(-113.95676542986324, 29.039175746605949, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint344, viewCenter344);
    
    NXOpen.Point3d scaleAboutPoint345 = new NXOpen.Point3d(155.09559773755527, -68.748048642533476, 0.0);
    NXOpen.Point3d viewCenter345 = new NXOpen.Point3d(-155.09559773755524, 68.748048642533234, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint345, viewCenter345);
    
    NXOpen.Point3d scaleAboutPoint346 = new NXOpen.Point3d(124.07647819004418, -54.118463891402385, 0.0);
    NXOpen.Point3d viewCenter346 = new NXOpen.Point3d(-124.07647819004418, 54.118463891402129, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint346, viewCenter346);
    
    NXOpen.Point3d scaleAboutPoint347 = new NXOpen.Point3d(99.261182552035308, -42.238801085972611, 0.0);
    NXOpen.Point3d viewCenter347 = new NXOpen.Point3d(-99.261182552035308, 42.238801085972348, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint347, viewCenter347);
    
    NXOpen.Point3d scaleAboutPoint348 = new NXOpen.Point3d(44.773129151130824, -9.2925362389140709, 0.0);
    NXOpen.Point3d viewCenter348 = new NXOpen.Point3d(-44.773129151130775, 9.2925362389138595, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint348, viewCenter348);
    
    NXOpen.Point3d scaleAboutPoint349 = new NXOpen.Point3d(55.966411438913525, -11.615670298642529, 0.0);
    NXOpen.Point3d viewCenter349 = new NXOpen.Point3d(-55.966411438913525, 11.615670298642353, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint349, viewCenter349);
    
    NXOpen.Point3d scaleAboutPoint350 = new NXOpen.Point3d(69.958014298641984, -14.51958787330309, 0.0);
    NXOpen.Point3d viewCenter350 = new NXOpen.Point3d(-69.958014298641956, 14.51958787330298, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint350, viewCenter350);
    
    NXOpen.Session.UndoMarkId markId152;
    markId152 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Point3d drawingReferencePoint26 = new NXOpen.Point3d(520.40505657749213, 208.55080514896056, 0.0);
    projectedView5.MoveView(drawingReferencePoint26);
    
    int nErrs122;
    nErrs122 = theSession.UpdateManager.DoUpdate(markId152);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->撤消
    // ----------------------------------------------
    bool marksRecycled5;
    bool undoUnavailable5;
    theSession.UndoLastNVisibleMarks(1, out marksRecycled5, out undoUnavailable5);
    
    NXOpen.Point3d scaleAboutPoint351 = new NXOpen.Point3d(139.14605045248743, -134.74617533936535, 0.0);
    NXOpen.Point3d viewCenter351 = new NXOpen.Point3d(-139.14605045248743, 134.74617533936527, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint351, viewCenter351);
    
    NXOpen.Point3d scaleAboutPoint352 = new NXOpen.Point3d(119.23661556560988, -107.7969402714923, 0.0);
    NXOpen.Point3d viewCenter352 = new NXOpen.Point3d(-119.23661556560988, 107.79694027149223, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint352, viewCenter352);
    
    NXOpen.Point3d scaleAboutPoint353 = new NXOpen.Point3d(100.66914258823438, -86.237552217193866, 0.0);
    NXOpen.Point3d viewCenter353 = new NXOpen.Point3d(-100.66914258823444, 86.23755221719378, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint353, viewCenter353);
    
    NXOpen.Point3d scaleAboutPoint354 = new NXOpen.Point3d(82.788050128506072, -68.990041773755124, 0.0);
    NXOpen.Point3d viewCenter354 = new NXOpen.Point3d(-82.788050128506072, 68.990041773755024, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint354, viewCenter354);
    
    NXOpen.Point3d scaleAboutPoint355 = new NXOpen.Point3d(67.131534525972285, -54.966759813212214, 0.0);
    NXOpen.Point3d viewCenter355 = new NXOpen.Point3d(-67.131534525972285, 54.966759813212171, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint355, viewCenter355);
    
    NXOpen.Session.UndoMarkId markId153;
    markId153 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    label4.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin111 = new NXOpen.Point3d(625.23802148310688, 96.96360737492526, 0.0);
    label4.AnnotationOrigin = origin111;
    
    int nErrs123;
    nErrs123 = theSession.UpdateManager.DoUpdate(markId153);
    
    NXOpen.Point3d scaleAboutPoint356 = new NXOpen.Point3d(39.287716850099216, -4.8659098851040659, 0.0);
    NXOpen.Point3d viewCenter356 = new NXOpen.Point3d(-39.287716850099216, 4.8659098851040206, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint356, viewCenter356);
    
    NXOpen.Point3d scaleAboutPoint357 = new NXOpen.Point3d(49.109646062624016, -6.0823873563800817, 0.0);
    NXOpen.Point3d viewCenter357 = new NXOpen.Point3d(-49.109646062624016, 6.082387356380007, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint357, viewCenter357);
    
    NXOpen.Point3d scaleAboutPoint358 = new NXOpen.Point3d(61.387057578279965, -7.6029841954751012, 0.0);
    NXOpen.Point3d viewCenter358 = new NXOpen.Point3d(-61.387057578280057, 7.602984195475007, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint358, viewCenter358);
    
    NXOpen.Point3d scaleAboutPoint359 = new NXOpen.Point3d(76.733821972850023, -9.5037302443438474, 0.0);
    NXOpen.Point3d viewCenter359 = new NXOpen.Point3d(-76.733821972850023, 9.5037302443437603, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint359, viewCenter359);
    
    NXOpen.Session.UndoMarkId markId154;
    markId154 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note39 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 23 1"));
    note39.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Note note40 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-164155"));
    note39.InsertIntoStack(note40, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    int nErrs124;
    nErrs124 = theSession.UpdateManager.DoUpdate(markId154);
    
    NXOpen.Point3d scaleAboutPoint360 = new NXOpen.Point3d(122.3165281447954, -29.039175746606105, 0.0);
    NXOpen.Point3d viewCenter360 = new NXOpen.Point3d(-122.31652814479536, 29.039175746606034, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint360, viewCenter360);
    
    NXOpen.Point3d scaleAboutPoint361 = new NXOpen.Point3d(97.853222515836251, -23.583330606334677, 0.0);
    NXOpen.Point3d viewCenter361 = new NXOpen.Point3d(-97.853222515836251, 23.58333060633456, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint361, viewCenter361);
    
    NXOpen.Point3d scaleAboutPoint362 = new NXOpen.Point3d(78.282578012668949, -18.866664485067766, 0.0);
    NXOpen.Point3d viewCenter362 = new NXOpen.Point3d(-78.282578012669049, 18.866664485067648, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint362, viewCenter362);
    
    NXOpen.Point3d scaleAboutPoint363 = new NXOpen.Point3d(62.626062410135205, -15.543878799637932, 0.0);
    NXOpen.Point3d viewCenter363 = new NXOpen.Point3d(-62.626062410135205, 15.54387879963782, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint363, viewCenter363);
    
    NXOpen.Point3d scaleAboutPoint364 = new NXOpen.Point3d(50.100849928108161, -12.615321924343856, 0.0);
    NXOpen.Point3d viewCenter364 = new NXOpen.Point3d(-50.100849928108161, 12.615321924343721, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint364, viewCenter364);
    
    NXOpen.Point3d scaleAboutPoint365 = new NXOpen.Point3d(40.224855050193312, -10.380607754888636, 0.0);
    NXOpen.Point3d viewCenter365 = new NXOpen.Point3d(-40.224855050193312, 10.380607754888528, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint365, viewCenter365);
    
    NXOpen.Point3d scaleAboutPoint366 = new NXOpen.Point3d(26.182199559552348, -9.5732271517306486, 0.0);
    NXOpen.Point3d viewCenter366 = new NXOpen.Point3d(-26.182199559552348, 9.5732271517305332, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint366, viewCenter366);
    
    NXOpen.Point3d scaleAboutPoint367 = new NXOpen.Point3d(34.025325418801494, -11.389833508836148, 0.0);
    NXOpen.Point3d viewCenter367 = new NXOpen.Point3d(-34.025325418801494, 11.389833508836039, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint367, viewCenter367);
    
    NXOpen.Session.UndoMarkId markId155;
    markId155 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    label4.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin112 = new NXOpen.Point3d(635.23802148310688, 94.060647213089339, 0.0);
    label4.AnnotationOrigin = origin112;
    
    int nErrs125;
    nErrs125 = theSession.UpdateManager.DoUpdate(markId155);
    
    NXOpen.Point3d scaleAboutPoint368 = new NXOpen.Point3d(66.86120619902205, 0.36043776926689985, 0.0);
    NXOpen.Point3d viewCenter368 = new NXOpen.Point3d(-66.861206199021993, -0.36043776926702004, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint368, viewCenter368);
    
    NXOpen.Point3d scaleAboutPoint369 = new NXOpen.Point3d(87.18088544144733, 0.90109442316734367, 0.0);
    NXOpen.Point3d viewCenter369 = new NXOpen.Point3d(-87.180885441447103, -0.90109442316747523, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint369, viewCenter369);
    
    NXOpen.Point3d scaleAboutPoint370 = new NXOpen.Point3d(111.51043486696743, 1.6895520434388749, 0.0);
    NXOpen.Point3d viewCenter370 = new NXOpen.Point3d(-111.51043486696724, -1.6895520434389453, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint370, viewCenter370);
    
    NXOpen.Point3d scaleAboutPoint371 = new NXOpen.Point3d(142.55595366515723, 3.1679100814478907, 0.0);
    NXOpen.Point3d viewCenter371 = new NXOpen.Point3d(-142.55595366515698, -3.1679100814479493, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint371, viewCenter371);
    
    NXOpen.Point3d origin113 = new NXOpen.Point3d(489.93693151702257, 182.82971157536949, 0.0);
    workPart.Views.WorkView.SetOrigin(origin113);
    
    NXOpen.Point3d origin114 = new NXOpen.Point3d(489.93693151702257, 182.82971157536949, 0.0);
    workPart.Views.WorkView.SetOrigin(origin114);
    
    NXOpen.Point3d scaleAboutPoint372 = new NXOpen.Point3d(-38.718900995474591, 69.958014298641885, 0.0);
    NXOpen.Point3d viewCenter372 = new NXOpen.Point3d(38.718900995474812, -69.958014298641956, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint372, viewCenter372);
    
    NXOpen.Point3d scaleAboutPoint373 = new NXOpen.Point3d(-29.21517075113081, 55.26243142081389, 0.0);
    NXOpen.Point3d viewCenter373 = new NXOpen.Point3d(29.215170751131105, -55.262431420814039, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint373, viewCenter373);
    
    NXOpen.Point3d scaleAboutPoint374 = new NXOpen.Point3d(-19.993032514026758, 44.209945136651115, 0.0);
    NXOpen.Point3d viewCenter374 = new NXOpen.Point3d(19.993032514027089, -44.209945136651278, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint374, viewCenter374);
    
    NXOpen.Point3d scaleAboutPoint375 = new NXOpen.Point3d(-11.939501106967997, 35.367956109320879, 0.0);
    NXOpen.Point3d viewCenter375 = new NXOpen.Point3d(11.939501106968391, -35.367956109321028, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint375, viewCenter375);
    
    NXOpen.Point3d scaleAboutPoint376 = new NXOpen.Point3d(-6.4878798468051899, 28.474583772090181, 0.0);
    NXOpen.Point3d viewCenter376 = new NXOpen.Point3d(6.4878798468055212, -28.474583772090298, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint376, viewCenter376);
    
    NXOpen.Point3d scaleAboutPoint377 = new NXOpen.Point3d(-1.4417510770676245, 23.500542556206092, 0.0);
    NXOpen.Point3d viewCenter377 = new NXOpen.Point3d(1.4417510770680695, -23.500542556206199, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint377, viewCenter377);
    
    NXOpen.Point3d scaleAboutPoint378 = new NXOpen.Point3d(1.7301012924816981, 19.377134475792023, 0.0);
    NXOpen.Point3d viewCenter378 = new NXOpen.Point3d(-1.7301012924811883, -19.377134475792101, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint378, viewCenter378);
    
    NXOpen.Session.UndoMarkId markId156;
    markId156 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label24 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-99174"));
    label24.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin115 = new NXOpen.Point3d(481.82633830561696, 259.65149725944156, 0.0);
    label24.AnnotationOrigin = origin115;
    
    int nErrs126;
    nErrs126 = theSession.UpdateManager.DoUpdate(markId156);
    
    NXOpen.Point3d scaleAboutPoint379 = new NXOpen.Point3d(10.057655513625633, 21.776208268032928, 0.0);
    NXOpen.Point3d viewCenter379 = new NXOpen.Point3d(-10.057655513625187, -21.776208268033042, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint379, viewCenter379);
    
    NXOpen.Point3d scaleAboutPoint380 = new NXOpen.Point3d(13.379449995189994, 26.643559904214033, 0.0);
    NXOpen.Point3d viewCenter380 = new NXOpen.Point3d(-13.379449995189534, -26.643559904214147, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint380, viewCenter380);
    
    NXOpen.Point3d scaleAboutPoint381 = new NXOpen.Point3d(16.868487601694188, 33.016099664853989, 0.0);
    NXOpen.Point3d viewCenter381 = new NXOpen.Point3d(-16.868487601693804, -33.016099664854075, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint381, viewCenter381);
    
    NXOpen.Point3d scaleAboutPoint382 = new NXOpen.Point3d(21.265828386751195, 41.270124581067513, 0.0);
    NXOpen.Point3d viewCenter382 = new NXOpen.Point3d(-21.265828386750744, -41.270124581067606, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint382, viewCenter382);
    
    NXOpen.Point3d scaleAboutPoint383 = new NXOpen.Point3d(26.582285483438937, 51.587655726334418, 0.0);
    NXOpen.Point3d viewCenter383 = new NXOpen.Point3d(-26.582285483438486, -51.587655726334489, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint383, viewCenter383);
    
    NXOpen.Point3d scaleAboutPoint384 = new NXOpen.Point3d(33.227856854298629, 64.484569657918001, 0.0);
    NXOpen.Point3d viewCenter384 = new NXOpen.Point3d(-33.227856854298153, -64.484569657918115, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint384, viewCenter384);
    
    NXOpen.Point3d scaleAboutPoint385 = new NXOpen.Point3d(41.534821067873054, 80.605712072397509, 0.0);
    NXOpen.Point3d viewCenter385 = new NXOpen.Point3d(-41.534821067872763, -80.605712072397594, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint385, viewCenter385);
    
    NXOpen.Point3d scaleAboutPoint386 = new NXOpen.Point3d(52.358513846153642, 100.75714009049693, 0.0);
    NXOpen.Point3d viewCenter386 = new NXOpen.Point3d(-52.358513846153308, -100.757140090497, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint386, viewCenter386);
    
    NXOpen.Point3d scaleAboutPoint387 = new NXOpen.Point3d(172.69509819004409, 111.64683099547413, 0.0);
    NXOpen.Point3d viewCenter387 = new NXOpen.Point3d(-172.69509819004372, -111.64683099547428, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint387, viewCenter387);
    
    NXOpen.Point3d scaleAboutPoint388 = new NXOpen.Point3d(137.71609104072297, 88.87747728506703, 0.0);
    NXOpen.Point3d viewCenter388 = new NXOpen.Point3d(-137.71609104072274, -88.877477285067172, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint388, viewCenter388);
    
    NXOpen.Point3d scaleAboutPoint389 = new NXOpen.Point3d(110.17287283257838, 71.101981828053624, 0.0);
    NXOpen.Point3d viewCenter389 = new NXOpen.Point3d(-110.17287283257821, -71.101981828053781, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint389, viewCenter389);
    
    NXOpen.Point3d scaleAboutPoint390 = new NXOpen.Point3d(88.138298266062748, 56.881585462442928, 0.0);
    NXOpen.Point3d viewCenter390 = new NXOpen.Point3d(-88.13829826606252, -56.88158546244302, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint390, viewCenter390);
    
    NXOpen.Point3d scaleAboutPoint391 = new NXOpen.Point3d(14.19223716488688, -14.868057982262336, 0.0);
    NXOpen.Point3d viewCenter391 = new NXOpen.Point3d(-14.192237164886654, 14.868057982262281, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint391, viewCenter391);
    
    NXOpen.Point3d scaleAboutPoint392 = new NXOpen.Point3d(11.353789731909536, -11.894446385809871, 0.0);
    NXOpen.Point3d viewCenter392 = new NXOpen.Point3d(-11.353789731909295, 11.894446385809825, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint392, viewCenter392);
    
    NXOpen.Point3d scaleAboutPoint393 = new NXOpen.Point3d(9.0830317855276501, -9.5155571086479185, 0.0);
    NXOpen.Point3d viewCenter393 = new NXOpen.Point3d(-9.0830317855274103, 9.5155571086478581, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint393, viewCenter393);
    
    NXOpen.Point3d scaleAboutPoint394 = new NXOpen.Point3d(7.2664254284221697, -7.6124456869183366, 0.0);
    NXOpen.Point3d viewCenter394 = new NXOpen.Point3d(-7.2664254284218908, 7.6124456869182788, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint394, viewCenter394);
    
    NXOpen.Session.UndoMarkId markId157;
    markId157 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.TargetPoint targetPoint3 = ((NXOpen.Annotations.TargetPoint)workPart.Annotations.TargetPoints.FindObject("HANDLE R-606160"));
    targetPoint3.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin116 = new NXOpen.Point3d(515.06316527330603, 197.05298862721466, 0.0);
    targetPoint3.AnnotationOrigin = origin116;
    
    int nErrs127;
    nErrs127 = theSession.UpdateManager.DoUpdate(markId157);
    
    NXOpen.Point3d scaleAboutPoint395 = new NXOpen.Point3d(-11.441736547610395, 7.197221376722732, 0.0);
    NXOpen.Point3d viewCenter395 = new NXOpen.Point3d(11.441736547610679, -7.1972213767227862, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint395, viewCenter395);
    
    NXOpen.Point3d scaleAboutPoint396 = new NXOpen.Point3d(-9.0057539277965439, 6.0530477219616792, 0.0);
    NXOpen.Point3d viewCenter396 = new NXOpen.Point3d(9.005753927796821, -6.0530477219617342, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint396, viewCenter396);
    
    NXOpen.Point3d scaleAboutPoint397 = new NXOpen.Point3d(-7.2046031422372279, 4.842438177569333, 0.0);
    NXOpen.Point3d viewCenter397 = new NXOpen.Point3d(7.2046031422374543, -4.8424381775693925, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint397, viewCenter397);
    
    NXOpen.Point3d scaleAboutPoint398 = new NXOpen.Point3d(-5.7636825137897585, 3.873950542055463, 0.0);
    NXOpen.Point3d viewCenter398 = new NXOpen.Point3d(5.7636825137899832, -3.873950542055518, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint398, viewCenter398);
    
    NXOpen.Point3d scaleAboutPoint399 = new NXOpen.Point3d(-4.6109460110317784, 3.0991604336443617, 0.0);
    NXOpen.Point3d viewCenter399 = new NXOpen.Point3d(4.6109460110320084, -3.0991604336444185, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint399, viewCenter399);
    
    NXOpen.Session.UndoMarkId markId158;
    markId158 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    targetPoint3.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin117 = new NXOpen.Point3d(514.85316880794687, 196.86605279732325, 0.0);
    targetPoint3.AnnotationOrigin = origin117;
    
    int nErrs128;
    nErrs128 = theSession.UpdateManager.DoUpdate(markId158);
    
    NXOpen.Point3d scaleAboutPoint400 = new NXOpen.Point3d(-9.3125991567069395, 0.060471423095471759, 0.0);
    NXOpen.Point3d viewCenter400 = new NXOpen.Point3d(9.3125991567071633, -0.060471423095527221, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint400, viewCenter400);
    
    NXOpen.Point3d scaleAboutPoint401 = new NXOpen.Point3d(-11.716338224753063, 0.075589278869345938, 0.0);
    NXOpen.Point3d viewCenter401 = new NXOpen.Point3d(11.716338224753294, -0.075589278869402657, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint401, viewCenter401);
    
    NXOpen.Point3d scaleAboutPoint402 = new NXOpen.Point3d(-14.645422780941377, 0.14172989788004886, 0.0);
    NXOpen.Point3d viewCenter402 = new NXOpen.Point3d(14.645422780941493, -0.14172989788010401, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint402, viewCenter402);
    
    NXOpen.Point3d scaleAboutPoint403 = new NXOpen.Point3d(-18.30677847617676, 0.17716237235006568, 0.0);
    NXOpen.Point3d viewCenter403 = new NXOpen.Point3d(18.30677847617676, -0.17716237235012475, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint403, viewCenter403);
    
    NXOpen.Point3d scaleAboutPoint404 = new NXOpen.Point3d(-23.104926060658585, 0.51672358602108659, 0.0);
    NXOpen.Point3d viewCenter404 = new NXOpen.Point3d(23.104926060658585, -0.51672358602114199, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint404, viewCenter404);
    
    NXOpen.Point3d scaleAboutPoint405 = new NXOpen.Point3d(11.257192409745803, -8.7658465485725738, 0.0);
    NXOpen.Point3d viewCenter405 = new NXOpen.Point3d(-11.257192409745803, 8.7658465485725134, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint405, viewCenter405);
    
    NXOpen.Point3d scaleAboutPoint406 = new NXOpen.Point3d(14.071490512182255, -11.187988358046571, 0.0);
    NXOpen.Point3d viewCenter406 = new NXOpen.Point3d(-14.071490512182255, 11.187988358046512, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint406, viewCenter406);
    
    NXOpen.Session.UndoMarkId markId159;
    markId159 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.IdSymbol idSymbol5 = ((NXOpen.Annotations.IdSymbol)workPart.FindObject("HANDLE R-776582"));
    idSymbol5.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin118 = new NXOpen.Point3d(570.01070435319878, 217.72863102026403, 0.0);
    idSymbol5.AnnotationOrigin = origin118;
    
    int nErrs129;
    nErrs129 = theSession.UpdateManager.DoUpdate(markId159);
    
    NXOpen.Session.UndoMarkId markId160;
    markId160 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.TargetPoint targetPoint4 = ((NXOpen.Annotations.TargetPoint)workPart.Annotations.TargetPoints.FindObject("HANDLE R-769643"));
    targetPoint4.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin119 = new NXOpen.Point3d(538.43635576541283, 202.15771938793108, 0.0);
    targetPoint4.AnnotationOrigin = origin119;
    
    int nErrs130;
    nErrs130 = theSession.UpdateManager.DoUpdate(markId160);
    
    NXOpen.Point3d scaleAboutPoint407 = new NXOpen.Point3d(12.110709047369957, 1.7301012924813863, 0.0);
    NXOpen.Point3d viewCenter407 = new NXOpen.Point3d(-12.110709047369957, -1.7301012924814585, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint407, viewCenter407);
    
    NXOpen.Point3d scaleAboutPoint408 = new NXOpen.Point3d(9.6885672378959669, 1.3840810339851093, 0.0);
    NXOpen.Point3d viewCenter408 = new NXOpen.Point3d(-9.6885672378959669, -1.384081033985167, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint408, viewCenter408);
    
    NXOpen.Point3d scaleAboutPoint409 = new NXOpen.Point3d(7.750853790316774, 1.1072648271880798, 0.0);
    NXOpen.Point3d viewCenter409 = new NXOpen.Point3d(-7.750853790316774, -1.1072648271881413, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint409, viewCenter409);
    
    NXOpen.Point3d scaleAboutPoint410 = new NXOpen.Point3d(6.200683032253421, 0.88581186175046411, 0.0);
    NXOpen.Point3d viewCenter410 = new NXOpen.Point3d(-6.200683032253421, -0.88581186175051951, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint410, viewCenter410);
    
    NXOpen.Point3d scaleAboutPoint411 = new NXOpen.Point3d(4.9605464258027352, 0.70864948940036121, 0.0);
    NXOpen.Point3d viewCenter411 = new NXOpen.Point3d(-4.9605464258027352, -0.70864948940042027, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint411, viewCenter411);
    
    NXOpen.Point3d scaleAboutPoint412 = new NXOpen.Point3d(3.9684371406421546, 0.5669195915202847, 0.0);
    NXOpen.Point3d viewCenter412 = new NXOpen.Point3d(-3.9684371406422176, -0.56691959152033988, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint412, viewCenter412);
    
    NXOpen.Point3d scaleAboutPoint413 = new NXOpen.Point3d(3.1747497125137514, 0.45353567321622185, 0.0);
    NXOpen.Point3d viewCenter413 = new NXOpen.Point3d(-3.1747497125137514, -0.45353567321627858, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint413, viewCenter413);
    
    NXOpen.Point3d scaleAboutPoint414 = new NXOpen.Point3d(2.5397997700110011, 0.36282853857297243, 0.0);
    NXOpen.Point3d viewCenter414 = new NXOpen.Point3d(-2.5397997700110011, -0.36282853857302788, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint414, viewCenter414);
    
    NXOpen.Point3d scaleAboutPoint415 = new NXOpen.Point3d(2.0318398160088007, 0.2902628308583719, 0.0);
    NXOpen.Point3d viewCenter415 = new NXOpen.Point3d(-2.0318398160088007, -0.29026283085842836, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint415, viewCenter415);
    
    NXOpen.Point3d scaleAboutPoint416 = new NXOpen.Point3d(0.83208678179407913, 0.46442052937340972, 0.0);
    NXOpen.Point3d viewCenter416 = new NXOpen.Point3d(-0.83208678179407913, -0.46442052937346617, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint416, viewCenter416);
    
    NXOpen.Point3d scaleAboutPoint417 = new NXOpen.Point3d(0.46442052937344003, 0.41797847643606584, 0.0);
    NXOpen.Point3d viewCenter417 = new NXOpen.Point3d(-0.46442052937344003, -0.41797847643612263, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint417, viewCenter417);
    
    NXOpen.Point3d scaleAboutPoint418 = new NXOpen.Point3d(0.24769094899916863, 0.34676732859880655, 0.0);
    NXOpen.Point3d viewCenter418 = new NXOpen.Point3d(-0.24769094899916863, -0.34676732859886333, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint418, viewCenter418);
    
    NXOpen.Point3d scaleAboutPoint419 = new NXOpen.Point3d(0.13870693143953375, 0.28732150083900598, 0.0);
    NXOpen.Point3d viewCenter419 = new NXOpen.Point3d(-0.13870693143953375, -0.28732150083906299, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint419, viewCenter419);
    
    NXOpen.Point3d scaleAboutPoint420 = new NXOpen.Point3d(-0.023778331103919883, 0.22985720067120041, 0.0);
    NXOpen.Point3d viewCenter420 = new NXOpen.Point3d(0.023778331103919883, -0.22985720067125726, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint420, viewCenter420);
    
    NXOpen.Session.UndoMarkId markId161;
    markId161 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    targetPoint4.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin120 = new NXOpen.Point3d(538.89055162622537, 202.08653720862196, 0.0);
    targetPoint4.AnnotationOrigin = origin120;
    
    int nErrs131;
    nErrs131 = theSession.UpdateManager.DoUpdate(markId161);
    
    NXOpen.Point3d scaleAboutPoint421 = new NXOpen.Point3d(0.19656753712574221, -0.64677060602666447, 0.0);
    NXOpen.Point3d viewCenter421 = new NXOpen.Point3d(-0.19656753712574221, 0.64677060602660741, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint421, viewCenter421);
    
    NXOpen.Point3d scaleAboutPoint422 = new NXOpen.Point3d(0.24570942140717542, -0.8084632575333156, 0.0);
    NXOpen.Point3d viewCenter422 = new NXOpen.Point3d(-0.24570942140717542, 0.80846325753325876, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint422, viewCenter422);
    
    NXOpen.Point3d scaleAboutPoint423 = new NXOpen.Point3d(0.30713677675896806, -1.0105790719166339, 0.0);
    NXOpen.Point3d viewCenter423 = new NXOpen.Point3d(-0.30713677675896806, 1.010579071916577, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint423, viewCenter423);
    
    NXOpen.Point3d scaleAboutPoint424 = new NXOpen.Point3d(0.38392097094871014, -1.2756083873457447, 0.0);
    NXOpen.Point3d viewCenter424 = new NXOpen.Point3d(-0.38392097094871014, 1.2756083873456878, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint424, viewCenter424);
    
    NXOpen.Point3d scaleAboutPoint425 = new NXOpen.Point3d(0.49538189799833554, -1.5945104841821691, 0.0);
    NXOpen.Point3d viewCenter425 = new NXOpen.Point3d(-0.49538189799833554, 1.5945104841821123, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint425, viewCenter425);
    
    NXOpen.Point3d scaleAboutPoint426 = new NXOpen.Point3d(0.61922737249792104, -2.0124889606182648, 0.0);
    NXOpen.Point3d viewCenter426 = new NXOpen.Point3d(-0.61922737249792104, 2.0124889606182084, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint426, viewCenter426);
    
    NXOpen.Point3d scaleAboutPoint427 = new NXOpen.Point3d(0.79822278486059839, -2.5156112007728151, 0.0);
    NXOpen.Point3d viewCenter427 = new NXOpen.Point3d(-0.79822278486059839, 2.5156112007727582, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint427, viewCenter427);
    
    NXOpen.Point3d scaleAboutPoint428 = new NXOpen.Point3d(3.1142782894182401, -2.6909783277497659, 0.0);
    NXOpen.Point3d viewCenter428 = new NXOpen.Point3d(-3.1142782894182401, 2.6909783277497104, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint428, viewCenter428);
    
    NXOpen.Point3d scaleAboutPoint429 = new NXOpen.Point3d(4.7621245687706111, -3.2125443519484569, 0.0);
    NXOpen.Point3d viewCenter429 = new NXOpen.Point3d(-4.7621245687706111, 3.2125443519484, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint429, viewCenter429);
    
    NXOpen.Point3d scaleAboutPoint430 = new NXOpen.Point3d(7.4171979890573922, -3.7794639434687638, 0.0);
    NXOpen.Point3d viewCenter430 = new NXOpen.Point3d(-7.4171979890573922, 3.7794639434687083, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint430, viewCenter430);
    
    NXOpen.Point3d scaleAboutPoint431 = new NXOpen.Point3d(10.039201099838825, -4.5471675569858476, 0.0);
    NXOpen.Point3d viewCenter431 = new NXOpen.Point3d(-10.039201099838825, 4.5471675569857881, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint431, viewCenter431);
    
    NXOpen.Point3d scaleAboutPoint432 = new NXOpen.Point3d(12.918089650527893, -5.5363241359405544, 0.0);
    NXOpen.Point3d viewCenter432 = new NXOpen.Point3d(-12.918089650527893, 5.5363241359404984, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint432, viewCenter432);
    
    NXOpen.Point3d scaleAboutPoint433 = new NXOpen.Point3d(16.516700338889194, -6.7358610320610017, 0.0);
    NXOpen.Point3d viewCenter433 = new NXOpen.Point3d(-16.516700338889255, 6.7358610320609404, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint433, viewCenter433);
    
    NXOpen.Point3d scaleAboutPoint434 = new NXOpen.Point3d(18.108393527972101, 2.9988422403010819, 0.0);
    NXOpen.Point3d viewCenter434 = new NXOpen.Point3d(-18.108393527972151, -2.9988422403011397, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint434, viewCenter434);
    
    NXOpen.Point3d scaleAboutPoint435 = new NXOpen.Point3d(22.635491909965186, 3.7485528003763902, 0.0);
    NXOpen.Point3d viewCenter435 = new NXOpen.Point3d(-22.635491909965136, -3.7485528003763902, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint435, viewCenter435);
    
    NXOpen.Point3d scaleAboutPoint436 = new NXOpen.Point3d(28.294364887456435, 4.6856910004704853, 0.0);
    NXOpen.Point3d viewCenter436 = new NXOpen.Point3d(-28.294364887456435, -4.6856910004704853, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint436, viewCenter436);
    
    NXOpen.Session.UndoMarkId markId162;
    markId162 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.IdSymbol idSymbol6 = ((NXOpen.Annotations.IdSymbol)workPart.FindObject("HANDLE R-606056"));
    idSymbol6.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin121 = new NXOpen.Point3d(526.1368568732197, 162.50722914658172, 0.0);
    idSymbol6.AnnotationOrigin = origin121;
    
    int nErrs132;
    nErrs132 = theSession.UpdateManager.DoUpdate(markId162);
    
    NXOpen.Point3d scaleAboutPoint437 = new NXOpen.Point3d(78.39521481556406, -2.0274624521266831, 0.0);
    NXOpen.Point3d viewCenter437 = new NXOpen.Point3d(-78.395214815563989, 2.027462452126664, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint437, viewCenter437);
    
    NXOpen.Point3d scaleAboutPoint438 = new NXOpen.Point3d(97.994018519455025, -1.1263680289592606, 0.0);
    NXOpen.Point3d viewCenter438 = new NXOpen.Point3d(-97.994018519455025, 1.1263680289592606, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint438, viewCenter438);
    
    NXOpen.Point3d scaleAboutPoint439 = new NXOpen.Point3d(122.49252314931877, 1.4079600361991049, 0.0);
    NXOpen.Point3d viewCenter439 = new NXOpen.Point3d(-122.49252314931877, -1.4079600361990754, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint439, viewCenter439);
    
    NXOpen.Point3d origin122 = new NXOpen.Point3d(268.43089164752433, 206.46374147671381, 0.0);
    workPart.Views.WorkView.SetOrigin(origin122);
    
    NXOpen.Point3d origin123 = new NXOpen.Point3d(268.43089164752433, 206.46374147671381, 0.0);
    workPart.Views.WorkView.SetOrigin(origin123);
    
    NXOpen.Point3d scaleAboutPoint440 = new NXOpen.Point3d(59.838301538460321, -84.037614660631789, 0.0);
    NXOpen.Point3d viewCenter440 = new NXOpen.Point3d(-59.838301538460357, 84.037614660631746, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint440, viewCenter440);
    
    NXOpen.Point3d origin124 = new NXOpen.Point3d(254.02130065204958, 263.22213043598839, 0.0);
    workPart.Views.WorkView.SetOrigin(origin124);
    
    NXOpen.Point3d origin125 = new NXOpen.Point3d(254.02130065204958, 263.22213043598839, 0.0);
    workPart.Views.WorkView.SetOrigin(origin125);
    
    NXOpen.Point3d scaleAboutPoint441 = new NXOpen.Point3d(75.897845701355919, 22.549359954750663, 0.0);
    NXOpen.Point3d viewCenter441 = new NXOpen.Point3d(-75.897845701355919, -22.549359954750663, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint441, viewCenter441);
    
    NXOpen.Session.UndoMarkId markId163;
    markId163 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note41 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 22 1"));
    note41.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin126 = new NXOpen.Point3d(343.99874671539618, 306.89089093373025, 0.0);
    note41.AnnotationOrigin = origin126;
    
    int nErrs133;
    nErrs133 = theSession.UpdateManager.DoUpdate(markId163);
    
    NXOpen.Session.UndoMarkId markId164;
    markId164 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note41.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin127 = new NXOpen.Point3d(329.91914635340549, 307.33087844504246, 0.0);
    note41.AnnotationOrigin = origin127;
    
    int nErrs134;
    nErrs134 = theSession.UpdateManager.DoUpdate(markId164);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->撤消
    // ----------------------------------------------
    bool marksRecycled6;
    bool undoUnavailable6;
    theSession.UndoLastNVisibleMarks(1, out marksRecycled6, out undoUnavailable6);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->撤消
    // ----------------------------------------------
    bool marksRecycled7;
    bool undoUnavailable7;
    theSession.UndoLastNVisibleMarks(1, out marksRecycled7, out undoUnavailable7);
    
    NXOpen.Point3d scaleAboutPoint442 = new NXOpen.Point3d(32.999063348415611, 7.4797876923075401, 0.0);
    NXOpen.Point3d viewCenter442 = new NXOpen.Point3d(-32.999063348415646, -7.4797876923075401, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint442, viewCenter442);
    
    NXOpen.Session.UndoMarkId markId165;
    markId165 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Drawings.BaseView baseView1 = ((NXOpen.Drawings.BaseView)workPart.DraftingViews.FindObject("FRONT@1"));
    NXOpen.Point3d drawingReferencePoint27 = new NXOpen.Point3d(306.94880140761416, 270.28061117001499, 0.0);
    baseView1.MoveView(drawingReferencePoint27);
    
    int nErrs135;
    nErrs135 = theSession.UpdateManager.DoUpdate(markId165);
    
    NXOpen.Point3d scaleAboutPoint443 = new NXOpen.Point3d(-24.991290642533386, 79.549742045247257, 0.0);
    NXOpen.Point3d viewCenter443 = new NXOpen.Point3d(24.991290642533386, -79.549742045247214, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint443, viewCenter443);
    
    NXOpen.Point3d scaleAboutPoint444 = new NXOpen.Point3d(-19.148256492307283, 64.202977650677397, 0.0);
    NXOpen.Point3d viewCenter444 = new NXOpen.Point3d(19.148256492307283, -64.202977650677397, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint444, viewCenter444);
    
    NXOpen.Session.UndoMarkId markId166;
    markId166 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.HorizontalDimension horizontalDimension3 = ((NXOpen.Annotations.HorizontalDimension)workPart.FindObject("HANDLE R-123425"));
    horizontalDimension3.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    horizontalDimension3.IsOriginCentered = false;
    
    NXOpen.Point3d origin128;
    origin128 = horizontalDimension3.AnnotationOrigin;
    
    NXOpen.Point3d location4 = new NXOpen.Point3d(289.50013361422083, 331.76954477336761, 0.0);
    bool changed4;
    changed4 = theAnnotationsAngularDimensionUtils.InferQuadrantAngleFromLocation(horizontalDimension3, location4);
    
    NXOpen.Point3d origin129 = new NXOpen.Point3d(289.50013361422083, 331.76954477336761, 0.0);
    horizontalDimension3.AnnotationOrigin = origin129;
    
    int nErrs136;
    nErrs136 = theSession.UpdateManager.DoUpdate(markId166);
    
    NXOpen.Session.UndoMarkId markId167;
    markId167 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note41.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin130 = new NXOpen.Point3d(288.14849197946972, 324.78606299382011, 0.0);
    note41.AnnotationOrigin = origin130;
    
    int nErrs137;
    nErrs137 = theSession.UpdateManager.DoUpdate(markId167);
    
    NXOpen.Point3d scaleAboutPoint445 = new NXOpen.Point3d(34.466861686153173, 6.5329345679636859, 0.0);
    NXOpen.Point3d viewCenter445 = new NXOpen.Point3d(-34.466861686153173, -6.5329345679636486, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint445, viewCenter445);
    
    NXOpen.Point3d scaleAboutPoint446 = new NXOpen.Point3d(43.08357710769144, 9.5741282461536539, 0.0);
    NXOpen.Point3d viewCenter446 = new NXOpen.Point3d(-43.08357710769149, -9.5741282461536539, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint446, viewCenter446);
    
    NXOpen.Point3d scaleAboutPoint447 = new NXOpen.Point3d(53.502481375564578, 14.783580380090161, 0.0);
    NXOpen.Point3d viewCenter447 = new NXOpen.Point3d(-53.502481375564514, -14.783580380090189, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint447, viewCenter447);
    
    NXOpen.Point3d scaleAboutPoint448 = new NXOpen.Point3d(63.79818914027021, 25.079288144795868, 0.0);
    NXOpen.Point3d viewCenter448 = new NXOpen.Point3d(-63.798189140270246, -25.079288144795868, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint448, viewCenter448);
    
    NXOpen.Point3d origin131 = new NXOpen.Point3d(314.50726380716367, 225.68767582096586, 0.0);
    workPart.Views.WorkView.SetOrigin(origin131);
    
    NXOpen.Point3d origin132 = new NXOpen.Point3d(314.50726380716367, 225.68767582096586, 0.0);
    workPart.Views.WorkView.SetOrigin(origin132);
    
    NXOpen.Point3d scaleAboutPoint449 = new NXOpen.Point3d(130.34630022624154, 36.848954072397419, 0.0);
    NXOpen.Point3d viewCenter449 = new NXOpen.Point3d(-130.34630022624171, -36.848954072397419, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint449, viewCenter449);
    
    NXOpen.Point3d scaleAboutPoint450 = new NXOpen.Point3d(103.837052669681, 29.479163257917936, 0.0);
    NXOpen.Point3d viewCenter450 = new NXOpen.Point3d(-103.83705266968114, -29.479163257917936, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint450, viewCenter450);
    
    NXOpen.Point3d scaleAboutPoint451 = new NXOpen.Point3d(83.069642135744715, 23.583330606334339, 0.0);
    NXOpen.Point3d viewCenter451 = new NXOpen.Point3d(-83.069642135744886, -23.583330606334339, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint451, viewCenter451);
    
    NXOpen.Point3d scaleAboutPoint452 = new NXOpen.Point3d(37.451736962895048, -31.538304810859056, 0.0);
    NXOpen.Point3d viewCenter452 = new NXOpen.Point3d(-37.45173696289519, 31.538304810859056, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint452, viewCenter452);
    
    NXOpen.Point3d scaleAboutPoint453 = new NXOpen.Point3d(46.814671203618801, -39.422881013573786, 0.0);
    NXOpen.Point3d viewCenter453 = new NXOpen.Point3d(-46.814671203618978, 39.422881013573843, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint453, viewCenter453);
    
    NXOpen.Session.UndoMarkId markId168;
    markId168 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Point3d drawingReferencePoint28 = new NXOpen.Point3d(351.82752756145931, 270.28061117001499, 0.0);
    baseView1.MoveView(drawingReferencePoint28);
    
    int nErrs138;
    nErrs138 = theSession.UpdateManager.DoUpdate(markId168);
    
    NXOpen.Point3d scaleAboutPoint454 = new NXOpen.Point3d(54.998438914025897, -8.3597627149318683, 0.0);
    NXOpen.Point3d viewCenter454 = new NXOpen.Point3d(-54.998438914026046, 8.3597627149320139, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint454, viewCenter454);
    
    NXOpen.Point3d scaleAboutPoint455 = new NXOpen.Point3d(43.998751131220651, -6.6878101719454932, 0.0);
    NXOpen.Point3d viewCenter455 = new NXOpen.Point3d(-43.998751131220828, 6.6878101719456104, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint455, viewCenter455);
    
    NXOpen.Point3d scaleAboutPoint456 = new NXOpen.Point3d(35.199000904976572, -5.3502481375563953, 0.0);
    NXOpen.Point3d viewCenter456 = new NXOpen.Point3d(-35.199000904976671, 5.3502481375565125, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint456, viewCenter456);
    
    NXOpen.Point3d scaleAboutPoint457 = new NXOpen.Point3d(28.159200723981268, -4.2801985100451363, 0.0);
    NXOpen.Point3d viewCenter457 = new NXOpen.Point3d(-28.15920072398136, 4.2801985100451923, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint457, viewCenter457);
    
    NXOpen.Point3d scaleAboutPoint458 = new NXOpen.Point3d(-0.90109442316741928, -27.032832695022037, 0.0);
    NXOpen.Point3d viewCenter458 = new NXOpen.Point3d(0.90109442316735922, 27.032832695022098, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint458, viewCenter458);
    
    NXOpen.Point3d scaleAboutPoint459 = new NXOpen.Point3d(-4.2801985100451931, -30.862483993483515, 0.0);
    NXOpen.Point3d viewCenter459 = new NXOpen.Point3d(4.2801985100451176, 30.862483993483515, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint459, viewCenter459);
    
    NXOpen.Point3d scaleAboutPoint460 = new NXOpen.Point3d(-12.953232333031343, -32.383080832578536, 0.0);
    NXOpen.Point3d viewCenter460 = new NXOpen.Point3d(12.953232333031391, 32.383080832578514, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint460, viewCenter460);
    
    NXOpen.Session.UndoMarkId markId169;
    markId169 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label25 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-854155"));
    label25.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin133 = new NXOpen.Point3d(491.74919293910551, 272.35644716583738, 0.0);
    label25.AnnotationOrigin = origin133;
    
    int nErrs139;
    nErrs139 = theSession.UpdateManager.DoUpdate(markId169);
    
    NXOpen.Point3d scaleAboutPoint461 = new NXOpen.Point3d(20.063430515836664, -30.975120796379443, 0.0);
    NXOpen.Point3d viewCenter461 = new NXOpen.Point3d(-20.063430515836721, 30.975120796379443, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint461, viewCenter461);
    
    NXOpen.Point3d scaleAboutPoint462 = new NXOpen.Point3d(18.02188846334807, -23.653728608144323, 0.0);
    NXOpen.Point3d viewCenter462 = new NXOpen.Point3d(-18.02188846334807, 23.653728608144299, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint462, viewCenter462);
    
    NXOpen.Point3d scaleAboutPoint463 = new NXOpen.Point3d(15.318605193845883, -18.472435674931745, 0.0);
    NXOpen.Point3d viewCenter463 = new NXOpen.Point3d(-15.318605193845865, 18.472435674931745, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint463, viewCenter463);
    
    NXOpen.Point3d scaleAboutPoint464 = new NXOpen.Point3d(12.975759693610588, -14.59772965531195, 0.0);
    NXOpen.Point3d viewCenter464 = new NXOpen.Point3d(-12.975759693610588, 14.597729655311889, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint464, viewCenter464);
    
    NXOpen.Point3d scaleAboutPoint465 = new NXOpen.Point3d(12.110709047369832, -10.95730818571567, 0.0);
    NXOpen.Point3d viewCenter465 = new NXOpen.Point3d(-12.110709047369941, 10.957308185715549, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint465, viewCenter465);
    
    NXOpen.Point3d scaleAboutPoint466 = new NXOpen.Point3d(22.606656888423732, -2.6528219818048711, 0.0);
    NXOpen.Point3d viewCenter466 = new NXOpen.Point3d(-22.606656888423846, 2.6528219818047845, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint466, viewCenter466);
    
    NXOpen.Point3d scaleAboutPoint467 = new NXOpen.Point3d(28.258321110529572, -3.3160274772560383, 0.0);
    NXOpen.Point3d viewCenter467 = new NXOpen.Point3d(-28.258321110529874, 3.3160274772560383, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint467, viewCenter467);
    
    NXOpen.Point3d scaleAboutPoint468 = new NXOpen.Point3d(35.32290138816203, -4.1450343465700481, 0.0);
    NXOpen.Point3d viewCenter468 = new NXOpen.Point3d(-35.322901388162265, 4.1450343465700481, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint468, viewCenter468);
    
    NXOpen.Point3d scaleAboutPoint469 = new NXOpen.Point3d(44.153626735202565, -5.1812929332125597, 0.0);
    NXOpen.Point3d viewCenter469 = new NXOpen.Point3d(-44.153626735202792, 5.1812929332125597, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint469, viewCenter469);
    
    NXOpen.Point3d scaleAboutPoint470 = new NXOpen.Point3d(54.910441411763429, -6.4766161665156998, 0.0);
    NXOpen.Point3d viewCenter470 = new NXOpen.Point3d(-54.910441411763642, 6.4766161665156767, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint470, viewCenter470);
    
    NXOpen.Point3d scaleAboutPoint471 = new NXOpen.Point3d(114.74874295022374, -34.495020886877128, 0.0);
    NXOpen.Point3d viewCenter471 = new NXOpen.Point3d(-114.74874295022387, 34.4950208868771, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint471, viewCenter471);
    
    NXOpen.Point3d scaleAboutPoint472 = new NXOpen.Point3d(146.95582877827746, -42.678788597284182, 0.0);
    NXOpen.Point3d viewCenter472 = new NXOpen.Point3d(-146.95582877827746, 42.678788597284182, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint472, viewCenter472);
    
    NXOpen.Session.UndoMarkId markId170;
    markId170 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Drawings.SectionView sectionView5 = ((NXOpen.Drawings.SectionView)workPart.DraftingViews.FindObject("SX@SECT-AA"));
    NXOpen.Point3d drawingReferencePoint29 = new NXOpen.Point3d(229.62548834685222, 246.43887696085787, 0.0);
    sectionView5.MoveView(drawingReferencePoint29);
    
    int nErrs140;
    nErrs140 = theSession.UpdateManager.DoUpdate(markId170);
    
    NXOpen.Point3d scaleAboutPoint473 = new NXOpen.Point3d(-4.3998751131220617, 7.1497970588233679, 0.0);
    NXOpen.Point3d viewCenter473 = new NXOpen.Point3d(4.3998751131220617, -7.1497970588233217, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint473, viewCenter473);
    
    NXOpen.Point3d scaleAboutPoint474 = new NXOpen.Point3d(-2.639925067873282, 10.119712760180853, 0.0);
    NXOpen.Point3d viewCenter474 = new NXOpen.Point3d(2.6399250678731354, -10.119712760180743, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint474, viewCenter474);
    
    NXOpen.Point3d scaleAboutPoint475 = new NXOpen.Point3d(-2.1119400542986262, 8.0957702081446836, 0.0);
    NXOpen.Point3d viewCenter475 = new NXOpen.Point3d(2.1119400542984499, -8.0957702081445664, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint475, viewCenter475);
    
    NXOpen.Point3d scaleAboutPoint476 = new NXOpen.Point3d(-1.6895520434389477, 6.47661616651577, 0.0);
    NXOpen.Point3d viewCenter476 = new NXOpen.Point3d(1.6895520434387363, -6.4766161665156528, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint476, viewCenter476);
    
    NXOpen.Point3d scaleAboutPoint477 = new NXOpen.Point3d(-1.3516416347511955, 5.1812929332126156, 0.0);
    NXOpen.Point3d viewCenter477 = new NXOpen.Point3d(1.3516416347509701, -5.1812929332125028, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint477, viewCenter477);
    
    NXOpen.Session.UndoMarkId markId171;
    markId171 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note31.InsertIntoStack(label21, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    label21.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin134 = new NXOpen.Point3d(266.58131086637331, 311.45832737075875, 0.0);
    label21.AnnotationOrigin = origin134;
    
    int nErrs141;
    nErrs141 = theSession.UpdateManager.DoUpdate(markId171);
    
    NXOpen.Point3d scaleAboutPoint478 = new NXOpen.Point3d(-34.962463618895249, 12.975759693610637, 0.0);
    NXOpen.Point3d viewCenter478 = new NXOpen.Point3d(34.962463618895057, -12.975759693610533, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint478, viewCenter478);
    
    NXOpen.Point3d scaleAboutPoint479 = new NXOpen.Point3d(-43.252532312035363, 18.247162069139929, 0.0);
    NXOpen.Point3d viewCenter479 = new NXOpen.Point3d(43.252532312035136, -18.247162069139815, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint479, viewCenter479);
    
    NXOpen.Point3d scaleAboutPoint480 = new NXOpen.Point3d(-53.220889368324762, 25.343280651583196, 0.0);
    NXOpen.Point3d viewCenter480 = new NXOpen.Point3d(53.220889368324528, -25.343280651583079, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint480, viewCenter480);
    
    NXOpen.Point3d scaleAboutPoint481 = new NXOpen.Point3d(-64.766161665157071, 35.199000904976636, 0.0);
    NXOpen.Point3d viewCenter481 = new NXOpen.Point3d(64.766161665156829, -35.19900090497655, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint481, viewCenter481);
    
    NXOpen.Point3d scaleAboutPoint482 = new NXOpen.Point3d(-71.717964343889903, 53.238488868777203, 0.0);
    NXOpen.Point3d viewCenter482 = new NXOpen.Point3d(71.717964343889761, -53.23848886877709, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint482, viewCenter482);
    
    NXOpen.Point3d scaleAboutPoint483 = new NXOpen.Point3d(-118.79662805429611, 28.049203846153294, 0.0);
    NXOpen.Point3d viewCenter483 = new NXOpen.Point3d(118.79662805429592, -28.049203846153201, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint483, viewCenter483);
    
    NXOpen.Point3d scaleAboutPoint484 = new NXOpen.Point3d(-99.877165067871204, 21.559388054298239, 0.0);
    NXOpen.Point3d viewCenter484 = new NXOpen.Point3d(99.877165067870948, -21.559388054298129, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint484, viewCenter484);
    
    NXOpen.Point3d scaleAboutPoint485 = new NXOpen.Point3d(-4.5758701176471295, 90.8134223348397, 0.0);
    NXOpen.Point3d viewCenter485 = new NXOpen.Point3d(4.5758701176467778, -90.813422334839615, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint485, viewCenter485);
    
    NXOpen.Point3d scaleAboutPoint486 = new NXOpen.Point3d(-3.6606960941177045, 72.932329875111606, 0.0);
    NXOpen.Point3d viewCenter486 = new NXOpen.Point3d(3.6606960941173989, -72.932329875111478, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint486, viewCenter486);
    
    NXOpen.Point3d scaleAboutPoint487 = new NXOpen.Point3d(-2.9285568752942006, 58.345863900089292, 0.0);
    NXOpen.Point3d viewCenter487 = new NXOpen.Point3d(2.9285568752938627, -58.345863900089178, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint487, viewCenter487);
    
    NXOpen.Session.UndoMarkId markId172;
    markId172 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note41.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin135 = new NXOpen.Point3d(335.17131599484242, 325.94306823316566, 0.0);
    note41.AnnotationOrigin = origin135;
    
    int nErrs142;
    nErrs142 = theSession.UpdateManager.DoUpdate(markId172);
    
    NXOpen.Point3d scaleAboutPoint488 = new NXOpen.Point3d(-13.696635232144663, 30.997648156958654, 0.0);
    NXOpen.Point3d viewCenter488 = new NXOpen.Point3d(13.696635232144303, -30.997648156958533, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint488, viewCenter488);
    
    NXOpen.Point3d scaleAboutPoint489 = new NXOpen.Point3d(-18.472435674931859, 47.532730822080488, 0.0);
    NXOpen.Point3d viewCenter489 = new NXOpen.Point3d(18.472435674931521, -47.532730822080353, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint489, viewCenter489);
    
    NXOpen.Session.UndoMarkId markId173;
    markId173 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.VerticalDimension verticalDimension1 = ((NXOpen.Annotations.VerticalDimension)workPart.FindObject("HANDLE R-120560"));
    verticalDimension1.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    verticalDimension1.IsOriginCentered = true;
    
    NXOpen.Point3d origin136;
    origin136 = verticalDimension1.AnnotationOrigin;
    
    NXOpen.Point3d location5 = new NXOpen.Point3d(434.85488655773599, 274.35343795487915, 0.0);
    bool changed5;
    changed5 = theAnnotationsAngularDimensionUtils.InferQuadrantAngleFromLocation(verticalDimension1, location5);
    
    NXOpen.Point3d origin137 = new NXOpen.Point3d(434.85488655773599, 274.35343795487915, 0.0);
    verticalDimension1.AnnotationOrigin = origin137;
    
    int nErrs143;
    nErrs143 = theSession.UpdateManager.DoUpdate(markId173);
    
    NXOpen.Point3d scaleAboutPoint490 = new NXOpen.Point3d(167.82883631492822, -16.613928427148885, 0.0);
    NXOpen.Point3d viewCenter490 = new NXOpen.Point3d(-167.82883631492859, 16.613928427149002, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint490, viewCenter490);
    
    NXOpen.Point3d scaleAboutPoint491 = new NXOpen.Point3d(134.26306905194255, -13.291142741719108, 0.0);
    NXOpen.Point3d viewCenter491 = new NXOpen.Point3d(-134.26306905194298, 13.29114274171922, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint491, viewCenter491);
    
    NXOpen.Session.UndoMarkId markId174;
    markId174 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    label25.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin138 = new NXOpen.Point3d(493.92162599635924, 272.39553213644228, 0.0);
    label25.AnnotationOrigin = origin138;
    
    int nErrs144;
    nErrs144 = theSession.UpdateManager.DoUpdate(markId174);
    
    NXOpen.Point3d scaleAboutPoint492 = new NXOpen.Point3d(6.8483176160720625, -7.2087553853391535, 0.0);
    NXOpen.Point3d viewCenter492 = new NXOpen.Point3d(-6.8483176160724835, 7.2087553853392734, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint492, viewCenter492);
    
    NXOpen.Point3d scaleAboutPoint493 = new NXOpen.Point3d(7.2087553853390336, -8.1098498085065351, 0.0);
    NXOpen.Point3d viewCenter493 = new NXOpen.Point3d(-7.2087553853394093, 8.1098498085066666, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint493, viewCenter493);
    
    NXOpen.Point3d scaleAboutPoint494 = new NXOpen.Point3d(5.0686561303165156, -7.0398001809952495, 0.0);
    NXOpen.Point3d viewCenter494 = new NXOpen.Point3d(-5.0686561303168212, 7.0398001809953668, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint494, viewCenter494);
    
    NXOpen.Point3d scaleAboutPoint495 = new NXOpen.Point3d(151.00371388234942, -19.359450497737065, 0.0);
    NXOpen.Point3d viewCenter495 = new NXOpen.Point3d(-151.00371388234976, 19.359450497737182, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint495, viewCenter495);
    
    NXOpen.Point3d scaleAboutPoint496 = new NXOpen.Point3d(121.08456311311929, -14.924376383710008, 0.0);
    NXOpen.Point3d viewCenter496 = new NXOpen.Point3d(-121.08456311311976, 14.924376383710126, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint496, viewCenter496);
    
    NXOpen.Point3d scaleAboutPoint497 = new NXOpen.Point3d(97.092924096287192, -11.714227501176156, 0.0);
    NXOpen.Point3d viewCenter497 = new NXOpen.Point3d(-97.092924096287646, 11.714227501176268, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint497, viewCenter497);
    
    NXOpen.Point3d scaleAboutPoint498 = new NXOpen.Point3d(77.674339277029702, -9.3713820009409243, 0.0);
    NXOpen.Point3d viewCenter498 = new NXOpen.Point3d(-77.674339277030171, 9.3713820009410149, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint498, viewCenter498);
    
    NXOpen.Point3d scaleAboutPoint499 = new NXOpen.Point3d(34.602025849628014, -14.417510770678353, 0.0);
    NXOpen.Point3d viewCenter499 = new NXOpen.Point3d(-34.602025849628411, 14.417510770678474, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint499, viewCenter499);
    
    NXOpen.Point3d scaleAboutPoint500 = new NXOpen.Point3d(-21.683936199100497, -5.0749637912787486, 0.0);
    NXOpen.Point3d viewCenter500 = new NXOpen.Point3d(21.683936199100152, 5.0749637912788641, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint500, viewCenter500);
    
    NXOpen.Point3d scaleAboutPoint501 = new NXOpen.Point3d(-20.184515078949971, -2.3068017233084879, 0.0);
    NXOpen.Point3d viewCenter501 = new NXOpen.Point3d(20.184515078949516, 2.3068017233086082, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint501, viewCenter501);
    
    NXOpen.Point3d scaleAboutPoint502 = new NXOpen.Point3d(-2.3428455002354771, 8.47028757777362, 0.0);
    NXOpen.Point3d viewCenter502 = new NXOpen.Point3d(2.3428455002349962, -8.4702875777734992, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint502, viewCenter502);
    
    NXOpen.Point3d scaleAboutPoint503 = new NXOpen.Point3d(17.571341251764004, 19.824077309682846, 0.0);
    NXOpen.Point3d viewCenter503 = new NXOpen.Point3d(-17.571341251764604, -19.824077309682732, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint503, viewCenter503);
    
    NXOpen.Point3d scaleAboutPoint504 = new NXOpen.Point3d(43.365169114930879, 34.072632876017352, 0.0);
    NXOpen.Point3d viewCenter504 = new NXOpen.Point3d(-43.365169114931305, -34.072632876017238, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint504, viewCenter504);
    
    NXOpen.Point3d scaleAboutPoint505 = new NXOpen.Point3d(74.621881918550045, 50.686561303166286, 0.0);
    NXOpen.Point3d viewCenter505 = new NXOpen.Point3d(-74.621881918550514, -50.686561303166172, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint505, viewCenter505);
    
    NXOpen.Point3d scaleAboutPoint506 = new NXOpen.Point3d(-22.879350588234942, -61.598251583708887, 0.0);
    NXOpen.Point3d viewCenter506 = new NXOpen.Point3d(22.879350588234502, 61.598251583708993, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint506, viewCenter506);
    
    NXOpen.Session.UndoMarkId markId175;
    markId175 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.IdSymbol idSymbol7 = ((NXOpen.Annotations.IdSymbol)workPart.FindObject("HANDLE R-606560"));
    idSymbol7.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin139 = new NXOpen.Point3d(415.19559689068984, 265.68733470317335, 0.0);
    idSymbol7.AnnotationOrigin = origin139;
    
    int nErrs145;
    nErrs145 = theSession.UpdateManager.DoUpdate(markId175);
    
    NXOpen.Session.UndoMarkId markId176;
    markId176 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.IdSymbol idSymbol8 = ((NXOpen.Annotations.IdSymbol)workPart.FindObject("HANDLE R-780889"));
    idSymbol8.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin140 = new NXOpen.Point3d(383.51649607621096, 212.5368433366578, 0.0);
    idSymbol8.AnnotationOrigin = origin140;
    
    int nErrs146;
    nErrs146 = theSession.UpdateManager.DoUpdate(markId176);
    
    NXOpen.Session.UndoMarkId markId177;
    markId177 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.IdSymbol idSymbol9 = ((NXOpen.Annotations.IdSymbol)workPart.FindObject("HANDLE R-606510"));
    idSymbol9.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin141 = new NXOpen.Point3d(284.95929354227667, 267.79927475747195, 0.0);
    idSymbol9.AnnotationOrigin = origin141;
    
    int nErrs147;
    nErrs147 = theSession.UpdateManager.DoUpdate(markId177);
    
    NXOpen.Point3d scaleAboutPoint507 = new NXOpen.Point3d(-202.74624521266506, -71.10198182805253, 0.0);
    NXOpen.Point3d viewCenter507 = new NXOpen.Point3d(202.74624521266469, 71.101981828052672, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint507, viewCenter507);
    
    NXOpen.Point3d scaleAboutPoint508 = new NXOpen.Point3d(-156.84674803257565, -46.744273201808824, 0.0);
    NXOpen.Point3d viewCenter508 = new NXOpen.Point3d(156.84674803257528, 46.744273201808888, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint508, viewCenter508);
    
    NXOpen.Point3d origin142 = new NXOpen.Point3d(377.96913353358724, 245.24375497755665, 0.0);
    workPart.Views.WorkView.SetOrigin(origin142);
    
    NXOpen.Point3d origin143 = new NXOpen.Point3d(377.96913353358724, 245.24375497755665, 0.0);
    workPart.Views.WorkView.SetOrigin(origin143);
    
    NXOpen.Point3d scaleAboutPoint509 = new NXOpen.Point3d(-5.8571137505882414, 7.8845762027148245, 0.0);
    NXOpen.Point3d viewCenter509 = new NXOpen.Point3d(5.8571137505879216, -7.8845762027146931, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint509, viewCenter509);
    
    NXOpen.Point3d scaleAboutPoint510 = new NXOpen.Point3d(-4.1450343465702044, 3.4241588080361902, 0.0);
    NXOpen.Point3d viewCenter510 = new NXOpen.Point3d(4.1450343465698438, -3.4241588080360246, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint510, viewCenter510);
    
    NXOpen.Point3d scaleAboutPoint511 = new NXOpen.Point3d(-3.316027477256188, 2.1626266156018006, 0.0);
    NXOpen.Point3d viewCenter511 = new NXOpen.Point3d(3.3160274772558394, -2.1626266156017167, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint511, viewCenter511);
    
    NXOpen.Point3d scaleAboutPoint512 = new NXOpen.Point3d(-2.6528219818049892, 1.3840810339851544, 0.0);
    NXOpen.Point3d viewCenter512 = new NXOpen.Point3d(2.6528219818046428, -1.3840810339850966, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint512, viewCenter512);
    
    NXOpen.Point3d scaleAboutPoint513 = new NXOpen.Point3d(-2.1222575854440224, 0.64590448252644461, 0.0);
    NXOpen.Point3d viewCenter513 = new NXOpen.Point3d(2.122257585443676, -0.64590448252632915, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint513, viewCenter513);
    
    NXOpen.Point3d scaleAboutPoint514 = new NXOpen.Point3d(-1.6239884132093825, 0.29527062058359405, 0.0);
    NXOpen.Point3d viewCenter514 = new NXOpen.Point3d(1.6239884132090379, -0.29527062058339709, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint514, viewCenter514);
    
    NXOpen.Point3d scaleAboutPoint515 = new NXOpen.Point3d(-1.2991907305675452, 0.11810824823347946, 0.0);
    NXOpen.Point3d viewCenter515 = new NXOpen.Point3d(1.2991907305672006, -0.11810824823331205, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint515, viewCenter515);
    
    NXOpen.Point3d scaleAboutPoint516 = new NXOpen.Point3d(-4.2518969364024697, -1.7480020738541935, 0.0);
    NXOpen.Point3d viewCenter516 = new NXOpen.Point3d(4.2518969364021313, 1.7480020738543669, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint516, viewCenter516);
    
    NXOpen.Point3d scaleAboutPoint517 = new NXOpen.Point3d(-5.1377087981529614, -1.4172989788006849, 0.0);
    NXOpen.Point3d viewCenter517 = new NXOpen.Point3d(5.1377087981526168, 1.4172989788008523, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint517, viewCenter517);
    
    NXOpen.Point3d scaleAboutPoint518 = new NXOpen.Point3d(-5.8315947565241686, 8.6166499069641227e-14, 0.0);
    NXOpen.Point3d viewCenter518 = new NXOpen.Point3d(5.8315947565238231, 8.6166499069641227e-14, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint518, viewCenter518);
    
    NXOpen.Point3d scaleAboutPoint519 = new NXOpen.Point3d(-6.0899565495347225, 2.3068017233086264, 0.0);
    NXOpen.Point3d viewCenter519 = new NXOpen.Point3d(6.0899565495343762, -2.3068017233084568, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint519, viewCenter519);
    
    NXOpen.Point3d scaleAboutPoint520 = new NXOpen.Point3d(-5.8823443944369513, 5.4209840497751918, 0.0);
    NXOpen.Point3d viewCenter520 = new NXOpen.Point3d(5.8823443944366058, -5.4209840497749608, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint520, viewCenter520);
    
    NXOpen.Point3d scaleAboutPoint521 = new NXOpen.Point3d(-20.184515078949911, -22.635491909964976, 0.0);
    NXOpen.Point3d viewCenter521 = new NXOpen.Point3d(20.184515078949563, 22.635491909965204, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint521, viewCenter521);
    
    NXOpen.Point3d scaleAboutPoint522 = new NXOpen.Point3d(-24.509768310153433, -27.03283269502192, 0.0);
    NXOpen.Point3d viewCenter522 = new NXOpen.Point3d(24.509768310153071, 27.032832695022083, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint522, viewCenter522);
    
    NXOpen.Session.UndoMarkId markId178;
    markId178 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.TargetPoint targetPoint5 = ((NXOpen.Annotations.TargetPoint)workPart.Annotations.TargetPoints.FindObject("HANDLE R-609224"));
    targetPoint5.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin144 = new NXOpen.Point3d(370.56207393810377, 251.5933103425302, 0.0);
    targetPoint5.AnnotationOrigin = origin144;
    
    int nErrs148;
    nErrs148 = theSession.UpdateManager.DoUpdate(markId178);
    
    NXOpen.Point3d scaleAboutPoint523 = new NXOpen.Point3d(-18.472435674931827, -7.659302596922827, 0.0);
    NXOpen.Point3d viewCenter523 = new NXOpen.Point3d(18.472435674931511, 7.6593025969229585, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint523, viewCenter523);
    
    NXOpen.Point3d scaleAboutPoint524 = new NXOpen.Point3d(-13.876854116778118, -6.1274420775382605, 0.0);
    NXOpen.Point3d viewCenter524 = new NXOpen.Point3d(13.876854116777757, 6.1274420775383804, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint524, viewCenter524);
    
    NXOpen.Point3d scaleAboutPoint525 = new NXOpen.Point3d(-10.668957970302174, -4.7577785543238145, 0.0);
    NXOpen.Point3d viewCenter525 = new NXOpen.Point3d(10.668957970301825, 4.7577785543239353, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint525, viewCenter525);
    
    NXOpen.Point3d scaleAboutPoint526 = new NXOpen.Point3d(-8.419826290076351, -3.8062228434590422, 0.0);
    NXOpen.Point3d viewCenter526 = new NXOpen.Point3d(8.4198262900760046, 3.8062228434591576, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint526, viewCenter526);
    
    NXOpen.Point3d scaleAboutPoint527 = new NXOpen.Point3d(-6.6435889631287726, -3.0449782747672418, 0.0);
    NXOpen.Point3d viewCenter527 = new NXOpen.Point3d(6.6435889631284262, 3.0449782747673266, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint527, viewCenter527);
    
    NXOpen.Point3d scaleAboutPoint528 = new NXOpen.Point3d(-5.3148711705030554, -2.4359826198137506, 0.0);
    NXOpen.Point3d viewCenter528 = new NXOpen.Point3d(5.3148711705027107, 2.4359826198138985, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint528, viewCenter528);
    
    NXOpen.Point3d scaleAboutPoint529 = new NXOpen.Point3d(-4.251896936402483, -1.9487860958510004, 0.0);
    NXOpen.Point3d viewCenter529 = new NXOpen.Point3d(4.2518969364021384, 1.9487860958511185, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint529, viewCenter529);
    
    NXOpen.Point3d scaleAboutPoint530 = new NXOpen.Point3d(-3.4015175491220093, -1.5590288766807918, 0.0);
    NXOpen.Point3d viewCenter530 = new NXOpen.Point3d(3.4015175491216705, 1.5590288766809062, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint530, viewCenter530);
    
    NXOpen.Point3d scaleAboutPoint531 = new NXOpen.Point3d(-2.7212140392976436, -1.2472231013446202, 0.0);
    NXOpen.Point3d viewCenter531 = new NXOpen.Point3d(2.7212140392973034, 1.2472231013447337, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint531, viewCenter531);
    
    NXOpen.Point3d scaleAboutPoint532 = new NXOpen.Point3d(-3.9306425012076271, -1.239664173457683, 0.0);
    NXOpen.Point3d viewCenter532 = new NXOpen.Point3d(3.9306425012072892, 1.2396641734577964, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint532, viewCenter532);
    
    NXOpen.Point3d scaleAboutPoint533 = new NXOpen.Point3d(-3.3863996933481384, -1.0884856157189349, 0.0);
    NXOpen.Point3d viewCenter533 = new NXOpen.Point3d(3.3863996933477996, 1.0884856157190477, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint533, viewCenter533);
    
    NXOpen.Session.UndoMarkId markId179;
    markId179 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    targetPoint5.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin145 = new NXOpen.Point3d(370.12126324755218, 250.9012007783486, 0.0);
    targetPoint5.AnnotationOrigin = origin145;
    
    int nErrs149;
    nErrs149 = theSession.UpdateManager.DoUpdate(markId179);
    
    NXOpen.Point3d scaleAboutPoint534 = new NXOpen.Point3d(-1.2384547449959968, 0.32896454163954586, 0.0);
    NXOpen.Point3d viewCenter534 = new NXOpen.Point3d(1.2384547449956549, -0.32896454163948935, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint534, viewCenter534);
    
    NXOpen.Point3d scaleAboutPoint535 = new NXOpen.Point3d(-1.5480684312449493, 0.41120567704942362, 0.0);
    NXOpen.Point3d viewCenter535 = new NXOpen.Point3d(1.5480684312446105, -0.41120567704936711, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint535, viewCenter535);
    
    NXOpen.Point3d scaleAboutPoint536 = new NXOpen.Point3d(-1.9350855390561463, 0.54424280785952373, 0.0);
    NXOpen.Point3d viewCenter536 = new NXOpen.Point3d(1.9350855390558035, -0.54424280785946566, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint536, viewCenter536);
    
    NXOpen.Point3d scaleAboutPoint537 = new NXOpen.Point3d(-2.4188569238201398, 0.68030350982442389, 0.0);
    NXOpen.Point3d viewCenter537 = new NXOpen.Point3d(2.4188569238197997, -0.68030350982431043, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint537, viewCenter537);
    
    NXOpen.Point3d scaleAboutPoint538 = new NXOpen.Point3d(-3.0235711547751301, 0.85037938728053053, 0.0);
    NXOpen.Point3d viewCenter538 = new NXOpen.Point3d(3.0235711547747912, -0.85037938728038864, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint538, viewCenter538);
    
    NXOpen.Point3d scaleAboutPoint539 = new NXOpen.Point3d(-3.7794639434688757, 1.0629742341006343, 0.0);
    NXOpen.Point3d viewCenter539 = new NXOpen.Point3d(3.7794639434685409, -1.0629742341005211, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint539, viewCenter539);
    
    NXOpen.Point3d scaleAboutPoint540 = new NXOpen.Point3d(-4.7243299293360606, 1.3287177926257749, 0.0);
    NXOpen.Point3d viewCenter540 = new NXOpen.Point3d(4.7243299293357159, -1.3287177926256641, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint540, viewCenter540);
    
    NXOpen.Point3d scaleAboutPoint541 = new NXOpen.Point3d(-5.8131403427376886, 1.660897240782188, 0.0);
    NXOpen.Point3d viewCenter541 = new NXOpen.Point3d(5.8131403427373503, -1.6608972407821034, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint541, viewCenter541);
    
    NXOpen.Point3d scaleAboutPoint542 = new NXOpen.Point3d(-7.1510853422566472, 2.0761215509777542, 0.0);
    NXOpen.Point3d viewCenter542 = new NXOpen.Point3d(7.1510853422563008, -2.0761215509776196, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint542, viewCenter542);
    
    NXOpen.Point3d scaleAboutPoint543 = new NXOpen.Point3d(-8.9388566778207625, 2.7393270464289872, 0.0);
    NXOpen.Point3d viewCenter543 = new NXOpen.Point3d(8.938856677820425, -2.7393270464287944, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint543, viewCenter543);
    
    NXOpen.Point3d scaleAboutPoint544 = new NXOpen.Point3d(13.876854116777766, -44.874502273736368, 0.0);
    NXOpen.Point3d viewCenter544 = new NXOpen.Point3d(-13.876854116778127, 44.874502273736567, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint544, viewCenter544);
    
    NXOpen.Point3d scaleAboutPoint545 = new NXOpen.Point3d(16.895520434388548, -56.09312784217051, 0.0);
    NXOpen.Point3d viewCenter545 = new NXOpen.Point3d(-16.895520434388942, 56.093127842170681, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint545, viewCenter545);
    
    NXOpen.Session.UndoMarkId markId180;
    markId180 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note42 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 36 1"));
    note42.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin146 = new NXOpen.Point3d(366.98769823875182, 340.65224295377323, 0.0);
    note42.AnnotationOrigin = origin146;
    
    NXOpen.Annotations.Note note43 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 37 1"));
    note43.InsertIntoStack(note42, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    int nErrs150;
    nErrs150 = theSession.UpdateManager.DoUpdate(markId180);
    
    NXOpen.Session.UndoMarkId markId181;
    markId181 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note43.InsertIntoStack(note42, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    note42.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin147 = new NXOpen.Point3d(363.32700214463421, 353.88706729404464, 0.0);
    note42.AnnotationOrigin = origin147;
    
    int nErrs151;
    nErrs151 = theSession.UpdateManager.DoUpdate(markId181);
    
    NXOpen.Point3d scaleAboutPoint546 = new NXOpen.Point3d(60.542281556559509, 45.61790517284966, 0.0);
    NXOpen.Point3d viewCenter546 = new NXOpen.Point3d(-60.542281556559836, -45.617905172849518, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint546, viewCenter546);
    
    NXOpen.Point3d scaleAboutPoint547 = new NXOpen.Point3d(75.677851945699373, 60.190291547509894, 0.0);
    NXOpen.Point3d viewCenter547 = new NXOpen.Point3d(-75.677851945699786, -60.190291547509808, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint547, viewCenter547);
    
    NXOpen.Point3d scaleAboutPoint548 = new NXOpen.Point3d(110.87685285067579, 84.917589683255912, 0.0);
    NXOpen.Point3d viewCenter548 = new NXOpen.Point3d(-110.87685285067637, -84.91758968325577, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint548, viewCenter548);
    
    NXOpen.Point3d scaleAboutPoint549 = new NXOpen.Point3d(-95.147299321264839, -9.8997190045245542, 0.0);
    NXOpen.Point3d viewCenter549 = new NXOpen.Point3d(95.147299321264427, 9.8997190045247372, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint549, viewCenter549);
    
    NXOpen.Point3d scaleAboutPoint550 = new NXOpen.Point3d(-76.117839457011954, -7.9197752036196443, 0.0);
    NXOpen.Point3d viewCenter550 = new NXOpen.Point3d(76.117839457011513, 7.9197752036197908, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint550, viewCenter550);
    
    NXOpen.Point3d origin148 = new NXOpen.Point3d(331.221113444195, 190.35690896462992, 0.0);
    workPart.Views.WorkView.SetOrigin(origin148);
    
    NXOpen.Point3d origin149 = new NXOpen.Point3d(331.221113444195, 190.35690896462992, 0.0);
    workPart.Views.WorkView.SetOrigin(origin149);
    
    NXOpen.Point3d scaleAboutPoint551 = new NXOpen.Point3d(5.2798501357462584, -17.951490461537983, 0.0);
    NXOpen.Point3d viewCenter551 = new NXOpen.Point3d(-5.2798501357467273, 17.951490461538128, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint551, viewCenter551);
    
    NXOpen.Point3d scaleAboutPoint552 = new NXOpen.Point3d(11.43967529411721, -14.079600361990559, 0.0);
    NXOpen.Point3d viewCenter552 = new NXOpen.Point3d(-11.43967529411765, 14.079600361990707, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint552, viewCenter552);
    
    NXOpen.Session.UndoMarkId markId182;
    markId182 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Drawings.ProjectedView projectedView6 = ((NXOpen.Drawings.ProjectedView)workPart.DraftingViews.FindObject("ORTHO@BOTTOM"));
    NXOpen.Point3d drawingReferencePoint30 = new NXOpen.Point3d(342.90095051698125, 155.81757716387764, 0.0);
    projectedView6.MoveView(drawingReferencePoint30);
    
    int nErrs152;
    nErrs152 = theSession.UpdateManager.DoUpdate(markId182);
    
    NXOpen.Point3d scaleAboutPoint553 = new NXOpen.Point3d(57.748360859726986, -52.798501357464687, 0.0);
    NXOpen.Point3d viewCenter553 = new NXOpen.Point3d(-57.748360859727399, 52.798501357464872, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint553, viewCenter553);
    
    NXOpen.Point3d scaleAboutPoint554 = new NXOpen.Point3d(50.598563800903598, -40.478851040722951, 0.0);
    NXOpen.Point3d viewCenter554 = new NXOpen.Point3d(-50.598563800904039, 40.4788510407231, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint554, viewCenter554);
    
    NXOpen.Session.UndoMarkId markId183;
    markId183 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Point3d drawingReferencePoint31 = new NXOpen.Point3d(350.38073820928889, 155.81757716387764, 0.0);
    projectedView6.MoveView(drawingReferencePoint31);
    
    int nErrs153;
    nErrs153 = theSession.UpdateManager.DoUpdate(markId183);
    
    NXOpen.Session.UndoMarkId markId184;
    markId184 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label26 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-124493"));
    label26.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin150 = new NXOpen.Point3d(258.95316471116524, 174.7813510641806, 0.0);
    label26.AnnotationOrigin = origin150;
    
    int nErrs154;
    nErrs154 = theSession.UpdateManager.DoUpdate(markId184);
    
    NXOpen.Point3d scaleAboutPoint555 = new NXOpen.Point3d(140.44401361085633, -38.718900995474122, 0.0);
    NXOpen.Point3d viewCenter555 = new NXOpen.Point3d(-140.44401361085659, 38.7189009954743, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint555, viewCenter555);
    
    NXOpen.Point3d scaleAboutPoint556 = new NXOpen.Point3d(176.87497954750697, -45.318713665157283, 0.0);
    NXOpen.Point3d viewCenter556 = new NXOpen.Point3d(-176.87497954750728, 45.318713665157389, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint556, viewCenter556);
    
    NXOpen.Point3d scaleAboutPoint557 = new NXOpen.Point3d(223.29366199094474, -52.248516968324488, 0.0);
    NXOpen.Point3d viewCenter557 = new NXOpen.Point3d(-223.29366199094511, 52.24851696832458, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint557, viewCenter557);
    
    NXOpen.Point3d scaleAboutPoint558 = new NXOpen.Point3d(58.43584134615238, -59.123321832577808, 0.0);
    NXOpen.Point3d viewCenter558 = new NXOpen.Point3d(-58.435841346152607, 59.123321832577808, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint558, viewCenter558);
    
    NXOpen.Point3d scaleAboutPoint559 = new NXOpen.Point3d(36.848954072397213, -45.648704298641412, 0.0);
    NXOpen.Point3d viewCenter559 = new NXOpen.Point3d(-36.848954072397397, 45.648704298641455, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint559, viewCenter559);
    
    NXOpen.Point3d scaleAboutPoint560 = new NXOpen.Point3d(26.399250678732255, -36.078975927600958, 0.0);
    NXOpen.Point3d viewCenter560 = new NXOpen.Point3d(-26.399250678732546, 36.078975927600958, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint560, viewCenter560);
    
    NXOpen.Point3d scaleAboutPoint561 = new NXOpen.Point3d(19.3594504977371, -28.511190733031022, 0.0);
    NXOpen.Point3d viewCenter561 = new NXOpen.Point3d(-19.359450497737157, 28.511190733031022, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint561, viewCenter561);
    
    NXOpen.Point3d scaleAboutPoint562 = new NXOpen.Point3d(14.361192369230396, -22.527360579185007, 0.0);
    NXOpen.Point3d viewCenter562 = new NXOpen.Point3d(-14.361192369230514, 22.527360579185007, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint562, viewCenter562);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->复制(C)
    // ----------------------------------------------
    workPart.PmiManager.RestoreUnpastedObjects();
    
    // ----------------------------------------------
    //   菜单：编辑(E)->粘贴(P)
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId185;
    markId185 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder9;
    cutCopyPasteBuilder9 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder9.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder9.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation9 = new NXOpen.Point3d(244.63839102437805, 175.4028334239066, 0.0);
    cutCopyPasteBuilder9.SetDefaultToPoint(droplocation9);
    
    cutCopyPasteBuilder9.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects23 = new NXOpen.TaggedObject[1];
    NXOpen.Annotations.Note note44 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 26 1"));
    objects23[0] = note44;
    bool added9;
    added9 = cutCopyPasteBuilder9.ObjectsToCopy.Add(objects23);
    
    NXOpen.Point3d origin151 = new NXOpen.Point3d(244.63839102437805, 175.4028334239066, 0.0);
    NXOpen.Vector3d normal9 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane9;
    plane9 = workPart.Planes.CreatePlane(origin151, normal9, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder9.PlaneToRestrictMotion = plane9;
    
    cutCopyPasteBuilder9.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder9.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder9.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder9.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder9.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder9.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder9.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder9.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder9.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId185, "粘贴 对话框");
    
    cutCopyPasteBuilder9.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder9.Transform.SetMotionToTwoDimensions(plane9);
    
    cutCopyPasteBuilder9.InitPaste();
    
    cutCopyPasteBuilder9.CutCopyPasteLeader.IsLeaderSelection = false;
    
    NXOpen.Point3d scaleAboutPoint563 = new NXOpen.Point3d(23.653728608144192, -7.2087553853392654, 0.0);
    NXOpen.Point3d viewCenter563 = new NXOpen.Point3d(-23.653728608144341, 7.2087553853391899, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint563, viewCenter563);
    
    NXOpen.Point3d scaleAboutPoint564 = new NXOpen.Point3d(18.922982886515356, -5.5867854236379211, 0.0);
    NXOpen.Point3d viewCenter564 = new NXOpen.Point3d(-18.922982886515477, 5.5867854236378154, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint564, viewCenter564);
    
    NXOpen.Point3d scaleAboutPoint565 = new NXOpen.Point3d(15.13838630921229, -4.4694283389103617, 0.0);
    NXOpen.Point3d viewCenter565 = new NXOpen.Point3d(-15.138386309212398, 4.4694283389102543, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint565, viewCenter565);
    
    NXOpen.Point3d scaleAboutPoint566 = new NXOpen.Point3d(11.995368961204377, -3.5755426711282992, 0.0);
    NXOpen.Point3d viewCenter566 = new NXOpen.Point3d(-11.995368961204493, 3.5755426711281841, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint566, viewCenter566);
    
    NXOpen.Point3d scaleAboutPoint567 = new NXOpen.Point3d(9.5962951689634686, -2.8604341369026542, 0.0);
    NXOpen.Point3d viewCenter567 = new NXOpen.Point3d(-9.5962951689636231, 2.8604341369025388, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint567, viewCenter567);
    
    NXOpen.Point3d coordinates8 = new NXOpen.Point3d(267.43860299489808, 173.91062105914389, 0.0);
    NXOpen.Point point12;
    point12 = workPart.Points.CreatePoint(coordinates8);
    
    NXOpen.Point3d point13 = new NXOpen.Point3d(267.43860299489808, 173.91062105914389, 0.0);
    cutCopyPasteBuilder9.CutCopyPasteLeader.Selection.SetValue(point12, workPart.Views.WorkView, point13);
    
    NXOpen.Session.UndoMarkId markId186;
    markId186 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "粘贴");
    
    NXOpen.Matrix3x3 rot5 = new NXOpen.Matrix3x3();
    rot5.Xx = 1.0;
    rot5.Xy = 0.0;
    rot5.Xz = 0.0;
    rot5.Yx = 0.0;
    rot5.Yy = 1.0;
    rot5.Yz = 0.0;
    rot5.Zx = 0.0;
    rot5.Zy = 0.0;
    rot5.Zz = 1.0;
    NXOpen.Vector3d trans5 = new NXOpen.Vector3d(22.800211970520024, -1.4922123647627075, 0.0);
    cutCopyPasteBuilder9.CutCopyPasteLeader.SetMoveOnCommit(rot5, trans5);
    
    NXOpen.NXObject nXObject8;
    nXObject8 = cutCopyPasteBuilder9.Commit();
    
    theSession.DeleteUndoMark(markId186, null);
    
    theSession.SetUndoMarkName(markId185, "粘贴");
    
    cutCopyPasteBuilder9.Destroy();
    
    workPart.Points.DeletePoint(point12);
    
    NXOpen.Session.UndoMarkId markId187;
    markId187 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Start");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder10;
    cutCopyPasteBuilder10 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder10.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder10.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation10 = new NXOpen.Point3d(244.63839102437805, 175.4028334239066, 0.0);
    cutCopyPasteBuilder10.SetDefaultToPoint(droplocation10);
    
    cutCopyPasteBuilder10.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects24 = new NXOpen.TaggedObject[1];
    objects24[0] = note44;
    bool added10;
    added10 = cutCopyPasteBuilder10.ObjectsToCopy.Add(objects24);
    
    NXOpen.Point3d origin152 = new NXOpen.Point3d(244.63839102437805, 175.4028334239066, 0.0);
    NXOpen.Vector3d normal10 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane10;
    plane10 = workPart.Planes.CreatePlane(origin152, normal10, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder10.PlaneToRestrictMotion = plane10;
    
    cutCopyPasteBuilder10.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder10.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder10.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder10.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder10.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder10.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder10.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder10.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder10.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId187, "粘贴 对话框");
    
    cutCopyPasteBuilder10.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder10.Transform.SetMotionToTwoDimensions(plane10);
    
    cutCopyPasteBuilder10.InitPaste();
    
    cutCopyPasteBuilder10.CutCopyPasteLeader.IsLeaderSelection = false;
    
    // ----------------------------------------------
    //   对话开始 粘贴
    // ----------------------------------------------
    cutCopyPasteBuilder10.Destroy();
    
    theSession.UndoToMark(markId187, null);
    
    theSession.DeleteUndoMark(markId187, null);
    
    int nErrs155;
    nErrs155 = theSession.UpdateManager.DoUpdate(markId185);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId188;
    markId188 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId189;
    markId189 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects25 = new NXOpen.TaggedObject[1];
    objects25[0] = note44;
    int nErrs156;
    nErrs156 = theSession.UpdateManager.AddObjectsToDeleteList(objects25);
    
    NXOpen.Session.UndoMarkId id14;
    id14 = theSession.NewestVisibleUndoMark;
    
    int nErrs157;
    nErrs157 = theSession.UpdateManager.DoUpdate(id14);
    
    theSession.DeleteUndoMark(markId188, null);
    
    NXOpen.Point3d scaleAboutPoint568 = new NXOpen.Point3d(-26.057632266493364, -5.0196005499194492, 0.0);
    NXOpen.Point3d viewCenter568 = new NXOpen.Point3d(26.057632266493254, 5.0196005499193381, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint568, viewCenter568);
    
    NXOpen.Point3d scaleAboutPoint569 = new NXOpen.Point3d(-27.866164817567274, -5.2595079291435418, 0.0);
    NXOpen.Point3d viewCenter569 = new NXOpen.Point3d(27.866164817567121, 5.2595079291434264, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint569, viewCenter569);
    
    NXOpen.Point3d scaleAboutPoint570 = new NXOpen.Point3d(-31.372503436996244, -5.0749637912788579, 0.0);
    NXOpen.Point3d viewCenter570 = new NXOpen.Point3d(31.372503436996126, 5.0749637912787424, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint570, viewCenter570);
    
    NXOpen.Point3d scaleAboutPoint571 = new NXOpen.Point3d(-29.988422403011082, -1.1534008616543274, 0.0);
    NXOpen.Point3d viewCenter571 = new NXOpen.Point3d(29.988422403011022, 1.1534008616542191, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint571, viewCenter571);
    
    NXOpen.Point3d scaleAboutPoint572 = new NXOpen.Point3d(-28.654802656723319, 2.8835021541356078, 0.0);
    NXOpen.Point3d viewCenter572 = new NXOpen.Point3d(28.654802656723245, -2.8835021541357428, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint572, viewCenter572);
    
    NXOpen.Point3d scaleAboutPoint573 = new NXOpen.Point3d(-32.214125628234562, 42.801985100451361, 0.0);
    NXOpen.Point3d viewCenter573 = new NXOpen.Point3d(32.21412562823447, -42.801985100451567, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint573, viewCenter573);
    
    NXOpen.Point3d scaleAboutPoint574 = new NXOpen.Point3d(-39.704473020813552, 55.192033419003081, 0.0);
    NXOpen.Point3d viewCenter574 = new NXOpen.Point3d(39.704473020813438, -55.192033419003316, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint574, viewCenter574);
    
    NXOpen.Point3d scaleAboutPoint575 = new NXOpen.Point3d(20.415420524886333, -61.598251583709029, 0.0);
    NXOpen.Point3d viewCenter575 = new NXOpen.Point3d(-20.41542052488651, 61.598251583708851, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint575, viewCenter575);
    
    NXOpen.Point3d scaleAboutPoint576 = new NXOpen.Point3d(16.33233641990897, -49.278601266967208, 0.0);
    NXOpen.Point3d viewCenter576 = new NXOpen.Point3d(-16.332336419909204, 49.278601266967073, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint576, viewCenter576);
    
    NXOpen.Point3d scaleAboutPoint577 = new NXOpen.Point3d(13.065869135927175, -39.422881013573765, 0.0);
    NXOpen.Point3d viewCenter577 = new NXOpen.Point3d(-13.065869135927398, 39.422881013573615, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint577, viewCenter577);
    
    NXOpen.Point3d scaleAboutPoint578 = new NXOpen.Point3d(10.452695308741678, -31.538304810859067, 0.0);
    NXOpen.Point3d viewCenter578 = new NXOpen.Point3d(-10.452695308741919, 31.538304810858872, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint578, viewCenter578);
    
    NXOpen.Point3d scaleAboutPoint579 = new NXOpen.Point3d(8.3621562469933455, -25.23064384868729, 0.0);
    NXOpen.Point3d viewCenter579 = new NXOpen.Point3d(-8.3621562469935871, 25.230643848687073, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint579, viewCenter579);
    
    NXOpen.Session.UndoMarkId markId190;
    markId190 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label27 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-370675"));
    label27.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin153 = new NXOpen.Point3d(351.60400748751891, 143.68114238151952, 0.0);
    label27.AnnotationOrigin = origin153;
    
    int nErrs158;
    nErrs158 = theSession.UpdateManager.DoUpdate(markId190);
    
    NXOpen.Session.UndoMarkId markId191;
    markId191 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label28 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-370489"));
    label28.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin154 = new NXOpen.Point3d(353.10342860766946, 137.91413807324813, 0.0);
    label28.AnnotationOrigin = origin154;
    
    int nErrs159;
    nErrs159 = theSession.UpdateManager.DoUpdate(markId191);
    
    NXOpen.Session.UndoMarkId markId192;
    markId192 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label29 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-118570"));
    label29.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin155 = new NXOpen.Point3d(381.93845014902621, 99.621229466325815, 0.0);
    label29.AnnotationOrigin = origin155;
    
    int nErrs160;
    nErrs160 = theSession.UpdateManager.DoUpdate(markId192);
    
    NXOpen.Session.UndoMarkId markId193;
    markId193 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note45 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 26 1"));
    note45.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin156 = new NXOpen.Point3d(339.83931869864534, 97.660448001513529, 0.0);
    note45.AnnotationOrigin = origin156;
    
    int nErrs161;
    nErrs161 = theSession.UpdateManager.DoUpdate(markId193);
    
    NXOpen.Point3d scaleAboutPoint580 = new NXOpen.Point3d(48.096815930982977, -22.606656888423831, 0.0);
    NXOpen.Point3d viewCenter580 = new NXOpen.Point3d(-48.096815930983212, 22.606656888423579, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint580, viewCenter580);
    
    NXOpen.Point3d scaleAboutPoint581 = new NXOpen.Point3d(59.976844806021987, -28.546671325943318, 0.0);
    NXOpen.Point3d viewCenter581 = new NXOpen.Point3d(-59.976844806022228, 28.546671325943102, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint581, viewCenter581);
    
    NXOpen.Session.UndoMarkId markId194;
    markId194 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.RadiusDimension radiusDimension2 = ((NXOpen.Annotations.RadiusDimension)workPart.FindObject("HANDLE R-590616"));
    radiusDimension2.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    radiusDimension2.IsOriginCentered = false;
    
    NXOpen.Point3d origin157;
    origin157 = radiusDimension2.AnnotationOrigin;
    
    NXOpen.Point3d location6 = new NXOpen.Point3d(344.96474377762144, 76.250444507055732, 0.0);
    bool changed6;
    changed6 = theAnnotationsAngularDimensionUtils.InferQuadrantAngleFromLocation(radiusDimension2, location6);
    
    NXOpen.Point3d origin158 = new NXOpen.Point3d(344.96474377762144, 76.250444507055732, 0.0);
    radiusDimension2.AnnotationOrigin = origin158;
    
    int nErrs162;
    nErrs162 = theSession.UpdateManager.DoUpdate(markId194);
    
    NXOpen.Session.UndoMarkId markId195;
    markId195 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note45.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin159 = new NXOpen.Point3d(347.66802704712364, 92.650363008702598, 0.0);
    note45.AnnotationOrigin = origin159;
    
    int nErrs163;
    nErrs163 = theSession.UpdateManager.DoUpdate(markId195);
    
    NXOpen.Point3d scaleAboutPoint582 = new NXOpen.Point3d(-33.700931426460841, -23.788892771619452, 0.0);
    NXOpen.Point3d viewCenter582 = new NXOpen.Point3d(33.700931426460599, 23.788892771619228, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint582, viewCenter582);
    
    NXOpen.Point3d scaleAboutPoint583 = new NXOpen.Point3d(-43.928353129410823, -24.104275819728038, 0.0);
    NXOpen.Point3d viewCenter583 = new NXOpen.Point3d(43.928353129410574, 24.104275819727814, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint583, viewCenter583);
    
    NXOpen.Point3d scaleAboutPoint584 = new NXOpen.Point3d(-56.318401447962557, -18.30348047058791, 0.0);
    NXOpen.Point3d viewCenter584 = new NXOpen.Point3d(56.318401447962323, 18.303480470587697, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint584, viewCenter584);
    
    NXOpen.Point3d scaleAboutPoint585 = new NXOpen.Point3d(99.965162570133117, -36.958950950225464, 0.0);
    NXOpen.Point3d viewCenter585 = new NXOpen.Point3d(-99.965162570133415, 36.95895095022523, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint585, viewCenter585);
    
    NXOpen.Point3d scaleAboutPoint586 = new NXOpen.Point3d(79.408946041626876, -29.003976745700754, 0.0);
    NXOpen.Point3d viewCenter586 = new NXOpen.Point3d(-79.408946041627161, 29.003976745700566, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint586, viewCenter586);
    
    NXOpen.Point3d scaleAboutPoint587 = new NXOpen.Point3d(63.527156833301433, -23.203181396560606, 0.0);
    NXOpen.Point3d viewCenter587 = new NXOpen.Point3d(-63.52715683330181, 23.203181396560417, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint587, viewCenter587);
    
    NXOpen.Point3d scaleAboutPoint588 = new NXOpen.Point3d(50.821725466641197, -18.562545117248522, 0.0);
    NXOpen.Point3d viewCenter588 = new NXOpen.Point3d(-50.821725466641439, 18.562545117248341, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint588, viewCenter588);
    
    NXOpen.Point3d scaleAboutPoint589 = new NXOpen.Point3d(40.51320526560616, -14.561685878385266, 0.0);
    NXOpen.Point3d viewCenter589 = new NXOpen.Point3d(-40.513205265606402, 14.561685878385084, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint589, viewCenter589);
    
    NXOpen.Point3d scaleAboutPoint590 = new NXOpen.Point3d(32.295224126319518, -11.534008616542788, 0.0);
    NXOpen.Point3d viewCenter590 = new NXOpen.Point3d(-32.295224126319681, 11.534008616542625, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint590, viewCenter590);
    
    NXOpen.Session.UndoMarkId markId196;
    markId196 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note46 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 25 1"));
    note46.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin160 = new NXOpen.Point3d(451.60944897836754, 105.9308728362287, 0.0);
    note46.AnnotationOrigin = origin160;
    
    int nErrs164;
    nErrs164 = theSession.UpdateManager.DoUpdate(markId196);
    
    NXOpen.Point3d scaleAboutPoint591 = new NXOpen.Point3d(20.576671371912092, -6.5513168941963498, 0.0);
    NXOpen.Point3d viewCenter591 = new NXOpen.Point3d(-20.576671371912315, 6.551316894196173, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint591, viewCenter591);
    
    NXOpen.Point3d scaleAboutPoint592 = new NXOpen.Point3d(25.836179301055598, -8.0738060315800055, 0.0);
    NXOpen.Point3d viewCenter592 = new NXOpen.Point3d(-25.836179301055761, 8.073806031579803, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint592, viewCenter592);
    
    NXOpen.Point3d scaleAboutPoint593 = new NXOpen.Point3d(32.29522412631944, -10.092257539474979, 0.0);
    NXOpen.Point3d viewCenter593 = new NXOpen.Point3d(-32.295224126319724, 10.092257539474751, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint593, viewCenter593);
    
    NXOpen.Point3d scaleAboutPoint594 = new NXOpen.Point3d(40.36903015789936, -12.615321924343695, 0.0);
    NXOpen.Point3d viewCenter594 = new NXOpen.Point3d(-40.369030157899601, 12.615321924343499, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint594, viewCenter594);
    
    NXOpen.Point3d scaleAboutPoint595 = new NXOpen.Point3d(50.686561303166087, -15.54387879963773, 0.0);
    NXOpen.Point3d viewCenter595 = new NXOpen.Point3d(-50.686561303166314, 15.543878799637541, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint595, viewCenter595);
    
    NXOpen.Point3d scaleAboutPoint596 = new NXOpen.Point3d(63.358201628957666, -18.866664485067503, 0.0);
    NXOpen.Point3d viewCenter596 = new NXOpen.Point3d(-63.358201628957858, 18.866664485067314, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint596, viewCenter596);
    
    NXOpen.Point3d origin161 = new NXOpen.Point3d(494.0001971114533, 150.48821240037032, 0.0);
    workPart.Views.WorkView.SetOrigin(origin161);
    
    NXOpen.Point3d origin162 = new NXOpen.Point3d(494.0001971114533, 150.48821240037032, 0.0);
    workPart.Views.WorkView.SetOrigin(origin162);
    
    NXOpen.Point3d scaleAboutPoint597 = new NXOpen.Point3d(17.247510443438394, -83.773622153844215, 0.0);
    NXOpen.Point3d viewCenter597 = new NXOpen.Point3d(-17.247510443438632, 83.77362215384403, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint597, viewCenter597);
    
    NXOpen.Point3d scaleAboutPoint598 = new NXOpen.Point3d(13.516416347510841, -67.018897723075426, 0.0);
    NXOpen.Point3d viewCenter598 = new NXOpen.Point3d(-13.516416347511075, 67.018897723075227, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint598, viewCenter598);
    
    NXOpen.Point3d scaleAboutPoint599 = new NXOpen.Point3d(10.81313307800867, -53.615118178460335, 0.0);
    NXOpen.Point3d viewCenter599 = new NXOpen.Point3d(-10.813133078008896, 53.615118178460129, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint599, viewCenter599);
    
    NXOpen.Point3d scaleAboutPoint600 = new NXOpen.Point3d(8.6505064624069696, -42.892094542768334, 0.0);
    NXOpen.Point3d viewCenter600 = new NXOpen.Point3d(-8.6505064624070904, 42.892094542768092, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint600, viewCenter600);
    
    NXOpen.Point3d scaleAboutPoint601 = new NXOpen.Point3d(6.9204051699255755, -34.313675634214675, 0.0);
    NXOpen.Point3d viewCenter601 = new NXOpen.Point3d(-6.9204051699256839, 34.313675634214448, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint601, viewCenter601);
    
    NXOpen.Point3d scaleAboutPoint602 = new NXOpen.Point3d(5.536324135940462, -27.450940507371776, 0.0);
    NXOpen.Point3d viewCenter602 = new NXOpen.Point3d(-5.5363241359405384, 27.450940507371545, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint602, viewCenter602);
    
    NXOpen.Point3d scaleAboutPoint603 = new NXOpen.Point3d(4.4290593087523371, -21.960752405897438, 0.0);
    NXOpen.Point3d viewCenter603 = new NXOpen.Point3d(-4.4290593087524606, 21.960752405897207, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint603, viewCenter603);
    
    NXOpen.Point3d scaleAboutPoint604 = new NXOpen.Point3d(-4.2814239984607099, -18.232960821030819, 0.0);
    NXOpen.Point3d viewCenter604 = new NXOpen.Point3d(4.2814239984605864, 18.232960821030602, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint604, viewCenter604);
    
    NXOpen.Point3d scaleAboutPoint605 = new NXOpen.Point3d(-0.17716237235006418, -14.291098036241209, 0.0);
    NXOpen.Point3d viewCenter605 = new NXOpen.Point3d(0.17716237235012328, 14.291098036240983, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint605, viewCenter605);
    
    NXOpen.Point3d scaleAboutPoint606 = new NXOpen.Point3d(1.7480020738542841, -11.385635129699622, 0.0);
    NXOpen.Point3d viewCenter606 = new NXOpen.Point3d(-1.7480020738542841, 11.385635129699393, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint606, viewCenter606);
    
    NXOpen.Point3d scaleAboutPoint607 = new NXOpen.Point3d(2.0409105294731082, -9.1085081037597124, 0.0);
    NXOpen.Point3d viewCenter607 = new NXOpen.Point3d(-2.0409105294731082, 9.1085081037594922, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint607, viewCenter607);
    
    NXOpen.Point3d scaleAboutPoint608 = new NXOpen.Point3d(1.8746141159605163, -7.2868064830077994, 0.0);
    NXOpen.Point3d viewCenter608 = new NXOpen.Point3d(-1.8746141159604608, 7.28680648300758, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint608, viewCenter608);
    
    NXOpen.Point3d scaleAboutPoint609 = new NXOpen.Point3d(1.6448227081976483, -5.8294451864062786, 0.0);
    NXOpen.Point3d viewCenter609 = new NXOpen.Point3d(-1.6448227081975353, 5.8294451864060584, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint609, viewCenter609);
    
    NXOpen.Point3d scaleAboutPoint610 = new NXOpen.Point3d(1.4126124435109604, -4.6635561491250543, 0.0);
    NXOpen.Point3d viewCenter610 = new NXOpen.Point3d(-1.412612443510791, 4.663556149124827, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint610, viewCenter610);
    
    NXOpen.Point3d scaleAboutPoint611 = new NXOpen.Point3d(1.2384547449959196, -3.7153642349876197, 0.0);
    NXOpen.Point3d viewCenter611 = new NXOpen.Point3d(-1.2384547449957493, 3.7153642349873848, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint611, viewCenter611);
    
    NXOpen.Point3d scaleAboutPoint612 = new NXOpen.Point3d(3.9754397314366394, -4.1859770380860137, 0.0);
    NXOpen.Point3d viewCenter612 = new NXOpen.Point3d(-3.9754397314365817, 4.1859770380857872, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint612, viewCenter612);
    
    NXOpen.Point3d scaleAboutPoint613 = new NXOpen.Point3d(4.7990121368589822, -5.1705485603577293, 0.0);
    NXOpen.Point3d viewCenter613 = new NXOpen.Point3d(-4.7990121368587575, 5.1705485603575099, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint613, viewCenter613);
    
    NXOpen.Point3d scaleAboutPoint614 = new NXOpen.Point3d(5.7085023402153023, -6.3857822788849008, 0.0);
    NXOpen.Point3d viewCenter614 = new NXOpen.Point3d(-5.708502340215075, 6.3857822788846734, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint614, viewCenter614);
    
    NXOpen.Point3d scaleAboutPoint615 = new NXOpen.Point3d(7.0388736483162599, -7.9580392793678811, 0.0);
    NXOpen.Point3d viewCenter615 = new NXOpen.Point3d(-7.0388736483160903, 7.9580392793676555, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint615, viewCenter615);
    
    NXOpen.Point3d scaleAboutPoint616 = new NXOpen.Point3d(8.4055278102745206, -9.7963705414710702, 0.0);
    NXOpen.Point3d viewCenter616 = new NXOpen.Point3d(-8.4055278102744104, 9.7963705414708446, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint616, viewCenter616);
    
    NXOpen.Point3d scaleAboutPoint617 = new NXOpen.Point3d(9.9777848107575657, -12.018695340230718, 0.0);
    NXOpen.Point3d viewCenter617 = new NXOpen.Point3d(-9.9777848107573952, 12.018695340230487, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint617, viewCenter617);
    
    NXOpen.Point3d scaleAboutPoint618 = new NXOpen.Point3d(11.90531142192663, -14.834395978114932, 0.0);
    NXOpen.Point3d viewCenter618 = new NXOpen.Point3d(-11.905311421926465, 14.834395978114703, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint618, viewCenter618);
    
    NXOpen.Point3d scaleAboutPoint619 = new NXOpen.Point3d(14.054881539774483, -17.775291359126548, 0.0);
    NXOpen.Point3d viewCenter619 = new NXOpen.Point3d(-14.054881539774316, 17.775291359126324, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint619, viewCenter619);
    
    NXOpen.Point3d scaleAboutPoint620 = new NXOpen.Point3d(24.507461508430275, -21.776208268032935, 0.0);
    NXOpen.Point3d viewCenter620 = new NXOpen.Point3d(-24.507461508430048, 21.7762082680327, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint620, viewCenter620);
    
    NXOpen.Point3d scaleAboutPoint621 = new NXOpen.Point3d(29.896150334079067, -28.235253093296905, 0.0);
    NXOpen.Point3d viewCenter621 = new NXOpen.Point3d(-29.896150334078843, 28.235253093296667, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint621, viewCenter621);
    
    NXOpen.Point3d scaleAboutPoint622 = new NXOpen.Point3d(14.417510770678636, -20.530535337446292, 0.0);
    NXOpen.Point3d viewCenter622 = new NXOpen.Point3d(-14.417510770678348, 20.530535337446072, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint622, viewCenter622);
    
    NXOpen.Point3d scaleAboutPoint623 = new NXOpen.Point3d(17.733538247934746, -25.086468740980692, 0.0);
    NXOpen.Point3d viewCenter623 = new NXOpen.Point3d(-17.733538247934398, 25.086468740980514, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint623, viewCenter623);
    
    NXOpen.Point3d scaleAboutPoint624 = new NXOpen.Point3d(21.806485040651417, -30.817429272325402, 0.0);
    NXOpen.Point3d viewCenter624 = new NXOpen.Point3d(-21.806485040651086, 30.817429272325221, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint624, viewCenter624);
    
    NXOpen.Point3d scaleAboutPoint625 = new NXOpen.Point3d(50.236014091583165, -51.812929332125954, 0.0);
    NXOpen.Point3d viewCenter625 = new NXOpen.Point3d(-50.236014091582767, 51.812929332125819, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint625, viewCenter625);
    
    NXOpen.Point3d scaleAboutPoint626 = new NXOpen.Point3d(43.252532312035825, -43.973407850569544, 0.0);
    NXOpen.Point3d viewCenter626 = new NXOpen.Point3d(-43.252532312035328, 43.973407850569423, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint626, viewCenter626);
    
    NXOpen.Point3d scaleAboutPoint627 = new NXOpen.Point3d(34.746200957335404, -35.178726280455649, 0.0);
    NXOpen.Point3d viewCenter627 = new NXOpen.Point3d(-34.74620095733502, 35.178726280455514, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint627, viewCenter627);
    
    NXOpen.Point3d scaleAboutPoint628 = new NXOpen.Point3d(27.796960765868373, -28.14298102436452, 0.0);
    NXOpen.Point3d viewCenter628 = new NXOpen.Point3d(-27.796960765867983, 28.142981024364406, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint628, viewCenter628);
    
    NXOpen.Point3d scaleAboutPoint629 = new NXOpen.Point3d(22.237568612694805, -22.514384819491628, 0.0);
    NXOpen.Point3d viewCenter629 = new NXOpen.Point3d(-22.237568612694297, 22.514384819491521, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint629, viewCenter629);
    
    NXOpen.Point3d scaleAboutPoint630 = new NXOpen.Point3d(17.790054890155822, -18.011507855593308, 0.0);
    NXOpen.Point3d viewCenter630 = new NXOpen.Point3d(-17.790054890155417, 18.011507855593191, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint630, viewCenter630);
    
    NXOpen.Point3d scaleAboutPoint631 = new NXOpen.Point3d(7.9723067557546292, -15.531234642691961, 0.0);
    NXOpen.Point3d viewCenter631 = new NXOpen.Point3d(-7.9723067557541709, 15.531234642691842, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint631, viewCenter631);
    
    NXOpen.Point3d scaleAboutPoint632 = new NXOpen.Point3d(6.3778454046037121, -12.424987714153566, 0.0);
    NXOpen.Point3d viewCenter632 = new NXOpen.Point3d(-6.3778454046033186, 12.42498771415346, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint632, viewCenter632);
    
    NXOpen.Point3d scaleAboutPoint633 = new NXOpen.Point3d(5.1022763236830428, -9.939990171322874, 0.0);
    NXOpen.Point3d viewCenter633 = new NXOpen.Point3d(-5.102276323682589, 9.9399901713227674, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint633, viewCenter633);
    
    NXOpen.Point3d scaleAboutPoint634 = new NXOpen.Point3d(4.0818210589464803, -7.9519921370583146, 0.0);
    NXOpen.Point3d viewCenter634 = new NXOpen.Point3d(-4.0818210589460264, 7.951992137058201, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint634, viewCenter634);
    
    NXOpen.Point3d scaleAboutPoint635 = new NXOpen.Point3d(3.2654568471572305, -6.3615937096466615, 0.0);
    NXOpen.Point3d viewCenter635 = new NXOpen.Point3d(-3.2654568471567766, 6.3615937096465487, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint635, viewCenter635);
    
    NXOpen.Point3d scaleAboutPoint636 = new NXOpen.Point3d(2.6123654777257972, -5.0892749677173352, 0.0);
    NXOpen.Point3d viewCenter636 = new NXOpen.Point3d(-2.6123654777254002, 5.0892749677172207, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint636, viewCenter636);
    
    NXOpen.Point3d scaleAboutPoint637 = new NXOpen.Point3d(2.0898923821806803, -4.0714199741738835, 0.0);
    NXOpen.Point3d viewCenter637 = new NXOpen.Point3d(-2.0898923821802815, 4.0714199741737636, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint637, viewCenter637);
    
    NXOpen.Point3d scaleAboutPoint638 = new NXOpen.Point3d(2.0558348766933214, -3.2819050742390328, 0.0);
    NXOpen.Point3d viewCenter638 = new NXOpen.Point3d(-2.0558348766928671, 3.2819050742389191, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint638, viewCenter638);
    
    NXOpen.Point3d scaleAboutPoint639 = new NXOpen.Point3d(1.7536519189143371, -2.7246004389909007, 0.0);
    NXOpen.Point3d viewCenter639 = new NXOpen.Point3d(-1.7536519189138828, 2.7246004389907941, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint639, viewCenter639);
    
    NXOpen.Point3d scaleAboutPoint640 = new NXOpen.Point3d(1.5455915217550416, -2.2906458963443712, 0.0);
    NXOpen.Point3d viewCenter640 = new NXOpen.Point3d(-1.5455915217545868, 2.2906458963442575, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint640, viewCenter640);
    
    NXOpen.Point3d scaleAboutPoint641 = new NXOpen.Point3d(1.2998821003478986, -1.8769029351361664, 0.0);
    NXOpen.Point3d viewCenter641 = new NXOpen.Point3d(-1.2998821003473879, 1.8769029351360527, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint641, viewCenter641);
    
    NXOpen.Point3d scaleAboutPoint642 = new NXOpen.Point3d(1.1007782079044044, -1.5167404800154507, 0.0);
    NXOpen.Point3d viewCenter642 = new NXOpen.Point3d(-1.1007782079038926, 1.516740480015337, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint642, viewCenter642);
    
    NXOpen.Point3d scaleAboutPoint643 = new NXOpen.Point3d(1.5258713591594792, -1.2215087210291611, 0.0);
    NXOpen.Point3d viewCenter643 = new NXOpen.Point3d(-1.5258713591590807, 1.2215087210290474, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint643, viewCenter643);
    
    NXOpen.Point3d scaleAboutPoint644 = new NXOpen.Point3d(1.9073391989493798, -1.5268859012864566, 0.0);
    NXOpen.Point3d viewCenter644 = new NXOpen.Point3d(-1.9073391989488679, 1.5268859012863429, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint644, viewCenter644);
    
    NXOpen.Point3d scaleAboutPoint645 = new NXOpen.Point3d(2.3841739986865798, -1.9086073766080374, 0.0);
    NXOpen.Point3d viewCenter645 = new NXOpen.Point3d(-2.3841739986861819, 1.9086073766079237, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint645, viewCenter645);
    
    NXOpen.Point3d scaleAboutPoint646 = new NXOpen.Point3d(2.9802174983582281, -2.3857592207600522, 0.0);
    NXOpen.Point3d viewCenter646 = new NXOpen.Point3d(-2.9802174983577734, 2.3857592207599385, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint646, viewCenter646);
    
    NXOpen.Point3d scaleAboutPoint647 = new NXOpen.Point3d(3.7252718729477134, -2.9821990259500426, 0.0);
    NXOpen.Point3d viewCenter647 = new NXOpen.Point3d(-3.7252718729472591, 2.9821990259499218, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint647, viewCenter647);
    
    NXOpen.Point3d scaleAboutPoint648 = new NXOpen.Point3d(4.6565898411845854, -3.7277487824375353, 0.0);
    NXOpen.Point3d viewCenter648 = new NXOpen.Point3d(-4.6565898411841316, 3.7277487824374216, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint648, viewCenter648);
    
    NXOpen.Point3d scaleAboutPoint649 = new NXOpen.Point3d(5.8207373014806612, -4.6596859780468893, 0.0);
    NXOpen.Point3d viewCenter649 = new NXOpen.Point3d(-5.8207373014802064, 4.6596859780467836, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint649, viewCenter649);
    
    NXOpen.Point3d scaleAboutPoint650 = new NXOpen.Point3d(7.2759216268507698, -5.8052566171680438, 0.0);
    NXOpen.Point3d viewCenter650 = new NXOpen.Point3d(-7.2759216268503151, 5.8052566171679292, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint650, viewCenter650);
    
    NXOpen.Point3d scaleAboutPoint651 = new NXOpen.Point3d(9.0707134643252516, -7.2081936329836491, 0.0);
    NXOpen.Point3d viewCenter651 = new NXOpen.Point3d(-9.0707134643247382, 7.2081936329835417, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint651, viewCenter651);
    
    NXOpen.Point3d scaleAboutPoint652 = new NXOpen.Point3d(7.8612850024151744, -8.0426992717015349, 0.0);
    NXOpen.Point3d viewCenter652 = new NXOpen.Point3d(-7.8612850024147765, 8.0426992717014141, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint652, viewCenter652);
    
    NXOpen.Point3d scaleAboutPoint653 = new NXOpen.Point3d(9.8266062530189053, -10.053374089626885, 0.0);
    NXOpen.Point3d viewCenter653 = new NXOpen.Point3d(-9.826606253018511, 10.053374089626777, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint653, viewCenter653);
    
    NXOpen.Point3d scaleAboutPoint654 = new NXOpen.Point3d(12.283257816273574, -12.519474312740227, 0.0);
    NXOpen.Point3d viewCenter654 = new NXOpen.Point3d(-12.28325781627318, 12.519474312740117, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint654, viewCenter654);
    
    NXOpen.Point3d scaleAboutPoint655 = new NXOpen.Point3d(15.354072270341911, -15.531234642691871, 0.0);
    NXOpen.Point3d viewCenter655 = new NXOpen.Point3d(-15.354072270341517, 15.531234642691754, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint655, viewCenter655);
    
    NXOpen.Point3d scaleAboutPoint656 = new NXOpen.Point3d(19.192590337927339, -19.118772682781316, 0.0);
    NXOpen.Point3d viewCenter656 = new NXOpen.Point3d(-19.192590337926937, 19.118772682781206, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint656, viewCenter656);
    
    NXOpen.Point3d scaleAboutPoint657 = new NXOpen.Point3d(23.990737922409078, -23.713921715611949, 0.0);
    NXOpen.Point3d viewCenter657 = new NXOpen.Point3d(-23.990737922408741, 23.713921715611836, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint657, viewCenter657);
    
    NXOpen.Point3d scaleAboutPoint658 = new NXOpen.Point3d(29.98842240301131, -29.181041799853215, 0.0);
    NXOpen.Point3d viewCenter658 = new NXOpen.Point3d(-29.988422403010965, 29.181041799853091, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint658, viewCenter658);
    
    NXOpen.Point3d scaleAboutPoint659 = new NXOpen.Point3d(37.485528003764102, -35.755426711282581, 0.0);
    NXOpen.Point3d viewCenter659 = new NXOpen.Point3d(-37.485528003763754, 35.75542671128246, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint659, viewCenter659);
    
    NXOpen.Point3d scaleAboutPoint660 = new NXOpen.Point3d(24.329549425520025, -21.265828386750751, 0.0);
    NXOpen.Point3d viewCenter660 = new NXOpen.Point3d(-24.329549425519694, 21.265828386750631, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint660, viewCenter660);
    
    NXOpen.Point3d scaleAboutPoint661 = new NXOpen.Point3d(39.873428225157802, -38.296512984614644, 0.0);
    NXOpen.Point3d viewCenter661 = new NXOpen.Point3d(-39.873428225157355, 38.296512984614573, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint661, viewCenter661);
    
    NXOpen.Point3d scaleAboutPoint662 = new NXOpen.Point3d(49.560193274207371, -47.58904922352847, 0.0);
    NXOpen.Point3d viewCenter662 = new NXOpen.Point3d(-49.560193274206902, 47.589049223528377, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint662, viewCenter662);
    
    NXOpen.Point3d scaleAboutPoint663 = new NXOpen.Point3d(61.598251583709526, -58.782331511311085, 0.0);
    NXOpen.Point3d viewCenter663 = new NXOpen.Point3d(-61.598251583708915, 58.782331511310964, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint663, viewCenter663);
    
    NXOpen.Point3d scaleAboutPoint664 = new NXOpen.Point3d(84.477602171944369, -98.117215022622489, 0.0);
    NXOpen.Point3d viewCenter664 = new NXOpen.Point3d(-84.477602171943758, 98.117215022622389, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint664, viewCenter664);
    
    NXOpen.Point3d scaleAboutPoint665 = new NXOpen.Point3d(72.861931873301955, -78.493772018097971, 0.0);
    NXOpen.Point3d viewCenter665 = new NXOpen.Point3d(-72.861931873301316, 78.493772018097914, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint665, viewCenter665);
    
    NXOpen.Point3d scaleAboutPoint666 = new NXOpen.Point3d(61.105465571039829, -61.387057578279311, 0.0);
    NXOpen.Point3d viewCenter666 = new NXOpen.Point3d(-61.105465571039147, 61.387057578279261, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint666, viewCenter666);
    
    NXOpen.Point3d scaleAboutPoint667 = new NXOpen.Point3d(50.010740485791182, -47.983278033664199, 0.0);
    NXOpen.Point3d viewCenter667 = new NXOpen.Point3d(-50.010740485790507, 47.983278033664142, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint667, viewCenter667);
    
    NXOpen.Point3d scaleAboutPoint668 = new NXOpen.Point3d(41.089905696433888, -37.125090234497002, 0.0);
    NXOpen.Point3d viewCenter668 = new NXOpen.Point3d(-41.089905696433199, 37.125090234496923, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint668, viewCenter668);
    
    NXOpen.Point3d scaleAboutPoint669 = new NXOpen.Point3d(34.746200957335368, -28.114146002822991, 0.0);
    NXOpen.Point3d viewCenter669 = new NXOpen.Point3d(-34.746200957334686, 28.114146002822892, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint669, viewCenter669);
    
    NXOpen.Session.UndoMarkId markId197;
    markId197 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note47 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 7 1"));
    note47.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin163 = new NXOpen.Point3d(517.85790304118098, 76.984602511271433, 0.0);
    note47.AnnotationOrigin = origin163;
    
    int nErrs165;
    nErrs165 = theSession.UpdateManager.DoUpdate(markId197);
    
    NXOpen.Session.UndoMarkId markId198;
    markId198 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.TargetPoint targetPoint6 = ((NXOpen.Annotations.TargetPoint)workPart.Annotations.TargetPoints.FindObject("HANDLE R-756561"));
    targetPoint6.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin164 = new NXOpen.Point3d(569.41492155712706, 113.66274991187768, 0.0);
    targetPoint6.AnnotationOrigin = origin164;
    
    int nErrs166;
    nErrs166 = theSession.UpdateManager.DoUpdate(markId198);
    
    NXOpen.Point3d scaleAboutPoint670 = new NXOpen.Point3d(50.172937481961299, 13.033429736693263, 0.0);
    NXOpen.Point3d viewCenter670 = new NXOpen.Point3d(-50.172937481960609, -13.03342973669335, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint670, viewCenter670);
    
    NXOpen.Point3d scaleAboutPoint671 = new NXOpen.Point3d(61.995296313917621, 16.291787170866591, 0.0);
    NXOpen.Point3d viewCenter671 = new NXOpen.Point3d(-61.995296313916924, -16.291787170866662, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint671, viewCenter671);
    
    NXOpen.Point3d scaleAboutPoint672 = new NXOpen.Point3d(76.953463738496424, 20.36473396358323, 0.0);
    NXOpen.Point3d viewCenter672 = new NXOpen.Point3d(-76.953463738495799, -20.364733963583333, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint672, viewCenter672);
    
    NXOpen.Point3d scaleAboutPoint673 = new NXOpen.Point3d(95.290735249953116, 25.455917454479042, 0.0);
    NXOpen.Point3d viewCenter673 = new NXOpen.Point3d(-95.290735249952434, -25.455917454479156, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint673, viewCenter673);
    
    NXOpen.Point3d scaleAboutPoint674 = new NXOpen.Point3d(117.42386701900242, 31.81989681809883, 0.0);
    NXOpen.Point3d viewCenter674 = new NXOpen.Point3d(-117.42386701900172, -31.819896818098922, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint674, viewCenter674);
    
    NXOpen.Point3d scaleAboutPoint675 = new NXOpen.Point3d(144.66789371945436, 39.774871022623536, 0.0);
    NXOpen.Point3d viewCenter675 = new NXOpen.Point3d(-144.66789371945367, -39.77487102262365, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint675, viewCenter675);
    
    NXOpen.Session.UndoMarkId markId199;
    markId199 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note47.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin165 = new NXOpen.Point3d(493.70541866981364, 15.194727566635468, 0.0);
    note47.AnnotationOrigin = origin165;
    
    int nErrs167;
    nErrs167 = theSession.UpdateManager.DoUpdate(markId199);
    
    NXOpen.Point3d scaleAboutPoint676 = new NXOpen.Point3d(124.95645321266747, 12.319650316741797, 0.0);
    NXOpen.Point3d viewCenter676 = new NXOpen.Point3d(-124.95645321266677, -12.319650316741907, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint676, viewCenter676);
    
    NXOpen.Point3d scaleAboutPoint677 = new NXOpen.Point3d(99.965162570134154, 11.263680289592457, 0.0);
    NXOpen.Point3d viewCenter677 = new NXOpen.Point3d(-99.965162570133273, -11.263680289592575, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint677, viewCenter677);
    
    NXOpen.Point3d scaleAboutPoint678 = new NXOpen.Point3d(80.535314070586978, 10.137312260633225, 0.0);
    NXOpen.Point3d viewCenter678 = new NXOpen.Point3d(-80.535314070586267, -10.137312260633342, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint678, viewCenter678);
    
    NXOpen.Point3d scaleAboutPoint679 = new NXOpen.Point3d(65.779892891220811, 10.587859472216921, 0.0);
    NXOpen.Point3d viewCenter679 = new NXOpen.Point3d(-65.779892891219973, -10.587859472217053, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint679, viewCenter679);
    
    NXOpen.Point3d scaleAboutPoint680 = new NXOpen.Point3d(53.344789851510718, 9.7318197702078724, 0.0);
    NXOpen.Point3d viewCenter680 = new NXOpen.Point3d(-53.344789851509759, -9.7318197702080234, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint680, viewCenter680);
    
    NXOpen.Point3d scaleAboutPoint681 = new NXOpen.Point3d(43.973407850569728, 9.9480824317680625, 0.0);
    NXOpen.Point3d viewCenter681 = new NXOpen.Point3d(-43.973407850568805, -9.948082431768194, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint681, viewCenter681);
    
    NXOpen.Point3d scaleAboutPoint682 = new NXOpen.Point3d(-12.918089650527422, -5.1903038774443102, 0.0);
    NXOpen.Point3d viewCenter682 = new NXOpen.Point3d(12.918089650528326, 5.1903038774441654, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint682, viewCenter682);
    
    NXOpen.Point3d scaleAboutPoint683 = new NXOpen.Point3d(-16.291787170866158, -6.6320549545121583, 0.0);
    NXOpen.Point3d viewCenter683 = new NXOpen.Point3d(16.291787170867121, 6.6320549545120144, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint683, viewCenter683);
    
    NXOpen.Point3d scaleAboutPoint684 = new NXOpen.Point3d(-20.725171732849791, -8.2900686931401779, 0.0);
    NXOpen.Point3d viewCenter684 = new NXOpen.Point3d(20.725171732850693, 8.2900686931400127, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint684, viewCenter684);
    
    NXOpen.Point3d scaleAboutPoint685 = new NXOpen.Point3d(-25.906464666062305, -10.362585866425226, 0.0);
    NXOpen.Point3d viewCenter685 = new NXOpen.Point3d(25.906464666063318, 10.362585866425057, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint685, viewCenter685);
    
    NXOpen.Point3d origin166 = new NXOpen.Point3d(587.31654207415397, 177.67432947523889, 0.0);
    workPart.Views.WorkView.SetOrigin(origin166);
    
    NXOpen.Point3d origin167 = new NXOpen.Point3d(587.31654207415397, 177.67432947523889, 0.0);
    workPart.Views.WorkView.SetOrigin(origin167);
    
    NXOpen.Session.UndoMarkId markId200;
    markId200 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    targetPoint6.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin168 = new NXOpen.Point3d(749.51353824428645, 241.59571511867836, 0.0);
    targetPoint6.AnnotationOrigin = origin168;
    
    int nErrs168;
    nErrs168 = theSession.UpdateManager.DoUpdate(markId200);
    
    NXOpen.Point3d scaleAboutPoint686 = new NXOpen.Point3d(130.09550734479424, 80.53531407058648, 0.0);
    NXOpen.Point3d viewCenter686 = new NXOpen.Point3d(-130.09550734479325, -80.535314070586665, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint686, viewCenter686);
    
    NXOpen.Point3d scaleAboutPoint687 = new NXOpen.Point3d(111.96098207855023, 67.807355343346927, 0.0);
    NXOpen.Point3d viewCenter687 = new NXOpen.Point3d(-111.96098207854932, -67.807355343347155, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint687, viewCenter687);
    
    NXOpen.Point3d scaleAboutPoint688 = new NXOpen.Point3d(113.53789731909315, 35.322901388162059, 0.0);
    NXOpen.Point3d viewCenter688 = new NXOpen.Point3d(-113.53789731909224, -35.322901388162279, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint688, viewCenter688);
    
    NXOpen.Point3d scaleAboutPoint689 = new NXOpen.Point3d(90.830317855274586, 28.258321110529653, 0.0);
    NXOpen.Point3d viewCenter689 = new NXOpen.Point3d(-90.830317855273677, -28.258321110529796, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint689, viewCenter689);
    
    NXOpen.Point3d scaleAboutPoint690 = new NXOpen.Point3d(72.664254284219766, 22.606656888423732, 0.0);
    NXOpen.Point3d viewCenter690 = new NXOpen.Point3d(-72.66425428421887, -22.606656888423817, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint690, viewCenter690);
    
    NXOpen.Point3d scaleAboutPoint691 = new NXOpen.Point3d(58.131403427375901, 18.085325510738961, 0.0);
    NXOpen.Point3d viewCenter691 = new NXOpen.Point3d(-58.131403427374991, -18.085325510739079, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint691, viewCenter691);
    
    NXOpen.Point3d scaleAboutPoint692 = new NXOpen.Point3d(46.505122741900841, 14.468260408591174, 0.0);
    NXOpen.Point3d viewCenter692 = new NXOpen.Point3d(-46.505122741899939, -14.46826040859129, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint692, viewCenter692);
    
    NXOpen.Point3d origin169 = new NXOpen.Point3d(712.06163908439521, 236.76035233451896, 0.0);
    workPart.Views.WorkView.SetOrigin(origin169);
    
    NXOpen.Point3d origin170 = new NXOpen.Point3d(712.06163908439521, 236.76035233451896, 0.0);
    workPart.Views.WorkView.SetOrigin(origin170);
    
    NXOpen.Session.UndoMarkId markId201;
    markId201 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    targetPoint6.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin171 = new NXOpen.Point3d(691.33364151943385, 256.42537566538147, 0.0);
    targetPoint6.AnnotationOrigin = origin171;
    
    int nErrs169;
    nErrs169 = theSession.UpdateManager.DoUpdate(markId201);
    
    NXOpen.Point3d scaleAboutPoint693 = new NXOpen.Point3d(14.2910980362416, 15.472180518575053, 0.0);
    NXOpen.Point3d viewCenter693 = new NXOpen.Point3d(-14.291098036240694, -15.472180518575195, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint693, viewCenter693);
    
    NXOpen.Point3d scaleAboutPoint694 = new NXOpen.Point3d(17.863872545301874, 19.340225648218791, 0.0);
    NXOpen.Point3d viewCenter694 = new NXOpen.Point3d(-17.863872545300975, -19.34022564821899, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint694, viewCenter694);
    
    NXOpen.Point3d scaleAboutPoint695 = new NXOpen.Point3d(22.329840681627253, 24.175282060273513, 0.0);
    NXOpen.Point3d viewCenter695 = new NXOpen.Point3d(-22.329840681626354, -24.175282060273766, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint695, viewCenter695);
    
    NXOpen.Point3d scaleAboutPoint696 = new NXOpen.Point3d(27.912300852033944, 30.219102575341918, 0.0);
    NXOpen.Point3d viewCenter696 = new NXOpen.Point3d(-27.912300852033038, -30.219102575342148, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint696, viewCenter696);
    
    NXOpen.Point3d scaleAboutPoint697 = new NXOpen.Point3d(34.890376065042297, 37.773878219177433, 0.0);
    NXOpen.Point3d viewCenter697 = new NXOpen.Point3d(-34.890376065041401, -37.773878219177625, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint697, viewCenter697);
    
    NXOpen.Point3d scaleAboutPoint698 = new NXOpen.Point3d(43.793188965936245, 47.217347773971781, 0.0);
    NXOpen.Point3d viewCenter698 = new NXOpen.Point3d(-43.793188965935329, -47.217347773972051, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint698, viewCenter698);
    
    NXOpen.Point3d scaleAboutPoint699 = new NXOpen.Point3d(72.087553853392691, 52.714023755292963, 0.0);
    NXOpen.Point3d viewCenter699 = new NXOpen.Point3d(-72.087553853391796, -52.714023755293191, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint699, viewCenter699);
    
    NXOpen.Point3d scaleAboutPoint700 = new NXOpen.Point3d(57.726361484162261, 59.979097542080176, 0.0);
    NXOpen.Point3d viewCenter700 = new NXOpen.Point3d(-57.726361484161366, -59.97909754208041, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint700, viewCenter700);
    
    NXOpen.Point3d scaleAboutPoint701 = new NXOpen.Point3d(56.670391457013004, 74.621881918550486, 0.0);
    NXOpen.Point3d viewCenter701 = new NXOpen.Point3d(-56.670391457012002, -74.621881918550713, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint701, viewCenter701);
    
    NXOpen.Point3d scaleAboutPoint702 = new NXOpen.Point3d(231.87341846153444, -92.837364886876102, 0.0);
    NXOpen.Point3d viewCenter702 = new NXOpen.Point3d(-231.87341846153356, 92.837364886875918, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint702, viewCenter702);
    
    NXOpen.Point3d scaleAboutPoint703 = new NXOpen.Point3d(186.20271478732701, -74.26989190950087, 0.0);
    NXOpen.Point3d viewCenter703 = new NXOpen.Point3d(-186.20271478732636, 74.269891909500743, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint703, viewCenter703);
    
    NXOpen.Point3d scaleAboutPoint704 = new NXOpen.Point3d(148.96217182986175, -59.415913527600694, 0.0);
    NXOpen.Point3d viewCenter704 = new NXOpen.Point3d(-148.96217182986095, 59.415913527600601, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint704, viewCenter704);
    
    NXOpen.Session.UndoMarkId markId202;
    markId202 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note48 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-1247"));
    note48.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin172 = new NXOpen.Point3d(699.60572031296272, 64.35786552278239, 0.0);
    note48.AnnotationOrigin = origin172;
    
    int nErrs170;
    nErrs170 = theSession.UpdateManager.DoUpdate(markId202);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId203;
    markId203 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId204;
    markId204 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects26 = new NXOpen.TaggedObject[1];
    NXOpen.Annotations.Note note49 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-848846"));
    objects26[0] = note49;
    int nErrs171;
    nErrs171 = theSession.UpdateManager.AddObjectsToDeleteList(objects26);
    
    NXOpen.Session.UndoMarkId id15;
    id15 = theSession.NewestVisibleUndoMark;
    
    int nErrs172;
    nErrs172 = theSession.UpdateManager.DoUpdate(id15);
    
    theSession.DeleteUndoMark(markId203, null);
    
    NXOpen.Point3d origin173 = new NXOpen.Point3d(678.20472776272709, 61.654582253280907, 0.0);
    workPart.Views.WorkView.SetOrigin(origin173);
    
    NXOpen.Point3d origin174 = new NXOpen.Point3d(678.20472776272709, 61.654582253280907, 0.0);
    workPart.Views.WorkView.SetOrigin(origin174);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId205;
    markId205 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId206;
    markId206 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects27 = new NXOpen.TaggedObject[1];
    NXOpen.Line line6 = ((NXOpen.Line)workPart.Lines.FindObject("HANDLE R-185240"));
    objects27[0] = line6;
    int nErrs173;
    nErrs173 = theSession.UpdateManager.AddObjectsToDeleteList(objects27);
    
    NXOpen.Session.UndoMarkId id16;
    id16 = theSession.NewestVisibleUndoMark;
    
    int nErrs174;
    nErrs174 = theSession.UpdateManager.DoUpdate(id16);
    
    theSession.DeleteUndoMark(markId205, null);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId207;
    markId207 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId208;
    markId208 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects28 = new NXOpen.TaggedObject[1];
    NXOpen.Line line7 = ((NXOpen.Line)workPart.Lines.FindObject("HANDLE R-845995"));
    objects28[0] = line7;
    int nErrs175;
    nErrs175 = theSession.UpdateManager.AddObjectsToDeleteList(objects28);
    
    NXOpen.Session.UndoMarkId id17;
    id17 = theSession.NewestVisibleUndoMark;
    
    int nErrs176;
    nErrs176 = theSession.UpdateManager.DoUpdate(id17);
    
    theSession.DeleteUndoMark(markId207, null);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId209;
    markId209 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId210;
    markId210 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects29 = new NXOpen.TaggedObject[1];
    NXOpen.Line line8 = ((NXOpen.Line)workPart.Lines.FindObject("HANDLE R-185241"));
    objects29[0] = line8;
    int nErrs177;
    nErrs177 = theSession.UpdateManager.AddObjectsToDeleteList(objects29);
    
    NXOpen.Session.UndoMarkId id18;
    id18 = theSession.NewestVisibleUndoMark;
    
    int nErrs178;
    nErrs178 = theSession.UpdateManager.DoUpdate(id18);
    
    theSession.DeleteUndoMark(markId209, null);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId211;
    markId211 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId212;
    markId212 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects30 = new NXOpen.TaggedObject[1];
    NXOpen.Line line9 = ((NXOpen.Line)workPart.Lines.FindObject("HANDLE R-185242"));
    objects30[0] = line9;
    int nErrs179;
    nErrs179 = theSession.UpdateManager.AddObjectsToDeleteList(objects30);
    
    NXOpen.Session.UndoMarkId id19;
    id19 = theSession.NewestVisibleUndoMark;
    
    int nErrs180;
    nErrs180 = theSession.UpdateManager.DoUpdate(id19);
    
    theSession.DeleteUndoMark(markId211, null);
    
    NXOpen.Point3d scaleAboutPoint705 = new NXOpen.Point3d(-9.912038654841016, -46.406362793121332, 0.0);
    NXOpen.Point3d viewCenter705 = new NXOpen.Point3d(9.9120386548418047, 46.406362793121239, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint705, viewCenter705);
    
    NXOpen.Point3d scaleAboutPoint706 = new NXOpen.Point3d(-7.9296309238726801, -36.944871349863604, 0.0);
    NXOpen.Point3d viewCenter706 = new NXOpen.Point3d(7.9296309238735967, 36.944871349863512, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint706, viewCenter706);
    
    NXOpen.Point3d scaleAboutPoint707 = new NXOpen.Point3d(-6.1995296313912789, -29.411721972184115, 0.0);
    NXOpen.Point3d viewCenter707 = new NXOpen.Point3d(6.1995296313921919, 29.411721972184019, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint707, viewCenter707);
    
    NXOpen.Point3d scaleAboutPoint708 = new NXOpen.Point3d(-4.9596237051129393, -23.529377577747315, 0.0);
    NXOpen.Point3d viewCenter708 = new NXOpen.Point3d(4.9596237051138425, 23.52937757774723, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint708, viewCenter708);
    
    NXOpen.Point3d scaleAboutPoint709 = new NXOpen.Point3d(-3.9676989640902613, -18.823502062197864, 0.0);
    NXOpen.Point3d viewCenter709 = new NXOpen.Point3d(3.9676989640911691, 18.823502062197779, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint709, viewCenter709);
    
    NXOpen.Point3d scaleAboutPoint710 = new NXOpen.Point3d(-3.1741591712721156, -15.058801649758298, 0.0);
    NXOpen.Point3d viewCenter710 = new NXOpen.Point3d(3.1741591712730264, 15.058801649758211, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint710, viewCenter710);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId213;
    markId213 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId214;
    markId214 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects31 = new NXOpen.TaggedObject[1];
    NXOpen.Line line10 = ((NXOpen.Line)workPart.Lines.FindObject("HANDLE R-185243"));
    objects31[0] = line10;
    int nErrs181;
    nErrs181 = theSession.UpdateManager.AddObjectsToDeleteList(objects31);
    
    NXOpen.Session.UndoMarkId id20;
    id20 = theSession.NewestVisibleUndoMark;
    
    int nErrs182;
    nErrs182 = theSession.UpdateManager.DoUpdate(id20);
    
    theSession.DeleteUndoMark(markId213, null);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId215;
    markId215 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId216;
    markId216 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects32 = new NXOpen.TaggedObject[1];
    NXOpen.Line line11 = ((NXOpen.Line)workPart.Lines.FindObject("HANDLE R-185244"));
    objects32[0] = line11;
    int nErrs183;
    nErrs183 = theSession.UpdateManager.AddObjectsToDeleteList(objects32);
    
    NXOpen.Session.UndoMarkId id21;
    id21 = theSession.NewestVisibleUndoMark;
    
    int nErrs184;
    nErrs184 = theSession.UpdateManager.DoUpdate(id21);
    
    theSession.DeleteUndoMark(markId215, null);
    
    NXOpen.Point3d scaleAboutPoint711 = new NXOpen.Point3d(12.165149568040471, 0.17716237235005045, 0.0);
    NXOpen.Point3d viewCenter711 = new NXOpen.Point3d(-12.165149568039565, -0.17716237235013907, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint711, viewCenter711);
    
    NXOpen.Point3d scaleAboutPoint712 = new NXOpen.Point3d(14.911166339466959, 0.22145296543757514, 0.0);
    NXOpen.Point3d viewCenter712 = new NXOpen.Point3d(-14.911166339466048, -0.2214529654376613, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint712, viewCenter712);
    
    NXOpen.Point3d scaleAboutPoint713 = new NXOpen.Point3d(17.993053441807195, 0.18454413786464346, 0.0);
    NXOpen.Point3d viewCenter713 = new NXOpen.Point3d(-17.993053441806289, -0.1845441378647204, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint713, viewCenter713);
    
    NXOpen.Point3d scaleAboutPoint714 = new NXOpen.Point3d(22.029956457597159, 0.11534008616538766, 0.0);
    NXOpen.Point3d viewCenter714 = new NXOpen.Point3d(-22.029956457596256, -0.11534008616546459, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint714, viewCenter714);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId217;
    markId217 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId218;
    markId218 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects33 = new NXOpen.TaggedObject[1];
    NXOpen.Annotations.Note note50 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-803084"));
    objects33[0] = note50;
    int nErrs185;
    nErrs185 = theSession.UpdateManager.AddObjectsToDeleteList(objects33);
    
    NXOpen.Session.UndoMarkId id22;
    id22 = theSession.NewestVisibleUndoMark;
    
    int nErrs186;
    nErrs186 = theSession.UpdateManager.DoUpdate(id22);
    
    theSession.DeleteUndoMark(markId217, null);
    
    NXOpen.Point3d scaleAboutPoint715 = new NXOpen.Point3d(-10.668957970301598, -5.7670043082714235, 0.0);
    NXOpen.Point3d viewCenter715 = new NXOpen.Point3d(10.668957970302513, 5.7670043082713516, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint715, viewCenter715);
    
    NXOpen.Point3d scaleAboutPoint716 = new NXOpen.Point3d(-8.5351663762411967, -4.6136034466171605, 0.0);
    NXOpen.Point3d viewCenter716 = new NXOpen.Point3d(8.5351663762421008, 4.6136034466170743, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint716, viewCenter716);
    
    NXOpen.Point3d scaleAboutPoint717 = new NXOpen.Point3d(-6.8281331009928694, -3.6908827572937311, 0.0);
    NXOpen.Point3d viewCenter717 = new NXOpen.Point3d(6.8281331009937771, 3.6908827572936538, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint717, viewCenter717);
    
    NXOpen.Point3d scaleAboutPoint718 = new NXOpen.Point3d(-5.4625064807942012, -2.9527062058349833, 0.0);
    NXOpen.Point3d viewCenter718 = new NXOpen.Point3d(5.4625064807951125, 2.9527062058349158, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint718, viewCenter718);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId219;
    markId219 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId220;
    markId220 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects34 = new NXOpen.TaggedObject[1];
    NXOpen.Annotations.Note note51 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-1533"));
    objects34[0] = note51;
    int nErrs187;
    nErrs187 = theSession.UpdateManager.AddObjectsToDeleteList(objects34);
    
    NXOpen.Session.UndoMarkId id23;
    id23 = theSession.NewestVisibleUndoMark;
    
    int nErrs188;
    nErrs188 = theSession.UpdateManager.DoUpdate(id23);
    
    theSession.DeleteUndoMark(markId219, null);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId221;
    markId221 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId222;
    markId222 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects35 = new NXOpen.TaggedObject[1];
    NXOpen.Annotations.Note note52 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-1414"));
    objects35[0] = note52;
    int nErrs189;
    nErrs189 = theSession.UpdateManager.AddObjectsToDeleteList(objects35);
    
    NXOpen.Session.UndoMarkId id24;
    id24 = theSession.NewestVisibleUndoMark;
    
    int nErrs190;
    nErrs190 = theSession.UpdateManager.DoUpdate(id24);
    
    theSession.DeleteUndoMark(markId221, null);
    
    NXOpen.Point3d scaleAboutPoint719 = new NXOpen.Point3d(2.7755438334853153, 1.7716237235009427, 0.0);
    NXOpen.Point3d viewCenter719 = new NXOpen.Point3d(-2.7755438334844094, -1.7716237235010066, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint719, viewCenter719);
    
    NXOpen.Point3d scaleAboutPoint720 = new NXOpen.Point3d(3.3217944815647842, 2.2145296543761823, 0.0);
    NXOpen.Point3d viewCenter720 = new NXOpen.Point3d(-3.3217944815638734, -2.2145296543762498, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint720, viewCenter720);
    
    NXOpen.Point3d scaleAboutPoint721 = new NXOpen.Point3d(4.0599710330235181, 2.7681620679702288, 0.0);
    NXOpen.Point3d viewCenter721 = new NXOpen.Point3d(-4.0599710330226104, -2.7681620679703056, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint721, viewCenter721);
    
    NXOpen.Point3d scaleAboutPoint722 = new NXOpen.Point3d(5.0749637912792789, 3.4602025849628033, 0.0);
    NXOpen.Point3d viewCenter722 = new NXOpen.Point3d(-5.0749637912783747, -3.4602025849628606, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint722, viewCenter722);
    
    NXOpen.Point3d scaleAboutPoint723 = new NXOpen.Point3d(6.1995296313922115, 4.3252532312035186, 0.0);
    NXOpen.Point3d viewCenter723 = new NXOpen.Point3d(-6.199529631391286, -4.325253231203579, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint723, viewCenter723);
    
    NXOpen.Point3d origin175 = new NXOpen.Point3d(699.13318639743306, 42.391951648030584, 0.0);
    workPart.Views.WorkView.SetOrigin(origin175);
    
    NXOpen.Point3d origin176 = new NXOpen.Point3d(699.13318639743306, 42.391951648030584, 0.0);
    workPart.Views.WorkView.SetOrigin(origin176);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId223;
    markId223 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId224;
    markId224 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects36 = new NXOpen.TaggedObject[1];
    NXOpen.Annotations.Note note53 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-1334"));
    objects36[0] = note53;
    int nErrs191;
    nErrs191 = theSession.UpdateManager.AddObjectsToDeleteList(objects36);
    
    NXOpen.Session.UndoMarkId id25;
    id25 = theSession.NewestVisibleUndoMark;
    
    int nErrs192;
    nErrs192 = theSession.UpdateManager.DoUpdate(id25);
    
    theSession.DeleteUndoMark(markId223, null);
    
    NXOpen.Session.UndoMarkId markId225;
    markId225 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note54 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-346306"));
    note54.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin177 = new NXOpen.Point3d(699.85406193596702, 48.519393725569138, 0.0);
    note54.AnnotationOrigin = origin177;
    
    int nErrs193;
    nErrs193 = theSession.UpdateManager.DoUpdate(markId225);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->复制(C)
    // ----------------------------------------------
    workPart.PmiManager.RestoreUnpastedObjects();
    
    // ----------------------------------------------
    //   菜单：编辑(E)->粘贴(P)
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId226;
    markId226 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder11;
    cutCopyPasteBuilder11 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder11.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder11.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation11 = new NXOpen.Point3d(699.13318639743306, 42.391951648030584, 0.0);
    cutCopyPasteBuilder11.SetDefaultToPoint(droplocation11);
    
    cutCopyPasteBuilder11.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects37 = new NXOpen.TaggedObject[1];
    objects37[0] = note54;
    bool added11;
    added11 = cutCopyPasteBuilder11.ObjectsToCopy.Add(objects37);
    
    NXOpen.Point3d origin178 = new NXOpen.Point3d(699.13318639743306, 42.391951648030584, 0.0);
    NXOpen.Vector3d normal11 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane11;
    plane11 = workPart.Planes.CreatePlane(origin178, normal11, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder11.PlaneToRestrictMotion = plane11;
    
    cutCopyPasteBuilder11.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder11.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder11.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder11.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder11.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder11.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder11.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder11.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder11.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId226, "粘贴 对话框");
    
    cutCopyPasteBuilder11.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder11.Transform.SetMotionToTwoDimensions(plane11);
    
    cutCopyPasteBuilder11.InitPaste();
    
    cutCopyPasteBuilder11.CutCopyPasteLeader.IsLeaderSelection = false;
    
    NXOpen.Point3d coordinates9 = new NXOpen.Point3d(758.24498055721483, 22.387655453714295, 0.0);
    NXOpen.Point point14;
    point14 = workPart.Points.CreatePoint(coordinates9);
    
    NXOpen.Point3d point15 = new NXOpen.Point3d(758.24498055721483, 22.387655453714295, 0.0);
    cutCopyPasteBuilder11.CutCopyPasteLeader.Selection.SetValue(point14, workPart.Views.WorkView, point15);
    
    NXOpen.Session.UndoMarkId markId227;
    markId227 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "粘贴");
    
    NXOpen.Matrix3x3 rot6 = new NXOpen.Matrix3x3();
    rot6.Xx = 1.0;
    rot6.Xy = 0.0;
    rot6.Xz = 0.0;
    rot6.Yx = 0.0;
    rot6.Yy = 1.0;
    rot6.Yz = 0.0;
    rot6.Zx = 0.0;
    rot6.Zy = 0.0;
    rot6.Zz = 1.0;
    NXOpen.Vector3d trans6 = new NXOpen.Vector3d(59.111794159781766, -20.004296194316289, 0.0);
    cutCopyPasteBuilder11.CutCopyPasteLeader.SetMoveOnCommit(rot6, trans6);
    
    NXOpen.NXObject nXObject9;
    nXObject9 = cutCopyPasteBuilder11.Commit();
    
    theSession.DeleteUndoMark(markId227, null);
    
    theSession.SetUndoMarkName(markId226, "粘贴");
    
    cutCopyPasteBuilder11.Destroy();
    
    workPart.Points.DeletePoint(point14);
    
    NXOpen.Session.UndoMarkId markId228;
    markId228 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Start");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder12;
    cutCopyPasteBuilder12 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder12.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder12.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation12 = new NXOpen.Point3d(699.13318639743306, 42.391951648030584, 0.0);
    cutCopyPasteBuilder12.SetDefaultToPoint(droplocation12);
    
    cutCopyPasteBuilder12.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects38 = new NXOpen.TaggedObject[1];
    objects38[0] = note54;
    bool added12;
    added12 = cutCopyPasteBuilder12.ObjectsToCopy.Add(objects38);
    
    NXOpen.Point3d origin179 = new NXOpen.Point3d(699.13318639743306, 42.391951648030584, 0.0);
    NXOpen.Vector3d normal12 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane12;
    plane12 = workPart.Planes.CreatePlane(origin179, normal12, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder12.PlaneToRestrictMotion = plane12;
    
    cutCopyPasteBuilder12.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder12.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder12.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder12.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder12.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder12.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder12.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder12.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder12.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId228, "粘贴 对话框");
    
    cutCopyPasteBuilder12.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder12.Transform.SetMotionToTwoDimensions(plane12);
    
    cutCopyPasteBuilder12.InitPaste();
    
    cutCopyPasteBuilder12.CutCopyPasteLeader.IsLeaderSelection = false;
    
    // ----------------------------------------------
    //   对话开始 粘贴
    // ----------------------------------------------
    cutCopyPasteBuilder12.Destroy();
    
    theSession.UndoToMark(markId228, null);
    
    theSession.DeleteUndoMark(markId228, null);
    
    int nErrs194;
    nErrs194 = theSession.UpdateManager.DoUpdate(markId226);
    
    NXOpen.Point3d scaleAboutPoint724 = new NXOpen.Point3d(61.274420775383959, -43.072313427401973, 0.0);
    NXOpen.Point3d viewCenter724 = new NXOpen.Point3d(-61.274420775383057, 43.072313427401909, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint724, viewCenter724);
    
    NXOpen.Point3d scaleAboutPoint725 = new NXOpen.Point3d(76.593025969229842, -53.840391784252454, 0.0);
    NXOpen.Point3d viewCenter725 = new NXOpen.Point3d(-76.593025969228918, 53.840391784252397, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint725, viewCenter725);
    
    NXOpen.Point3d scaleAboutPoint726 = new NXOpen.Point3d(95.741282461537153, -66.737305715835873, 0.0);
    NXOpen.Point3d viewCenter726 = new NXOpen.Point3d(-95.741282461536258, 66.737305715835845, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint726, viewCenter726);
    
    NXOpen.Point3d scaleAboutPoint727 = new NXOpen.Point3d(119.67660307692132, -81.661682099546056, 0.0);
    NXOpen.Point3d viewCenter727 = new NXOpen.Point3d(-119.67660307692044, 81.661682099545999, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint727, viewCenter727);
    
    NXOpen.Point3d scaleAboutPoint728 = new NXOpen.Point3d(149.59575384615152, -99.877165067871545, 0.0);
    NXOpen.Point3d viewCenter728 = new NXOpen.Point3d(-149.59575384615064, 99.877165067871431, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint728, viewCenter728);
    
    NXOpen.Point3d scaleAboutPoint729 = new NXOpen.Point3d(186.99469230768923, -117.69665927601594, 0.0);
    NXOpen.Point3d viewCenter729 = new NXOpen.Point3d(-186.99469230768847, 117.69665927601588, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint729, viewCenter729);
    
    NXOpen.Point3d origin180 = new NXOpen.Point3d(187.7363619805067, 175.30034315139434, 0.0);
    workPart.Views.WorkView.SetOrigin(origin180);
    
    NXOpen.Point3d origin181 = new NXOpen.Point3d(187.7363619805067, 175.30034315139434, 0.0);
    workPart.Views.WorkView.SetOrigin(origin181);
    
    NXOpen.Point3d scaleAboutPoint730 = new NXOpen.Point3d(-96.247268099545309, -81.122697398188564, 0.0);
    NXOpen.Point3d viewCenter730 = new NXOpen.Point3d(96.247268099545991, 81.12269739818845, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint730, viewCenter730);
    
    NXOpen.Point3d scaleAboutPoint731 = new NXOpen.Point3d(-76.447830090495941, -65.998126696831307, 0.0);
    NXOpen.Point3d viewCenter731 = new NXOpen.Point3d(76.447830090496581, 65.998126696831264, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint731, viewCenter731);
    
    NXOpen.Point3d scaleAboutPoint732 = new NXOpen.Point3d(-59.838301538459994, -54.118463891401767, 0.0);
    NXOpen.Point3d viewCenter732 = new NXOpen.Point3d(59.838301538460655, 54.118463891401653, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint732, viewCenter732);
    
    NXOpen.Point3d scaleAboutPoint733 = new NXOpen.Point3d(-46.110691185519137, -44.350741140270735, 0.0);
    NXOpen.Point3d viewCenter733 = new NXOpen.Point3d(46.11069118551984, 44.350741140270614, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint733, viewCenter733);
    
    NXOpen.Session.UndoMarkId markId229;
    markId229 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note55 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-224470"));
    note55.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin182 = new NXOpen.Point3d(165.5169926592402, 112.94751298578541, 0.0);
    note55.AnnotationOrigin = origin182;
    
    int nErrs195;
    nErrs195 = theSession.UpdateManager.DoUpdate(markId229);
    
    NXOpen.Session.UndoMarkId markId230;
    markId230 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note56 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 47 1"));
    note56.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin183 = new NXOpen.Point3d(150.87420828276987, 106.18930481202985, 0.0);
    note56.AnnotationOrigin = origin183;
    
    int nErrs196;
    nErrs196 = theSession.UpdateManager.DoUpdate(markId230);
    
    NXOpen.Session.UndoMarkId markId231;
    markId231 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note57 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-213590"));
    note57.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin184 = new NXOpen.Point3d(170.0224647750772, 88.167416348681684, 0.0);
    note57.AnnotationOrigin = origin184;
    
    int nErrs197;
    nErrs197 = theSession.UpdateManager.DoUpdate(markId231);
    
    NXOpen.Session.UndoMarkId markId232;
    markId232 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note58 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 46 1"));
    note58.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin185 = new NXOpen.Point3d(134.26027985562087, 74.932592008410381, 0.0);
    note58.AnnotationOrigin = origin185;
    
    int nErrs198;
    nErrs198 = theSession.UpdateManager.DoUpdate(markId232);
    
    NXOpen.Session.UndoMarkId markId233;
    markId233 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note59 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-213606"));
    note59.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin186 = new NXOpen.Point3d(171.7120168185161, 57.755479566781673, 0.0);
    note59.AnnotationOrigin = origin186;
    
    int nErrs199;
    nErrs199 = theSession.UpdateManager.DoUpdate(markId233);
    
    NXOpen.Session.UndoMarkId markId234;
    markId234 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note60 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 45 1"));
    note60.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin187 = new NXOpen.Point3d(160.72992853616336, 50.152495371306657, 0.0);
    note60.AnnotationOrigin = origin187;
    
    int nErrs200;
    nErrs200 = theSession.UpdateManager.DoUpdate(markId234);
    
    NXOpen.Session.UndoMarkId markId235;
    markId235 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note61 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-213635"));
    note61.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin188 = new NXOpen.Point3d(160.44833652892353, 32.693790922438126, 0.0);
    note61.AnnotationOrigin = origin188;
    
    int nErrs201;
    nErrs201 = theSession.UpdateManager.DoUpdate(markId235);
    
    NXOpen.Session.UndoMarkId markId236;
    markId236 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note62 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 44 1"));
    note62.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin189 = new NXOpen.Point3d(162.98266459408188, 24.527622712483492, 0.0);
    note62.AnnotationOrigin = origin189;
    
    int nErrs202;
    nErrs202 = theSession.UpdateManager.DoUpdate(markId236);
    
    NXOpen.Point3d scaleAboutPoint734 = new NXOpen.Point3d(-10.982088282352368, -15.205968390949986, 0.0);
    NXOpen.Point3d viewCenter734 = new NXOpen.Point3d(10.98208828235305, 15.205968390949891, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint734, viewCenter734);
    
    NXOpen.Point3d scaleAboutPoint735 = new NXOpen.Point3d(-42.238801085971694, -24.63930063348376, 0.0);
    NXOpen.Point3d viewCenter735 = new NXOpen.Point3d(42.238801085972455, 24.639300633483671, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint735, viewCenter735);
    
    NXOpen.Point3d scaleAboutPoint736 = new NXOpen.Point3d(9.2397377375568457, 47.078663710406317, 0.0);
    NXOpen.Point3d viewCenter736 = new NXOpen.Point3d(-9.2397377375560747, -47.078663710406389, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint736, viewCenter736);
    
    NXOpen.Point3d scaleAboutPoint737 = new NXOpen.Point3d(10.999687782805571, 53.348485746605242, 0.0);
    NXOpen.Point3d viewCenter737 = new NXOpen.Point3d(-10.99968778280493, -53.348485746605377, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint737, viewCenter737);
    
    NXOpen.Point3d scaleAboutPoint738 = new NXOpen.Point3d(-32.31158286198994, 47.436153563347453, 0.0);
    NXOpen.Point3d viewCenter738 = new NXOpen.Point3d(32.31158286199063, -47.436153563347567, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint738, viewCenter738);
    
    NXOpen.Point3d scaleAboutPoint739 = new NXOpen.Point3d(-50.701685873867454, 55.857789522057686, 0.0);
    NXOpen.Point3d viewCenter739 = new NXOpen.Point3d(50.701685873868172, -55.857789522057828, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint739, viewCenter739);
    
    NXOpen.Point3d scaleAboutPoint740 = new NXOpen.Point3d(-68.748048642532268, 67.673860382492975, 0.0);
    NXOpen.Point3d viewCenter740 = new NXOpen.Point3d(68.748048642532808, -67.67386038249316, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint740, viewCenter740);
    
    NXOpen.Point3d scaleAboutPoint741 = new NXOpen.Point3d(5.3709413001984574, 175.89832758147983, 0.0);
    NXOpen.Point3d viewCenter741 = new NXOpen.Point3d(-5.3709413001975612, -175.89832758148003, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint741, viewCenter741);
    
    NXOpen.Point3d scaleAboutPoint742 = new NXOpen.Point3d(4.296753040158765, 140.71866206518382, 0.0);
    NXOpen.Point3d viewCenter742 = new NXOpen.Point3d(-4.2967530401578697, -140.71866206518402, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint742, viewCenter742);
    
    NXOpen.Point3d scaleAboutPoint743 = new NXOpen.Point3d(3.4374024321271559, 112.57492965214709, 0.0);
    NXOpen.Point3d viewCenter743 = new NXOpen.Point3d(-3.4374024321262961, -112.57492965214723, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint743, viewCenter743);
    
    NXOpen.Point3d scaleAboutPoint744 = new NXOpen.Point3d(2.7499219457018391, 90.059943721717602, 0.0);
    NXOpen.Point3d viewCenter744 = new NXOpen.Point3d(-2.7499219457009221, -90.059943721717843, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint744, viewCenter744);
    
    NXOpen.Session.UndoMarkId markId237;
    markId237 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Point3d drawingReferencePoint32 = new NXOpen.Point3d(150.42773631065467, 182.64068782058732, 0.0);
    sectionView5.MoveView(drawingReferencePoint32);
    
    int nErrs203;
    nErrs203 = theSession.UpdateManager.DoUpdate(markId237);
    
    NXOpen.Point3d scaleAboutPoint745 = new NXOpen.Point3d(-4.9498595022618206, 19.7994380090493, 0.0);
    NXOpen.Point3d viewCenter745 = new NXOpen.Point3d(4.9498595022627843, -19.799438009049485, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint745, viewCenter745);
    
    NXOpen.Session.UndoMarkId markId238;
    markId238 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Point3d drawingReferencePoint33 = new NXOpen.Point3d(165.38731169526969, 185.72060039977276, 0.0);
    sectionView5.MoveView(drawingReferencePoint33);
    
    int nErrs204;
    nErrs204 = theSession.UpdateManager.DoUpdate(markId238);
    
    NXOpen.Session.UndoMarkId markId239;
    markId239 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note31.InsertIntoStack(label21, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    label21.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin190 = new NXOpen.Point3d(249.01232271217984, 261.90274126273431, 0.0);
    label21.AnnotationOrigin = origin190;
    
    int nErrs205;
    nErrs205 = theSession.UpdateManager.DoUpdate(markId239);
    
    NXOpen.Point3d origin191 = new NXOpen.Point3d(420.60745212392879, 231.54360298219174, 0.0);
    workPart.Views.WorkView.SetOrigin(origin191);
    
    NXOpen.Point3d origin192 = new NXOpen.Point3d(420.60745212392879, 231.54360298219174, 0.0);
    workPart.Views.WorkView.SetOrigin(origin192);
    
    NXOpen.Point3d scaleAboutPoint746 = new NXOpen.Point3d(92.397377375564375, 131.55626588235035, 0.0);
    NXOpen.Point3d viewCenter746 = new NXOpen.Point3d(-92.397377375563352, -131.55626588235052, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint746, viewCenter746);
    
    NXOpen.Point3d origin193 = new NXOpen.Point3d(261.11197927324167, 179.40508289169566, 0.0);
    workPart.Views.WorkView.SetOrigin(origin193);
    
    NXOpen.Point3d origin194 = new NXOpen.Point3d(261.11197927324167, 179.40508289169566, 0.0);
    workPart.Views.WorkView.SetOrigin(origin194);
    
    NXOpen.Point3d scaleAboutPoint747 = new NXOpen.Point3d(-124.84645633483869, -71.497970588233983, 0.0);
    NXOpen.Point3d viewCenter747 = new NXOpen.Point3d(124.8464563348397, 71.497970588233841, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint747, viewCenter747);
    
    NXOpen.Point3d scaleAboutPoint748 = new NXOpen.Point3d(-99.877165067870877, -57.19837647058722, 0.0);
    NXOpen.Point3d viewCenter748 = new NXOpen.Point3d(99.8771650678719, 57.198376470587107, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint748, viewCenter748);
    
    NXOpen.Point3d scaleAboutPoint749 = new NXOpen.Point3d(-79.901732054296573, -45.758701176469771, 0.0);
    NXOpen.Point3d viewCenter749 = new NXOpen.Point3d(79.901732054297639, 45.758701176469657, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint749, viewCenter749);
    
    NXOpen.Point3d scaleAboutPoint750 = new NXOpen.Point3d(-63.921385643437162, -36.606960941175842, 0.0);
    NXOpen.Point3d viewCenter750 = new NXOpen.Point3d(63.9213856434382, 36.606960941175679, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint750, viewCenter750);
    
    NXOpen.Session.UndoMarkId markId240;
    markId240 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Annotations.DraftingNoteBuilder draftingNoteBuilder4;
    draftingNoteBuilder4 = workPart.Annotations.CreateDraftingNoteBuilder(note56);
    
    draftingNoteBuilder4.Text.TextBlock.CustomSymbolScale = 1.0;
    
    draftingNoteBuilder4.Origin.SetInferRelativeToGeometry(true);
    
    theSession.SetUndoMarkName(markId240, "注释 对话框");
    
    draftingNoteBuilder4.Origin.SetInferRelativeToGeometry(true);
    
    NXOpen.Annotations.LeaderData leaderData5;
    leaderData5 = workPart.Annotations.CreateLeaderData();
    
    leaderData5.StubSize = 3.5000000103999995;
    
    leaderData5.Arrowhead = NXOpen.Annotations.LeaderData.ArrowheadType.FilledArrow;
    
    leaderData5.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Center;
    
    draftingNoteBuilder4.Leader.Leaders.Append(leaderData5);
    
    leaderData5.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Legacy;
    
    leaderData5.StubSide = NXOpen.Annotations.LeaderSide.Inferred;
    
    double symbolscale4;
    symbolscale4 = draftingNoteBuilder4.Text.TextBlock.SymbolScale;
    
    double symbolaspectratio4;
    symbolaspectratio4 = draftingNoteBuilder4.Text.TextBlock.SymbolAspectRatio;
    
    draftingNoteBuilder4.Origin.SetInferRelativeToGeometry(true);
    
    draftingNoteBuilder4.Origin.SetInferRelativeToGeometry(true);
    
    // ----------------------------------------------
    //   对话开始 注释
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId241;
    markId241 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.DeleteUndoMark(markId241, null);
    
    NXOpen.Session.UndoMarkId markId242;
    markId242 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId242, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId242, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId240, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId243;
    markId243 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId243, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId243, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId240, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId244;
    markId244 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    string[] text2 = new string[1];
    text2[0] = "<F34><C1.30>仅用于测量的非对称轮廓规格在42-5000-100-01图纸上展示<C><F>";
    draftingNoteBuilder4.Text.TextBlock.SetText(text2);
    
    theSession.SetUndoMarkName(markId244, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId244, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId240, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId245;
    markId245 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    NXOpen.Session.UndoMarkId markId246;
    markId246 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    NXOpen.NXObject nXObject10;
    nXObject10 = draftingNoteBuilder4.Commit();
    
    theSession.DeleteUndoMark(markId246, null);
    
    theSession.SetUndoMarkName(markId240, "注释");
    
    draftingNoteBuilder4.Destroy();
    
    theSession.DeleteUndoMark(markId245, null);
    
    theSession.SetUndoMarkVisibility(markId240, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.DeleteUndoMark(markId244, null);
    
    theSession.DeleteUndoMark(markId243, null);
    
    theSession.DeleteUndoMark(markId242, null);
    
    NXOpen.Point3d origin195 = new NXOpen.Point3d(187.40263145315265, 112.41258441930029, 0.0);
    workPart.Views.WorkView.SetOrigin(origin195);
    
    NXOpen.Point3d origin196 = new NXOpen.Point3d(187.40263145315265, 112.41258441930029, 0.0);
    workPart.Views.WorkView.SetOrigin(origin196);
    
    NXOpen.Point3d scaleAboutPoint751 = new NXOpen.Point3d(-56.093127842170368, -35.367956109320666, 0.0);
    NXOpen.Point3d viewCenter751 = new NXOpen.Point3d(56.093127842171349, 35.367956109320517, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint751, viewCenter751);
    
    NXOpen.Point3d scaleAboutPoint752 = new NXOpen.Point3d(-44.874502273736205, -28.29436488745656, 0.0);
    NXOpen.Point3d viewCenter752 = new NXOpen.Point3d(44.874502273737193, 28.294364887456378, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint752, viewCenter752);
    
    NXOpen.Session.UndoMarkId markId247;
    markId247 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Annotations.DraftingNoteBuilder draftingNoteBuilder5;
    draftingNoteBuilder5 = workPart.Annotations.CreateDraftingNoteBuilder(note58);
    
    draftingNoteBuilder5.Text.TextBlock.CustomSymbolScale = 1.0;
    
    draftingNoteBuilder5.Origin.SetInferRelativeToGeometry(true);
    
    theSession.SetUndoMarkName(markId247, "注释 对话框");
    
    draftingNoteBuilder5.Origin.SetInferRelativeToGeometry(true);
    
    NXOpen.Annotations.LeaderData leaderData6;
    leaderData6 = workPart.Annotations.CreateLeaderData();
    
    leaderData6.StubSize = 3.5000000103999995;
    
    leaderData6.Arrowhead = NXOpen.Annotations.LeaderData.ArrowheadType.FilledArrow;
    
    leaderData6.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Center;
    
    draftingNoteBuilder5.Leader.Leaders.Append(leaderData6);
    
    leaderData6.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Legacy;
    
    leaderData6.StubSide = NXOpen.Annotations.LeaderSide.Inferred;
    
    double symbolscale5;
    symbolscale5 = draftingNoteBuilder5.Text.TextBlock.SymbolScale;
    
    double symbolaspectratio5;
    symbolaspectratio5 = draftingNoteBuilder5.Text.TextBlock.SymbolAspectRatio;
    
    draftingNoteBuilder5.Origin.SetInferRelativeToGeometry(true);
    
    draftingNoteBuilder5.Origin.SetInferRelativeToGeometry(true);
    
    // ----------------------------------------------
    //   对话开始 注释
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId248;
    markId248 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.DeleteUndoMark(markId248, null);
    
    NXOpen.Session.UndoMarkId markId249;
    markId249 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId249, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId249, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId247, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId250;
    markId250 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId250, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId250, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId247, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId251;
    markId251 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId251, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId251, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId247, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId252;
    markId252 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId252, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId252, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId247, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId253;
    markId253 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    NXOpen.Point3d scaleAboutPoint753 = new NXOpen.Point3d(44.982633604517282, 3.1718523695491672, 0.0);
    NXOpen.Point3d viewCenter753 = new NXOpen.Point3d(-44.982633604516302, -3.1718523695493595, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint753, viewCenter753);
    
    NXOpen.Point3d scaleAboutPoint754 = new NXOpen.Point3d(61.274420775383945, 5.4065665390043138, 0.0);
    NXOpen.Point3d viewCenter754 = new NXOpen.Point3d(-61.274420775382922, -5.4065665390045092, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint754, viewCenter754);
    
    theSession.SetUndoMarkName(markId253, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId253, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId247, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId254;
    markId254 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId254, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId254, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId247, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId255;
    markId255 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId255, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId255, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId247, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId256;
    markId256 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId256, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId256, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId247, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId257;
    markId257 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId257, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId257, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId247, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId258;
    markId258 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    string[] text3 = new string[2];
    text3[0] = "<F34><C1.30>激光蚀刻：商标，<O>1.5圆。批号和“C”。字符高度1。";
    text3[1] = "“2”和“R”。字符高度 2 。位置如图所示<C><F>";
    draftingNoteBuilder5.Text.TextBlock.SetText(text3);
    
    theSession.SetUndoMarkName(markId258, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId258, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId247, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId259;
    markId259 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    NXOpen.Session.UndoMarkId markId260;
    markId260 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    NXOpen.NXObject nXObject11;
    nXObject11 = draftingNoteBuilder5.Commit();
    
    theSession.DeleteUndoMark(markId260, null);
    
    theSession.SetUndoMarkName(markId247, "注释");
    
    draftingNoteBuilder5.Destroy();
    
    theSession.DeleteUndoMark(markId259, null);
    
    theSession.SetUndoMarkVisibility(markId247, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.DeleteUndoMark(markId258, null);
    
    theSession.DeleteUndoMark(markId257, null);
    
    theSession.DeleteUndoMark(markId256, null);
    
    theSession.DeleteUndoMark(markId255, null);
    
    theSession.DeleteUndoMark(markId254, null);
    
    theSession.DeleteUndoMark(markId253, null);
    
    theSession.DeleteUndoMark(markId252, null);
    
    theSession.DeleteUndoMark(markId251, null);
    
    theSession.DeleteUndoMark(markId250, null);
    
    theSession.DeleteUndoMark(markId249, null);
    
    NXOpen.Point3d scaleAboutPoint755 = new NXOpen.Point3d(-53.164570966876255, -34.016314474569562, 0.0);
    NXOpen.Point3d viewCenter755 = new NXOpen.Point3d(53.164570966877271, 34.01631447456937, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint755, viewCenter755);
    
    NXOpen.Point3d scaleAboutPoint756 = new NXOpen.Point3d(-69.834817795473256, -45.336313165610051, 0.0);
    NXOpen.Point3d viewCenter756 = new NXOpen.Point3d(69.834817795474237, 45.336313165609887, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint756, viewCenter756);
    
    NXOpen.Point3d scaleAboutPoint757 = new NXOpen.Point3d(-149.59575384615039, -91.869392361989242, 0.0);
    NXOpen.Point3d viewCenter757 = new NXOpen.Point3d(149.59575384615141, 91.869392361989057, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint757, viewCenter757);
    
    NXOpen.Point3d scaleAboutPoint758 = new NXOpen.Point3d(-120.23978709139985, -73.495513889591408, 0.0);
    NXOpen.Point3d viewCenter758 = new NXOpen.Point3d(120.23978709140087, 73.495513889591223, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint758, viewCenter758);
    
    NXOpen.Point3d scaleAboutPoint759 = new NXOpen.Point3d(-96.417103278911611, -59.021684717465035, 0.0);
    NXOpen.Point3d viewCenter759 = new NXOpen.Point3d(96.41710327891262, 59.021684717464829, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint759, viewCenter759);
    
    NXOpen.Point3d scaleAboutPoint760 = new NXOpen.Point3d(-77.133682623129204, -47.21734777397203, 0.0);
    NXOpen.Point3d viewCenter760 = new NXOpen.Point3d(77.133682623130227, 47.217347773971838, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint760, viewCenter760);
    
    NXOpen.Point3d scaleAboutPoint761 = new NXOpen.Point3d(-61.706946098503259, -37.773878219177654, 0.0);
    NXOpen.Point3d viewCenter761 = new NXOpen.Point3d(61.706946098504297, 37.773878219177462, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint761, viewCenter761);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->复制(C)
    // ----------------------------------------------
    workPart.PmiManager.RestoreUnpastedObjects();
    
    // ----------------------------------------------
    //   菜单：编辑(E)->粘贴(P)
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId261;
    markId261 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder13;
    cutCopyPasteBuilder13 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder13.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder13.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation13 = new NXOpen.Point3d(70.376034437964179, 55.498109010412584, 0.0);
    cutCopyPasteBuilder13.SetDefaultToPoint(droplocation13);
    
    cutCopyPasteBuilder13.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects39 = new NXOpen.TaggedObject[1];
    NXOpen.Annotations.Note note63 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 43 1"));
    objects39[0] = note63;
    bool added13;
    added13 = cutCopyPasteBuilder13.ObjectsToCopy.Add(objects39);
    
    NXOpen.Point3d origin197 = new NXOpen.Point3d(70.376034437964179, 55.498109010412584, 0.0);
    NXOpen.Vector3d normal13 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane13;
    plane13 = workPart.Planes.CreatePlane(origin197, normal13, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder13.PlaneToRestrictMotion = plane13;
    
    cutCopyPasteBuilder13.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder13.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder13.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder13.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder13.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder13.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder13.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder13.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder13.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId261, "粘贴 对话框");
    
    cutCopyPasteBuilder13.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder13.Transform.SetMotionToTwoDimensions(plane13);
    
    cutCopyPasteBuilder13.InitPaste();
    
    cutCopyPasteBuilder13.CutCopyPasteLeader.IsLeaderSelection = false;
    
    NXOpen.Point3d coordinates10 = new NXOpen.Point3d(2.6714038588581701, 26.893767641386614, 0.0);
    NXOpen.Point point16;
    point16 = workPart.Points.CreatePoint(coordinates10);
    
    NXOpen.Point3d point17 = new NXOpen.Point3d(2.6714038588581701, 26.893767641386614, 0.0);
    cutCopyPasteBuilder13.CutCopyPasteLeader.Selection.SetValue(point16, workPart.Views.WorkView, point17);
    
    NXOpen.Session.UndoMarkId markId262;
    markId262 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "粘贴");
    
    NXOpen.Matrix3x3 rot7 = new NXOpen.Matrix3x3();
    rot7.Xx = 1.0;
    rot7.Xy = 0.0;
    rot7.Xz = 0.0;
    rot7.Yx = 0.0;
    rot7.Yy = 1.0;
    rot7.Yz = 0.0;
    rot7.Zx = 0.0;
    rot7.Zy = 0.0;
    rot7.Zz = 1.0;
    NXOpen.Vector3d trans7 = new NXOpen.Vector3d(-67.704630579106009, -28.60434136902597, 0.0);
    cutCopyPasteBuilder13.CutCopyPasteLeader.SetMoveOnCommit(rot7, trans7);
    
    NXOpen.NXObject nXObject12;
    nXObject12 = cutCopyPasteBuilder13.Commit();
    
    theSession.DeleteUndoMark(markId262, null);
    
    theSession.SetUndoMarkName(markId261, "粘贴");
    
    cutCopyPasteBuilder13.Destroy();
    
    workPart.Points.DeletePoint(point16);
    
    NXOpen.Session.UndoMarkId markId263;
    markId263 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Start");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder14;
    cutCopyPasteBuilder14 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder14.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder14.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation14 = new NXOpen.Point3d(70.376034437964179, 55.498109010412584, 0.0);
    cutCopyPasteBuilder14.SetDefaultToPoint(droplocation14);
    
    cutCopyPasteBuilder14.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects40 = new NXOpen.TaggedObject[1];
    objects40[0] = note63;
    bool added14;
    added14 = cutCopyPasteBuilder14.ObjectsToCopy.Add(objects40);
    
    NXOpen.Point3d origin198 = new NXOpen.Point3d(70.376034437964179, 55.498109010412584, 0.0);
    NXOpen.Vector3d normal14 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane14;
    plane14 = workPart.Planes.CreatePlane(origin198, normal14, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder14.PlaneToRestrictMotion = plane14;
    
    cutCopyPasteBuilder14.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder14.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder14.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder14.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder14.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder14.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder14.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder14.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder14.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId263, "粘贴 对话框");
    
    cutCopyPasteBuilder14.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder14.Transform.SetMotionToTwoDimensions(plane14);
    
    cutCopyPasteBuilder14.InitPaste();
    
    cutCopyPasteBuilder14.CutCopyPasteLeader.IsLeaderSelection = false;
    
    // ----------------------------------------------
    //   对话开始 粘贴
    // ----------------------------------------------
    cutCopyPasteBuilder14.Destroy();
    
    theSession.UndoToMark(markId263, null);
    
    theSession.DeleteUndoMark(markId263, null);
    
    int nErrs206;
    nErrs206 = theSession.UpdateManager.DoUpdate(markId261);
    
    NXOpen.Session.UndoMarkId markId264;
    markId264 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Annotations.Note note64 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 1 1"));
    NXOpen.Annotations.DraftingNoteBuilder draftingNoteBuilder6;
    draftingNoteBuilder6 = workPart.Annotations.CreateDraftingNoteBuilder(note64);
    
    draftingNoteBuilder6.Text.TextBlock.CustomSymbolScale = 1.0;
    
    draftingNoteBuilder6.Origin.SetInferRelativeToGeometry(true);
    
    theSession.SetUndoMarkName(markId264, "注释 对话框");
    
    draftingNoteBuilder6.Origin.SetInferRelativeToGeometry(true);
    
    NXOpen.Annotations.LeaderData leaderData7;
    leaderData7 = workPart.Annotations.CreateLeaderData();
    
    leaderData7.StubSize = 3.5000000103999995;
    
    leaderData7.Arrowhead = NXOpen.Annotations.LeaderData.ArrowheadType.FilledArrow;
    
    leaderData7.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Center;
    
    draftingNoteBuilder6.Leader.Leaders.Append(leaderData7);
    
    leaderData7.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Legacy;
    
    leaderData7.StubSide = NXOpen.Annotations.LeaderSide.Inferred;
    
    double symbolscale6;
    symbolscale6 = draftingNoteBuilder6.Text.TextBlock.SymbolScale;
    
    double symbolaspectratio6;
    symbolaspectratio6 = draftingNoteBuilder6.Text.TextBlock.SymbolAspectRatio;
    
    draftingNoteBuilder6.Origin.SetInferRelativeToGeometry(true);
    
    draftingNoteBuilder6.Origin.SetInferRelativeToGeometry(true);
    
    // ----------------------------------------------
    //   对话开始 注释
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId265;
    markId265 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.DeleteUndoMark(markId265, null);
    
    NXOpen.Session.UndoMarkId markId266;
    markId266 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId266, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId266, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId264, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId267;
    markId267 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId267, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId267, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId264, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId268;
    markId268 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId268, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId268, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId264, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId269;
    markId269 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    string[] text4 = new string[1];
    text4[0] = "<C0.80>F-A<C>";
    draftingNoteBuilder6.Text.TextBlock.SetText(text4);
    
    theSession.SetUndoMarkName(markId269, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId269, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId264, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId270;
    markId270 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    NXOpen.Session.UndoMarkId markId271;
    markId271 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    NXOpen.NXObject nXObject13;
    nXObject13 = draftingNoteBuilder6.Commit();
    
    theSession.DeleteUndoMark(markId271, null);
    
    theSession.SetUndoMarkName(markId264, "注释");
    
    draftingNoteBuilder6.Destroy();
    
    theSession.DeleteUndoMark(markId270, null);
    
    theSession.SetUndoMarkVisibility(markId264, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.DeleteUndoMark(markId269, null);
    
    theSession.DeleteUndoMark(markId268, null);
    
    theSession.DeleteUndoMark(markId267, null);
    
    theSession.DeleteUndoMark(markId266, null);
    
    NXOpen.Session.UndoMarkId markId272;
    markId272 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note65 = ((NXOpen.Annotations.Note)nXObject13);
    note65.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin199 = new NXOpen.Point3d(10.860549976603536, 26.4324072967249, 0.0);
    note65.AnnotationOrigin = origin199;
    
    int nErrs207;
    nErrs207 = theSession.UpdateManager.DoUpdate(markId272);
    
    NXOpen.Point3d scaleAboutPoint762 = new NXOpen.Point3d(-69.088711613090638, -8.0738060315800322, 0.0);
    NXOpen.Point3d viewCenter762 = new NXOpen.Point3d(69.088711613091661, 8.0738060315798492, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint762, viewCenter762);
    
    NXOpen.Point3d scaleAboutPoint763 = new NXOpen.Point3d(-86.360889516363429, -10.236432647181786, 0.0);
    NXOpen.Point3d viewCenter763 = new NXOpen.Point3d(86.360889516364438, 10.236432647181607, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint763, viewCenter763);
    
    NXOpen.Point3d scaleAboutPoint764 = new NXOpen.Point3d(-107.77089301082093, -12.615321924343739, 0.0);
    NXOpen.Point3d viewCenter764 = new NXOpen.Point3d(107.77089301082194, 12.615321924343558, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint764, viewCenter764);
    
    NXOpen.Point3d scaleAboutPoint765 = new NXOpen.Point3d(-94.164367220993114, -6.3076609621719033, 0.0);
    NXOpen.Point3d viewCenter765 = new NXOpen.Point3d(94.164367220994123, 6.3076609621717719, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint765, viewCenter765);
    
    NXOpen.Point3d scaleAboutPoint766 = new NXOpen.Point3d(-117.70545902624154, -7.8845762027148565, 0.0);
    NXOpen.Point3d viewCenter766 = new NXOpen.Point3d(117.70545902624258, 7.8845762027147162, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint766, viewCenter766);
    
    NXOpen.Point3d scaleAboutPoint767 = new NXOpen.Point3d(-146.77983377375227, -9.8557202533935389, 0.0);
    NXOpen.Point3d viewCenter767 = new NXOpen.Point3d(146.77983377375327, 9.8557202533934216, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint767, viewCenter767);
    
    NXOpen.Point3d scaleAboutPoint768 = new NXOpen.Point3d(-183.47479221719044, -12.319650316741923, 0.0);
    NXOpen.Point3d viewCenter768 = new NXOpen.Point3d(183.47479221719146, 12.319650316741813, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint768, viewCenter768);
    
    NXOpen.Point3d origin200 = new NXOpen.Point3d(391.05888347600518, 119.62005856100745, 0.0);
    workPart.Views.WorkView.SetOrigin(origin200);
    
    NXOpen.Point3d origin201 = new NXOpen.Point3d(391.05888347600518, 119.62005856100745, 0.0);
    workPart.Views.WorkView.SetOrigin(origin201);
    
    NXOpen.Point3d origin202 = new NXOpen.Point3d(568.70384116829155, 232.3668583347625, 0.0);
    workPart.Views.WorkView.SetOrigin(origin202);
    
    NXOpen.Point3d origin203 = new NXOpen.Point3d(568.70384116829155, 232.3668583347625, 0.0);
    workPart.Views.WorkView.SetOrigin(origin203);
    
    NXOpen.Point3d scaleAboutPoint769 = new NXOpen.Point3d(235.39331855203221, 183.14480158370679, 0.0);
    NXOpen.Point3d viewCenter769 = new NXOpen.Point3d(-235.39331855203122, -183.14480158370688, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint769, viewCenter769);
    
    NXOpen.Point3d scaleAboutPoint770 = new NXOpen.Point3d(188.31465484162584, 146.51584126696542, 0.0);
    NXOpen.Point3d viewCenter770 = new NXOpen.Point3d(-188.3146548416249, -146.51584126696551, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint770, viewCenter770);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->复制(C)
    // ----------------------------------------------
    workPart.PmiManager.RestoreUnpastedObjects();
    
    // ----------------------------------------------
    //   菜单：编辑(E)->粘贴(P)
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId273;
    markId273 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder15;
    cutCopyPasteBuilder15 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder15.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder15.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation15 = new NXOpen.Point3d(653.44543584702285, 298.29898690489659, 0.0);
    cutCopyPasteBuilder15.SetDefaultToPoint(droplocation15);
    
    cutCopyPasteBuilder15.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects41 = new NXOpen.TaggedObject[1];
    objects41[0] = note13;
    bool added15;
    added15 = cutCopyPasteBuilder15.ObjectsToCopy.Add(objects41);
    
    NXOpen.Point3d origin204 = new NXOpen.Point3d(653.44543584702285, 298.29898690489659, 0.0);
    NXOpen.Vector3d normal15 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane15;
    plane15 = workPart.Planes.CreatePlane(origin204, normal15, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder15.PlaneToRestrictMotion = plane15;
    
    cutCopyPasteBuilder15.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder15.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder15.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder15.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder15.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder15.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder15.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder15.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder15.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId273, "粘贴 对话框");
    
    cutCopyPasteBuilder15.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder15.Transform.SetMotionToTwoDimensions(plane15);
    
    cutCopyPasteBuilder15.InitPaste();
    
    cutCopyPasteBuilder15.CutCopyPasteLeader.IsLeaderSelection = true;
    
    cutCopyPasteBuilder15.Destroy();
    
    theSession.UndoToMark(markId273, null);
    
    theSession.DeleteUndoMark(markId273, null);
    
    int nErrs208;
    nErrs208 = theSession.UpdateManager.DoUpdate(markId272);
    
    NXOpen.Point3d scaleAboutPoint771 = new NXOpen.Point3d(174.93903449773458, -133.05222342081194, 0.0);
    NXOpen.Point3d viewCenter771 = new NXOpen.Point3d(-174.9390344977337, 133.05222342081183, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint771, viewCenter771);
    
    NXOpen.Point3d scaleAboutPoint772 = new NXOpen.Point3d(139.95122759818761, -106.44177873664952, 0.0);
    NXOpen.Point3d viewCenter772 = new NXOpen.Point3d(-139.95122759818693, 106.44177873664945, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint772, viewCenter772);
    
    NXOpen.Point3d scaleAboutPoint773 = new NXOpen.Point3d(111.96098207855019, -85.153422989319679, 0.0);
    NXOpen.Point3d viewCenter773 = new NXOpen.Point3d(-111.96098207854951, 85.153422989319552, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint773, viewCenter773);
    
    NXOpen.Point3d scaleAboutPoint774 = new NXOpen.Point3d(89.568785662840213, -68.122738391455755, 0.0);
    NXOpen.Point3d viewCenter774 = new NXOpen.Point3d(-89.568785662839517, 68.122738391455613, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint774, viewCenter774);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->复制(C)
    // ----------------------------------------------
    workPart.PmiManager.RestoreUnpastedObjects();
    
    // ----------------------------------------------
    //   菜单：编辑(E)->粘贴(P)
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId274;
    markId274 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder16;
    cutCopyPasteBuilder16 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder16.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder16.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation16 = new NXOpen.Point3d(756.72944181448497, 219.74495419724965, 0.0);
    cutCopyPasteBuilder16.SetDefaultToPoint(droplocation16);
    
    cutCopyPasteBuilder16.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects42 = new NXOpen.TaggedObject[1];
    objects42[0] = note13;
    bool added16;
    added16 = cutCopyPasteBuilder16.ObjectsToCopy.Add(objects42);
    
    NXOpen.Point3d origin205 = new NXOpen.Point3d(756.72944181448497, 219.74495419724965, 0.0);
    NXOpen.Vector3d normal16 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane16;
    plane16 = workPart.Planes.CreatePlane(origin205, normal16, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder16.PlaneToRestrictMotion = plane16;
    
    cutCopyPasteBuilder16.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder16.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder16.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder16.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder16.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder16.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder16.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder16.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder16.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId274, "粘贴 对话框");
    
    cutCopyPasteBuilder16.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder16.Transform.SetMotionToTwoDimensions(plane16);
    
    cutCopyPasteBuilder16.InitPaste();
    
    cutCopyPasteBuilder16.CutCopyPasteLeader.IsLeaderSelection = true;
    
    cutCopyPasteBuilder16.Destroy();
    
    theSession.UndoToMark(markId274, null);
    
    theSession.DeleteUndoMark(markId274, null);
    
    int nErrs209;
    nErrs209 = theSession.UpdateManager.DoUpdate(markId272);
    
    NXOpen.Session.UndoMarkId markId275;
    markId275 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note13.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Annotation.AssociativeOriginData assocOrigin1 = new NXOpen.Annotations.Annotation.AssociativeOriginData();
    assocOrigin1.OriginType = NXOpen.Annotations.AssociativeOriginType.VerticallyAligned;
    NXOpen.View nullNXOpen_View = null;
    assocOrigin1.View = nullNXOpen_View;
    assocOrigin1.ViewOfGeometry = nullNXOpen_View;
    NXOpen.Point nullNXOpen_Point = null;
    assocOrigin1.PointOnGeometry = nullNXOpen_Point;
    assocOrigin1.VertAnnotation = label7;
    assocOrigin1.VertAlignmentPosition = NXOpen.Annotations.AlignmentPosition.BottomCenter;
    NXOpen.Annotations.Annotation nullNXOpen_Annotations_Annotation = null;
    assocOrigin1.HorizAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin1.HorizAlignmentPosition = NXOpen.Annotations.AlignmentPosition.TopLeft;
    assocOrigin1.AlignedAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin1.DimensionLine = 0;
    assocOrigin1.AssociatedView = nullNXOpen_View;
    assocOrigin1.AssociatedPoint = nullNXOpen_Point;
    assocOrigin1.OffsetAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin1.OffsetAlignmentPosition = NXOpen.Annotations.AlignmentPosition.TopLeft;
    assocOrigin1.XOffsetFactor = 0.0;
    assocOrigin1.YOffsetFactor = 0.0;
    assocOrigin1.StackAlignmentPosition = NXOpen.Annotations.StackAlignmentPosition.Above;
    NXOpen.Point3d origin206 = new NXOpen.Point3d(805.12703501309886, 216.42892671999456, 0.0);
    note13.SetAssociativeOrigin(assocOrigin1, origin206);
    
    int nErrs210;
    nErrs210 = theSession.UpdateManager.DoUpdate(markId275);
    
    NXOpen.Session.UndoMarkId markId276;
    markId276 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Annotation.AssociativeOriginData assocOrigin2 = new NXOpen.Annotations.Annotation.AssociativeOriginData();
    assocOrigin2.OriginType = NXOpen.Annotations.AssociativeOriginType.Drag;
    assocOrigin2.View = nullNXOpen_View;
    assocOrigin2.ViewOfGeometry = nullNXOpen_View;
    assocOrigin2.PointOnGeometry = nullNXOpen_Point;
    assocOrigin2.VertAnnotation = label7;
    assocOrigin2.VertAlignmentPosition = NXOpen.Annotations.AlignmentPosition.BottomCenter;
    assocOrigin2.HorizAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin2.HorizAlignmentPosition = NXOpen.Annotations.AlignmentPosition.TopLeft;
    assocOrigin2.AlignedAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin2.DimensionLine = 0;
    assocOrigin2.AssociatedView = nullNXOpen_View;
    assocOrigin2.AssociatedPoint = nullNXOpen_Point;
    assocOrigin2.OffsetAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin2.OffsetAlignmentPosition = NXOpen.Annotations.AlignmentPosition.TopLeft;
    assocOrigin2.XOffsetFactor = 0.0;
    assocOrigin2.YOffsetFactor = 0.0;
    assocOrigin2.StackAlignmentPosition = NXOpen.Annotations.StackAlignmentPosition.Above;
    NXOpen.Point3d origin207 = new NXOpen.Point3d(805.12703501309886, 216.42892671999456, 0.0);
    note13.SetAssociativeOrigin(assocOrigin2, origin207);
    
    note13.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin208 = new NXOpen.Point3d(804.73975268084416, 170.58124246923688, 0.0);
    note13.AnnotationOrigin = origin208;
    
    int nErrs211;
    nErrs211 = theSession.UpdateManager.DoUpdate(markId276);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->复制(C)
    // ----------------------------------------------
    workPart.PmiManager.RestoreUnpastedObjects();
    
    NXOpen.Session.UndoMarkId markId277;
    markId277 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    label7.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromLeft;
    
    NXOpen.Point3d origin209 = new NXOpen.Point3d(798.82857326486601, 212.19245324533989, 0.0);
    label7.AnnotationOrigin = origin209;
    
    int nErrs212;
    nErrs212 = theSession.UpdateManager.DoUpdate(markId277);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->粘贴(P)
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId278;
    markId278 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder17;
    cutCopyPasteBuilder17 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder17.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder17.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation17 = new NXOpen.Point3d(756.72944181448497, 219.74495419724965, 0.0);
    cutCopyPasteBuilder17.SetDefaultToPoint(droplocation17);
    
    cutCopyPasteBuilder17.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects43 = new NXOpen.TaggedObject[1];
    objects43[0] = note13;
    bool added17;
    added17 = cutCopyPasteBuilder17.ObjectsToCopy.Add(objects43);
    
    NXOpen.Point3d origin210 = new NXOpen.Point3d(756.72944181448497, 219.74495419724965, 0.0);
    NXOpen.Vector3d normal17 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane17;
    plane17 = workPart.Planes.CreatePlane(origin210, normal17, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder17.PlaneToRestrictMotion = plane17;
    
    cutCopyPasteBuilder17.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder17.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder17.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder17.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder17.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder17.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder17.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder17.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder17.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId278, "粘贴 对话框");
    
    cutCopyPasteBuilder17.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder17.Transform.SetMotionToTwoDimensions(plane17);
    
    cutCopyPasteBuilder17.InitPaste();
    
    cutCopyPasteBuilder17.CutCopyPasteLeader.IsLeaderSelection = false;
    
    // ----------------------------------------------
    //   菜单：编辑(E)->撤消
    // ----------------------------------------------
    cutCopyPasteBuilder17.Destroy();
    
    bool marksRecycled8;
    bool undoUnavailable8;
    theSession.UndoLastNVisibleMarks(1, out marksRecycled8, out undoUnavailable8);
    
    int nErrs213;
    nErrs213 = theSession.UpdateManager.DoUpdate(markId277);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->撤消
    // ----------------------------------------------
    bool marksRecycled9;
    bool undoUnavailable9;
    theSession.UndoLastNVisibleMarks(1, out marksRecycled9, out undoUnavailable9);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->复制(C)
    // ----------------------------------------------
    workPart.PmiManager.RestoreUnpastedObjects();
    
    // ----------------------------------------------
    //   菜单：编辑(E)->粘贴(P)
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId279;
    markId279 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder18;
    cutCopyPasteBuilder18 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder18.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder18.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation18 = new NXOpen.Point3d(756.72944181448497, 219.74495419724965, 0.0);
    cutCopyPasteBuilder18.SetDefaultToPoint(droplocation18);
    
    cutCopyPasteBuilder18.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects44 = new NXOpen.TaggedObject[1];
    objects44[0] = note13;
    bool added18;
    added18 = cutCopyPasteBuilder18.ObjectsToCopy.Add(objects44);
    
    NXOpen.Point3d origin211 = new NXOpen.Point3d(756.72944181448497, 219.74495419724965, 0.0);
    NXOpen.Vector3d normal18 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane18;
    plane18 = workPart.Planes.CreatePlane(origin211, normal18, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder18.PlaneToRestrictMotion = plane18;
    
    cutCopyPasteBuilder18.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder18.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder18.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder18.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder18.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder18.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder18.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder18.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder18.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId279, "粘贴 对话框");
    
    cutCopyPasteBuilder18.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder18.Transform.SetMotionToTwoDimensions(plane18);
    
    cutCopyPasteBuilder18.InitPaste();
    
    cutCopyPasteBuilder18.CutCopyPasteLeader.IsLeaderSelection = false;
    
    NXOpen.Point3d scaleAboutPoint775 = new NXOpen.Point3d(30.132597510718306, -12.399059262783528, 0.0);
    NXOpen.Point3d viewCenter775 = new NXOpen.Point3d(-30.132597510717634, 12.399059262783409, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint775, viewCenter775);
    
    NXOpen.Point3d scaleAboutPoint776 = new NXOpen.Point3d(38.386622426931723, -18.021888463348134, 0.0);
    NXOpen.Point3d viewCenter776 = new NXOpen.Point3d(-38.386622426931048, 18.021888463347999, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint776, viewCenter776);
    
    NXOpen.Point3d scaleAboutPoint777 = new NXOpen.Point3d(48.659098851040135, -24.329549425519936, 0.0);
    NXOpen.Point3d viewCenter777 = new NXOpen.Point3d(-48.659098851039452, 24.329549425519822, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint777, viewCenter777);
    
    NXOpen.Point3d scaleAboutPoint778 = new NXOpen.Point3d(61.387057578279737, -31.53830481085917, 0.0);
    NXOpen.Point3d viewCenter778 = new NXOpen.Point3d(-61.387057578279055, 31.538304810859049, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint778, viewCenter778);
    
    NXOpen.Point3d scaleAboutPoint779 = new NXOpen.Point3d(76.733821972849526, -39.422881013573914, 0.0);
    NXOpen.Point3d viewCenter779 = new NXOpen.Point3d(-76.733821972848872, 39.422881013573857, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint779, viewCenter779);
    
    NXOpen.Point3d coordinates11 = new NXOpen.Point3d(775.18230684491346, 424.52795439828265, 0.0);
    NXOpen.Point point18;
    point18 = workPart.Points.CreatePoint(coordinates11);
    
    NXOpen.Point3d point19 = new NXOpen.Point3d(775.18230684491346, 424.52795439828265, 0.0);
    cutCopyPasteBuilder18.CutCopyPasteLeader.Selection.SetValue(point18, workPart.Views.WorkView, point19);
    
    NXOpen.Session.UndoMarkId markId280;
    markId280 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "粘贴");
    
    NXOpen.Matrix3x3 rot8 = new NXOpen.Matrix3x3();
    rot8.Xx = 1.0;
    rot8.Xy = 0.0;
    rot8.Xz = 0.0;
    rot8.Yx = 0.0;
    rot8.Yy = 1.0;
    rot8.Yz = 0.0;
    rot8.Zx = 0.0;
    rot8.Zy = 0.0;
    rot8.Zz = 1.0;
    NXOpen.Vector3d trans8 = new NXOpen.Vector3d(18.452865030428484, 204.78300020103299, 0.0);
    cutCopyPasteBuilder18.CutCopyPasteLeader.SetMoveOnCommit(rot8, trans8);
    
    NXOpen.NXObject nXObject14;
    nXObject14 = cutCopyPasteBuilder18.Commit();
    
    theSession.DeleteUndoMark(markId280, null);
    
    theSession.SetUndoMarkName(markId279, "粘贴");
    
    cutCopyPasteBuilder18.Destroy();
    
    workPart.Points.DeletePoint(point18);
    
    NXOpen.Session.UndoMarkId markId281;
    markId281 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Start");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder19;
    cutCopyPasteBuilder19 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder19.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder19.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation19 = new NXOpen.Point3d(756.72944181448497, 219.74495419724965, 0.0);
    cutCopyPasteBuilder19.SetDefaultToPoint(droplocation19);
    
    cutCopyPasteBuilder19.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects45 = new NXOpen.TaggedObject[1];
    objects45[0] = note13;
    bool added19;
    added19 = cutCopyPasteBuilder19.ObjectsToCopy.Add(objects45);
    
    NXOpen.Point3d origin212 = new NXOpen.Point3d(756.72944181448497, 219.74495419724965, 0.0);
    NXOpen.Vector3d normal19 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane19;
    plane19 = workPart.Planes.CreatePlane(origin212, normal19, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder19.PlaneToRestrictMotion = plane19;
    
    cutCopyPasteBuilder19.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder19.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder19.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder19.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder19.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder19.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder19.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder19.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder19.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId281, "粘贴 对话框");
    
    cutCopyPasteBuilder19.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder19.Transform.SetMotionToTwoDimensions(plane19);
    
    cutCopyPasteBuilder19.InitPaste();
    
    cutCopyPasteBuilder19.CutCopyPasteLeader.IsLeaderSelection = false;
    
    // ----------------------------------------------
    //   对话开始 粘贴
    // ----------------------------------------------
    cutCopyPasteBuilder19.Destroy();
    
    theSession.UndoToMark(markId281, null);
    
    theSession.DeleteUndoMark(markId281, null);
    
    int nErrs214;
    nErrs214 = theSession.UpdateManager.DoUpdate(markId279);
    
    // ----------------------------------------------
    //   菜单：工具(T)->操作记录(J)->暂停录制(A)
    // ----------------------------------------------
    NXOpen.Point3d scaleAboutPoint780 = new NXOpen.Point3d(195.79444253393328, 26.839238190044675, 0.0);
    NXOpen.Point3d viewCenter780 = new NXOpen.Point3d(-195.79444253393248, -26.83923819004475, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint780, viewCenter780);
    
    NXOpen.Point3d scaleAboutPoint781 = new NXOpen.Point3d(249.69291266967863, 33.549047737555782, 0.0);
    NXOpen.Point3d viewCenter781 = new NXOpen.Point3d(-249.69291266967801, -33.549047737555966, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint781, viewCenter781);
    
    NXOpen.Point3d scaleAboutPoint782 = new NXOpen.Point3d(314.86606278279942, 41.936309671944727, 0.0);
    NXOpen.Point3d viewCenter782 = new NXOpen.Point3d(-314.86606278279885, -41.936309671944954, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint782, viewCenter782);
    
    NXOpen.Point3d scaleAboutPoint783 = new NXOpen.Point3d(-365.22400841345376, -137.49609728506525, 0.0);
    NXOpen.Point3d viewCenter783 = new NXOpen.Point3d(365.2240084134545, 137.49609728506502, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint783, viewCenter783);
    
    NXOpen.Point3d scaleAboutPoint784 = new NXOpen.Point3d(-288.74180429863645, -109.99687782805226, 0.0);
    NXOpen.Point3d viewCenter784 = new NXOpen.Point3d(288.74180429863702, 109.99687782805192, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint784, viewCenter784);
    
    NXOpen.Point3d scaleAboutPoint785 = new NXOpen.Point3d(-215.04389615384159, -89.097471040722411, 0.0);
    NXOpen.Point3d viewCenter785 = new NXOpen.Point3d(215.04389615384213, 89.097471040721999, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint785, viewCenter785);
    
    NXOpen.Point3d scaleAboutPoint786 = new NXOpen.Point3d(81.837677104071062, 11.439675294117183, 0.0);
    NXOpen.Point3d viewCenter786 = new NXOpen.Point3d(-81.83767710407048, -11.439675294117587, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint786, viewCenter786);
    
    NXOpen.Point3d scaleAboutPoint787 = new NXOpen.Point3d(64.41417165610757, 9.1517402352937154, 0.0);
    NXOpen.Point3d viewCenter787 = new NXOpen.Point3d(-64.41417165610703, -9.1517402352941559, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint787, viewCenter787);
    
    NXOpen.Point3d scaleAboutPoint788 = new NXOpen.Point3d(33.227856854298309, -2.5343280651585665, 0.0);
    NXOpen.Point3d viewCenter788 = new NXOpen.Point3d(-33.227856854297698, 2.5343280651580971, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint788, viewCenter788);
    
    NXOpen.Point3d scaleAboutPoint789 = new NXOpen.Point3d(41.534821067872727, -3.167910081448178, 0.0);
    NXOpen.Point3d viewCenter789 = new NXOpen.Point3d(-41.534821067872201, 3.16791008144765, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint789, viewCenter789);
    
    NXOpen.Point3d scaleAboutPoint790 = new NXOpen.Point3d(51.918526334840799, -3.9598876018101121, 0.0);
    NXOpen.Point3d viewCenter790 = new NXOpen.Point3d(-51.918526334840287, 3.959887601809672, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint790, viewCenter790);
    
    NXOpen.Point3d scaleAboutPoint791 = new NXOpen.Point3d(-182.59481719456616, 34.64901651583618, 0.0);
    NXOpen.Point3d viewCenter791 = new NXOpen.Point3d(182.59481719456664, -34.649016515836642, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint791, viewCenter791);
    
    NXOpen.Point3d scaleAboutPoint792 = new NXOpen.Point3d(-146.07585375565287, 27.719213212668883, 0.0);
    NXOpen.Point3d viewCenter792 = new NXOpen.Point3d(146.07585375565347, -27.719213212669359, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint792, viewCenter792);
    
    NXOpen.Point3d origin213 = new NXOpen.Point3d(334.77818235792074, 252.95894924501366, 0.0);
    workPart.Views.WorkView.SetOrigin(origin213);
    
    NXOpen.Point3d origin214 = new NXOpen.Point3d(334.77818235792074, 252.95894924501366, 0.0);
    workPart.Views.WorkView.SetOrigin(origin214);
    
    NXOpen.Point3d origin215 = new NXOpen.Point3d(598.41869913619087, 252.6069592359641, 0.0);
    workPart.Views.WorkView.SetOrigin(origin215);
    
    NXOpen.Point3d origin216 = new NXOpen.Point3d(598.41869913619087, 252.6069592359641, 0.0);
    workPart.Views.WorkView.SetOrigin(origin216);
    
    NXOpen.Point3d origin217 = new NXOpen.Point3d(676.56048114523139, 350.81217176085607, 0.0);
    workPart.Views.WorkView.SetOrigin(origin217);
    
    NXOpen.Point3d origin218 = new NXOpen.Point3d(676.56048114523139, 350.81217176085607, 0.0);
    workPart.Views.WorkView.SetOrigin(origin218);
    
    NXOpen.Point3d origin219 = new NXOpen.Point3d(676.91247115428087, 236.76740882874395, 0.0);
    workPart.Views.WorkView.SetOrigin(origin219);
    
    NXOpen.Point3d origin220 = new NXOpen.Point3d(676.91247115428087, 236.76740882874395, 0.0);
    workPart.Views.WorkView.SetOrigin(origin220);
    
    NXOpen.Point3d scaleAboutPoint793 = new NXOpen.Point3d(152.05968390949948, -83.773622153844727, 0.0);
    NXOpen.Point3d viewCenter793 = new NXOpen.Point3d(-152.05968390949894, 83.773622153844244, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint793, viewCenter793);
    
    NXOpen.Point3d scaleAboutPoint794 = new NXOpen.Point3d(117.98705103348206, -68.708449766514704, 0.0);
    NXOpen.Point3d viewCenter794 = new NXOpen.Point3d(-117.98705103348149, 68.708449766514235, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint794, viewCenter794);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->复制(C)
    // ----------------------------------------------
    workPart.PmiManager.RestoreUnpastedObjects();
    
    // ----------------------------------------------
    //   菜单：编辑(E)->粘贴(P)
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId282;
    markId282 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder20;
    cutCopyPasteBuilder20 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder20.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder20.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation20 = new NXOpen.Point3d(730.92181814287721, 206.27099444467217, 0.0);
    cutCopyPasteBuilder20.SetDefaultToPoint(droplocation20);
    
    cutCopyPasteBuilder20.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects46 = new NXOpen.TaggedObject[1];
    NXOpen.Annotations.Note note66 = ((NXOpen.Annotations.Note)nXObject3);
    objects46[0] = note66;
    bool added20;
    added20 = cutCopyPasteBuilder20.ObjectsToCopy.Add(objects46);
    
    NXOpen.Point3d origin221 = new NXOpen.Point3d(730.92181814287721, 206.27099444467217, 0.0);
    NXOpen.Vector3d normal20 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane20;
    plane20 = workPart.Planes.CreatePlane(origin221, normal20, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder20.PlaneToRestrictMotion = plane20;
    
    cutCopyPasteBuilder20.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder20.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder20.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder20.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder20.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder20.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder20.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder20.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder20.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId282, "粘贴 对话框");
    
    cutCopyPasteBuilder20.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder20.Transform.SetMotionToTwoDimensions(plane20);
    
    cutCopyPasteBuilder20.InitPaste();
    
    cutCopyPasteBuilder20.CutCopyPasteLeader.IsLeaderSelection = false;
    
    NXOpen.Point3d origin222 = new NXOpen.Point3d(731.59763896025254, 302.46282411779799, 0.0);
    workPart.Views.WorkView.SetOrigin(origin222);
    
    NXOpen.Point3d origin223 = new NXOpen.Point3d(731.59763896025254, 302.46282411779799, 0.0);
    workPart.Views.WorkView.SetOrigin(origin223);
    
    NXOpen.Point3d origin224 = new NXOpen.Point3d(731.82291256604412, 359.23177277734993, 0.0);
    workPart.Views.WorkView.SetOrigin(origin224);
    
    NXOpen.Point3d origin225 = new NXOpen.Point3d(731.82291256604412, 359.23177277734993, 0.0);
    workPart.Views.WorkView.SetOrigin(origin225);
    
    NXOpen.Point3d scaleAboutPoint795 = new NXOpen.Point3d(68.70844976651469, 38.296512984614402, 0.0);
    NXOpen.Point3d viewCenter795 = new NXOpen.Point3d(-68.708449766514235, -38.296512984614836, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint795, viewCenter795);
    
    NXOpen.Point3d scaleAboutPoint796 = new NXOpen.Point3d(54.96675981321178, 30.997648156958409, 0.0);
    NXOpen.Point3d viewCenter796 = new NXOpen.Point3d(-54.966759813211326, -30.99764815695886, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint796, viewCenter796);
    
    NXOpen.Point3d scaleAboutPoint797 = new NXOpen.Point3d(43.973407850569458, 25.374818956393813, 0.0);
    NXOpen.Point3d viewCenter797 = new NXOpen.Point3d(-43.973407850569018, -25.374818956394272, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint797, viewCenter797);
    
    NXOpen.Point3d coordinates12 = new NXOpen.Point3d(802.03078345270899, 403.88640801183544, 0.0);
    NXOpen.Point point20;
    point20 = workPart.Points.CreatePoint(coordinates12);
    
    NXOpen.Point3d point21 = new NXOpen.Point3d(802.03078345270899, 403.88640801183544, 0.0);
    cutCopyPasteBuilder20.CutCopyPasteLeader.Selection.SetValue(point20, workPart.Views.WorkView, point21);
    
    NXOpen.Session.UndoMarkId markId283;
    markId283 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "粘贴");
    
    NXOpen.Matrix3x3 rot9 = new NXOpen.Matrix3x3();
    rot9.Xx = 1.0;
    rot9.Xy = 0.0;
    rot9.Xz = 0.0;
    rot9.Yx = 0.0;
    rot9.Yy = 1.0;
    rot9.Yz = 0.0;
    rot9.Zx = 0.0;
    rot9.Zy = 0.0;
    rot9.Zz = 1.0;
    NXOpen.Vector3d trans9 = new NXOpen.Vector3d(71.108965309831774, 197.61541356716327, 0.0);
    cutCopyPasteBuilder20.CutCopyPasteLeader.SetMoveOnCommit(rot9, trans9);
    
    NXOpen.NXObject nXObject15;
    nXObject15 = cutCopyPasteBuilder20.Commit();
    
    theSession.DeleteUndoMark(markId283, null);
    
    theSession.SetUndoMarkName(markId282, "粘贴");
    
    cutCopyPasteBuilder20.Destroy();
    
    workPart.Points.DeletePoint(point20);
    
    NXOpen.Session.UndoMarkId markId284;
    markId284 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Start");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder21;
    cutCopyPasteBuilder21 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder21.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder21.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation21 = new NXOpen.Point3d(730.92181814287721, 206.27099444467217, 0.0);
    cutCopyPasteBuilder21.SetDefaultToPoint(droplocation21);
    
    cutCopyPasteBuilder21.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects47 = new NXOpen.TaggedObject[1];
    objects47[0] = note66;
    bool added21;
    added21 = cutCopyPasteBuilder21.ObjectsToCopy.Add(objects47);
    
    NXOpen.Point3d origin226 = new NXOpen.Point3d(730.92181814287721, 206.27099444467217, 0.0);
    NXOpen.Vector3d normal21 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane21;
    plane21 = workPart.Planes.CreatePlane(origin226, normal21, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder21.PlaneToRestrictMotion = plane21;
    
    cutCopyPasteBuilder21.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder21.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder21.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder21.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder21.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder21.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder21.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder21.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder21.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId284, "粘贴 对话框");
    
    cutCopyPasteBuilder21.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder21.Transform.SetMotionToTwoDimensions(plane21);
    
    cutCopyPasteBuilder21.InitPaste();
    
    cutCopyPasteBuilder21.CutCopyPasteLeader.IsLeaderSelection = false;
    
    // ----------------------------------------------
    //   对话开始 粘贴
    // ----------------------------------------------
    NXOpen.Point3d scaleAboutPoint798 = new NXOpen.Point3d(55.939941790232552, 15.340231460001631, 0.0);
    NXOpen.Point3d viewCenter798 = new NXOpen.Point3d(-55.939941790232091, -15.340231460002082, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint798, viewCenter798);
    
    NXOpen.Point3d scaleAboutPoint799 = new NXOpen.Point3d(69.924927237790627, 19.175289325002087, 0.0);
    NXOpen.Point3d viewCenter799 = new NXOpen.Point3d(-69.924927237790172, -19.175289325002542, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint799, viewCenter799);
    
    NXOpen.Point3d scaleAboutPoint800 = new NXOpen.Point3d(86.865502393337806, 21.986703925284385, 0.0);
    NXOpen.Point3d viewCenter800 = new NXOpen.Point3d(-86.865502393337351, -21.986703925284836, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint800, viewCenter800);
    
    NXOpen.Point3d scaleAboutPoint801 = new NXOpen.Point3d(108.58187799167223, 27.032832695021852, 0.0);
    NXOpen.Point3d viewCenter801 = new NXOpen.Point3d(-108.58187799167177, -27.032832695022304, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint801, viewCenter801);
    
    cutCopyPasteBuilder21.Destroy();
    
    theSession.UndoToMark(markId284, null);
    
    theSession.DeleteUndoMark(markId284, null);
    
    int nErrs215;
    nErrs215 = theSession.UpdateManager.DoUpdate(markId282);
    
    NXOpen.Point3d scaleAboutPoint802 = new NXOpen.Point3d(52.249059032938874, 8.6505064624068364, 0.0);
    NXOpen.Point3d viewCenter802 = new NXOpen.Point3d(-52.249059032938412, -8.6505064624072876, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint802, viewCenter802);
    
    NXOpen.Point3d scaleAboutPoint803 = new NXOpen.Point3d(65.167148683466763, 11.389833508835734, 0.0);
    NXOpen.Point3d viewCenter803 = new NXOpen.Point3d(-65.167148683466294, -11.38983350883619, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint803, viewCenter803);
    
    NXOpen.Point3d scaleAboutPoint804 = new NXOpen.Point3d(81.458935854333404, 14.417510770678209, 0.0);
    NXOpen.Point3d viewCenter804 = new NXOpen.Point3d(-81.45893585433295, -14.417510770678659, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint804, viewCenter804);
    
    NXOpen.Point3d scaleAboutPoint805 = new NXOpen.Point3d(101.82366981791667, 18.697709280723362, 0.0);
    NXOpen.Point3d viewCenter805 = new NXOpen.Point3d(-101.82366981791621, -18.697709280723814, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint805, viewCenter805);
    
    NXOpen.Point3d scaleAboutPoint806 = new NXOpen.Point3d(126.71640325791617, 26.188056673302377, 0.0);
    NXOpen.Point3d viewCenter806 = new NXOpen.Point3d(-126.7164032579157, -26.188056673302846, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint806, viewCenter806);
    
    NXOpen.Point3d scaleAboutPoint807 = new NXOpen.Point3d(124.9564532126674, -84.125612162894399, 0.0);
    NXOpen.Point3d viewCenter807 = new NXOpen.Point3d(-124.95645321266682, 84.125612162893987, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint807, viewCenter807);
    
    NXOpen.Point3d scaleAboutPoint808 = new NXOpen.Point3d(156.19556651583417, -105.15701520361792, 0.0);
    NXOpen.Point3d viewCenter808 = new NXOpen.Point3d(-156.19556651583363, 105.15701520361755, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint808, viewCenter808);
    
    NXOpen.Point3d scaleAboutPoint809 = new NXOpen.Point3d(194.14448936651189, -131.44626900452229, 0.0);
    NXOpen.Point3d viewCenter809 = new NXOpen.Point3d(-194.14448936651144, 131.44626900452187, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint809, viewCenter809);
    
    NXOpen.Point3d scaleAboutPoint810 = new NXOpen.Point3d(241.30565073528916, -161.55791430995143, 0.0);
    NXOpen.Point3d viewCenter810 = new NXOpen.Point3d(-241.30565073528894, 161.55791430995114, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint810, viewCenter810);
    
    NXOpen.Point3d origin227 = new NXOpen.Point3d(479.34829193288505, 314.76540115915878, 0.0);
    workPart.Views.WorkView.SetOrigin(origin227);
    
    NXOpen.Point3d origin228 = new NXOpen.Point3d(479.34829193288505, 314.76540115915878, 0.0);
    workPart.Views.WorkView.SetOrigin(origin228);
    
    NXOpen.Point3d scaleAboutPoint811 = new NXOpen.Point3d(331.70933470021947, -153.82375883766662, 0.0);
    NXOpen.Point3d viewCenter811 = new NXOpen.Point3d(-331.70933470021907, 153.82375883766633, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint811, viewCenter811);
    
    NXOpen.Point3d scaleAboutPoint812 = new NXOpen.Point3d(266.05494824660121, -123.74648755655871, 0.0);
    NXOpen.Point3d viewCenter812 = new NXOpen.Point3d(-266.05494824660065, 123.74648755655835, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint812, viewCenter812);
    
    NXOpen.Point3d scaleAboutPoint813 = new NXOpen.Point3d(213.94392737556154, -100.09715882352752, 0.0);
    NXOpen.Point3d viewCenter813 = new NXOpen.Point3d(-213.94392737556089, 100.09715882352715, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint813, viewCenter813);
    
    NXOpen.Point3d scaleAboutPoint814 = new NXOpen.Point3d(171.59512941176175, -80.077727058822092, 0.0);
    NXOpen.Point3d viewCenter814 = new NXOpen.Point3d(-171.59512941176078, 80.077727058821736, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint814, viewCenter814);
    
    NXOpen.Point3d scaleAboutPoint815 = new NXOpen.Point3d(137.62809353845921, -64.414171656107442, 0.0);
    NXOpen.Point3d viewCenter815 = new NXOpen.Point3d(-137.62809353845824, 64.414171656107129, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint815, viewCenter815);
    
    NXOpen.Point3d scaleAboutPoint816 = new NXOpen.Point3d(110.10247483076733, -51.531337324885975, 0.0);
    NXOpen.Point3d viewCenter816 = new NXOpen.Point3d(-110.10247483076654, 51.531337324885641, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint816, viewCenter816);
    
    NXOpen.Point3d scaleAboutPoint817 = new NXOpen.Point3d(88.081979864614055, -41.450343465700684, 0.0);
    NXOpen.Point3d viewCenter817 = new NXOpen.Point3d(-88.08197986461316, 41.450343465700342, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint817, viewCenter817);
    
    NXOpen.Point3d scaleAboutPoint818 = new NXOpen.Point3d(70.6458027763248, -33.340493657194052, 0.0);
    NXOpen.Point3d viewCenter818 = new NXOpen.Point3d(-70.645802776323904, 33.340493657193726, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint818, viewCenter818);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->复制(C)
    // ----------------------------------------------
    workPart.PmiManager.RestoreUnpastedObjects();
    
    // ----------------------------------------------
    //   菜单：编辑(E)->粘贴(P)
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId285;
    markId285 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder22;
    cutCopyPasteBuilder22 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder22.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder22.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation22 = new NXOpen.Point3d(757.30063008174648, 185.06910548306695, 0.0);
    cutCopyPasteBuilder22.SetDefaultToPoint(droplocation22);
    
    cutCopyPasteBuilder22.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects48 = new NXOpen.TaggedObject[1];
    objects48[0] = note16;
    bool added22;
    added22 = cutCopyPasteBuilder22.ObjectsToCopy.Add(objects48);
    
    NXOpen.Point3d origin229 = new NXOpen.Point3d(757.30063008174648, 185.06910548306695, 0.0);
    NXOpen.Vector3d normal22 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane22;
    plane22 = workPart.Planes.CreatePlane(origin229, normal22, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder22.PlaneToRestrictMotion = plane22;
    
    cutCopyPasteBuilder22.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder22.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder22.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder22.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder22.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder22.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder22.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder22.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder22.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId285, "粘贴 对话框");
    
    cutCopyPasteBuilder22.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder22.Transform.SetMotionToTwoDimensions(plane22);
    
    cutCopyPasteBuilder22.InitPaste();
    
    cutCopyPasteBuilder22.CutCopyPasteLeader.IsLeaderSelection = false;
    
    NXOpen.Point3d scaleAboutPoint819 = new NXOpen.Point3d(6.3437047390989738, -13.984985447558266, 0.0);
    NXOpen.Point3d viewCenter819 = new NXOpen.Point3d(-6.3437047390980599, 13.984985447557918, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint819, viewCenter819);
    
    NXOpen.Point3d scaleAboutPoint820 = new NXOpen.Point3d(13.155978578244532, -20.725171732850423, 0.0);
    NXOpen.Point3d viewCenter820 = new NXOpen.Point3d(-13.15597857824363, 20.725171732850093, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint820, viewCenter820);
    
    NXOpen.Point3d scaleAboutPoint821 = new NXOpen.Point3d(20.950445338642567, -29.28556875294073, 0.0);
    NXOpen.Point3d viewCenter821 = new NXOpen.Point3d(-20.950445338641668, 29.285568752940392, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint821, viewCenter821);
    
    NXOpen.Point3d scaleAboutPoint822 = new NXOpen.Point3d(29.003976745701255, -38.014920977374956, 0.0);
    NXOpen.Point3d viewCenter822 = new NXOpen.Point3d(-29.003976745700314, 38.014920977374558, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint822, viewCenter822);
    
    NXOpen.Point3d scaleAboutPoint823 = new NXOpen.Point3d(45.406711167420298, -53.50248137556472, 0.0);
    NXOpen.Point3d viewCenter823 = new NXOpen.Point3d(-45.406711167419473, 53.50248137556428, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint823, viewCenter823);
    
    NXOpen.Point3d scaleAboutPoint824 = new NXOpen.Point3d(58.518339004524009, -67.758076742080277, 0.0);
    NXOpen.Point3d viewCenter824 = new NXOpen.Point3d(-58.518339004523348, 67.758076742079723, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint824, viewCenter824);
    
    NXOpen.Point3d scaleAboutPoint825 = new NXOpen.Point3d(83.597627149319734, -89.097471040722397, 0.0);
    NXOpen.Point3d viewCenter825 = new NXOpen.Point3d(-83.59762714931918, 89.0974710407218, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint825, viewCenter825);
    
    NXOpen.Point3d scaleAboutPoint826 = new NXOpen.Point3d(109.99687782805229, -113.43428026017881, 0.0);
    NXOpen.Point3d viewCenter826 = new NXOpen.Point3d(-109.99687782805161, 113.43428026017824, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint826, viewCenter826);
    
    NXOpen.Point3d scaleAboutPoint827 = new NXOpen.Point3d(61.873243778279537, 130.62129242081139, 0.0);
    NXOpen.Point3d viewCenter827 = new NXOpen.Point3d(-61.873243778278891, -130.6212924208119, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint827, viewCenter827);
    
    NXOpen.Point3d scaleAboutPoint828 = new NXOpen.Point3d(48.123634049773059, 105.87199490949966, 0.0);
    NXOpen.Point3d viewCenter828 = new NXOpen.Point3d(-48.12363404977237, -105.87199490950024, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint828, viewCenter828);
    
    NXOpen.Point3d scaleAboutPoint829 = new NXOpen.Point3d(37.948922850678237, 84.697595927599721, 0.0);
    NXOpen.Point3d viewCenter829 = new NXOpen.Point3d(-37.948922850677597, -84.697595927600233, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint829, viewCenter829);
    
    NXOpen.Point3d scaleAboutPoint830 = new NXOpen.Point3d(30.359138280542783, 67.758076742079723, 0.0);
    NXOpen.Point3d viewCenter830 = new NXOpen.Point3d(-30.359138280542084, -67.758076742080235, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint830, viewCenter830);
    
    NXOpen.Point3d scaleAboutPoint831 = new NXOpen.Point3d(21.823380561085862, 52.446511348414873, 0.0);
    NXOpen.Point3d viewCenter831 = new NXOpen.Point3d(-21.823380561085216, -52.446511348415399, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint831, viewCenter831);
    
    NXOpen.Point3d scaleAboutPoint832 = new NXOpen.Point3d(12.108456311312295, 35.480592912216181, 0.0);
    NXOpen.Point3d viewCenter832 = new NXOpen.Point3d(-12.108456311311615, -35.48059291221665, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint832, viewCenter832);
    
    NXOpen.Point3d scaleAboutPoint833 = new NXOpen.Point3d(-21.851539761809114, -11.714227501176445, 0.0);
    NXOpen.Point3d viewCenter833 = new NXOpen.Point3d(21.851539761809811, 11.714227501175994, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint833, viewCenter833);
    
    NXOpen.Point3d scaleAboutPoint834 = new NXOpen.Point3d(-17.481231809447252, -9.5516008855746808, 0.0);
    NXOpen.Point3d viewCenter834 = new NXOpen.Point3d(17.481231809447912, 9.5516008855742296, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint834, viewCenter834);
    
    NXOpen.Point3d scaleAboutPoint835 = new NXOpen.Point3d(-13.984985447557722, -7.6412807084597896, 0.0);
    NXOpen.Point3d viewCenter835 = new NXOpen.Point3d(13.984985447558396, 7.641280708459333, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint835, viewCenter835);
    
    NXOpen.Point3d scaleAboutPoint836 = new NXOpen.Point3d(-11.187988358046107, -6.1130245667678684, 0.0);
    NXOpen.Point3d viewCenter836 = new NXOpen.Point3d(11.18798835804678, 6.1130245667674163, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint836, viewCenter836);
    
    NXOpen.Point3d coordinates13 = new NXOpen.Point3d(692.42753103591997, 376.38469206568482, 0.0);
    NXOpen.Point point22;
    point22 = workPart.Points.CreatePoint(coordinates13);
    
    NXOpen.Point3d point23 = new NXOpen.Point3d(692.42753103591997, 376.38469206568482, 0.0);
    cutCopyPasteBuilder22.CutCopyPasteLeader.Selection.SetValue(point22, workPart.Views.WorkView, point23);
    
    NXOpen.Session.UndoMarkId markId286;
    markId286 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "粘贴");
    
    NXOpen.Matrix3x3 rot10 = new NXOpen.Matrix3x3();
    rot10.Xx = 1.0;
    rot10.Xy = 0.0;
    rot10.Xz = 0.0;
    rot10.Yx = 0.0;
    rot10.Yy = 1.0;
    rot10.Yz = 0.0;
    rot10.Zx = 0.0;
    rot10.Zy = 0.0;
    rot10.Zz = 1.0;
    NXOpen.Vector3d trans10 = new NXOpen.Vector3d(-64.873099045826507, 191.31558658261787, 0.0);
    cutCopyPasteBuilder22.CutCopyPasteLeader.SetMoveOnCommit(rot10, trans10);
    
    NXOpen.NXObject nXObject16;
    nXObject16 = cutCopyPasteBuilder22.Commit();
    
    theSession.DeleteUndoMark(markId286, null);
    
    theSession.SetUndoMarkName(markId285, "粘贴");
    
    cutCopyPasteBuilder22.Destroy();
    
    workPart.Points.DeletePoint(point22);
    
    NXOpen.Session.UndoMarkId markId287;
    markId287 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Start");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder23;
    cutCopyPasteBuilder23 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder23.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder23.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation23 = new NXOpen.Point3d(757.30063008174648, 185.06910548306695, 0.0);
    cutCopyPasteBuilder23.SetDefaultToPoint(droplocation23);
    
    cutCopyPasteBuilder23.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects49 = new NXOpen.TaggedObject[1];
    objects49[0] = note16;
    bool added23;
    added23 = cutCopyPasteBuilder23.ObjectsToCopy.Add(objects49);
    
    NXOpen.Point3d origin230 = new NXOpen.Point3d(757.30063008174648, 185.06910548306695, 0.0);
    NXOpen.Vector3d normal23 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane23;
    plane23 = workPart.Planes.CreatePlane(origin230, normal23, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder23.PlaneToRestrictMotion = plane23;
    
    cutCopyPasteBuilder23.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder23.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder23.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder23.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder23.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder23.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder23.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder23.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder23.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId287, "粘贴 对话框");
    
    cutCopyPasteBuilder23.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder23.Transform.SetMotionToTwoDimensions(plane23);
    
    cutCopyPasteBuilder23.InitPaste();
    
    cutCopyPasteBuilder23.CutCopyPasteLeader.IsLeaderSelection = false;
    
    // ----------------------------------------------
    //   对话开始 粘贴
    // ----------------------------------------------
    NXOpen.Point3d scaleAboutPoint837 = new NXOpen.Point3d(4.0599710330233902, 3.6908827572934433, 0.0);
    NXOpen.Point3d viewCenter837 = new NXOpen.Point3d(-4.0599710330227055, -3.6908827572939051, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint837, viewCenter837);
    
    NXOpen.Point3d scaleAboutPoint838 = new NXOpen.Point3d(4.9596237051137075, 4.6136034466168727, 0.0);
    NXOpen.Point3d viewCenter838 = new NXOpen.Point3d(-4.9596237051130343, -4.6136034466173248, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint838, viewCenter838);
    
    NXOpen.Point3d scaleAboutPoint839 = new NXOpen.Point3d(17.733538247934792, 8.6505064624068204, 0.0);
    NXOpen.Point3d viewCenter839 = new NXOpen.Point3d(-17.733538247934117, -8.6505064624072769, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint839, viewCenter839);
    
    NXOpen.Point3d scaleAboutPoint840 = new NXOpen.Point3d(22.166922809918404, 10.81313307800858, 0.0);
    NXOpen.Point3d viewCenter840 = new NXOpen.Point3d(-22.166922809917729, -10.813133078009031, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint840, viewCenter840);
    
    NXOpen.Point3d scaleAboutPoint841 = new NXOpen.Point3d(27.708653512397913, 13.516416347510782, 0.0);
    NXOpen.Point3d viewCenter841 = new NXOpen.Point3d(-27.708653512397234, -13.516416347511232, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint841, viewCenter841);
    
    NXOpen.Point3d scaleAboutPoint842 = new NXOpen.Point3d(34.63581689049731, 16.895520434388544, 0.0);
    NXOpen.Point3d viewCenter842 = new NXOpen.Point3d(-34.635816890496628, -16.895520434388988, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint842, viewCenter842);
    
    NXOpen.Point3d scaleAboutPoint843 = new NXOpen.Point3d(43.294771113121541, 21.119400542985705, 0.0);
    NXOpen.Point3d viewCenter843 = new NXOpen.Point3d(-43.294771113120838, -21.119400542986174, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint843, viewCenter843);
    
    NXOpen.Point3d scaleAboutPoint844 = new NXOpen.Point3d(54.118463891401767, 26.399250678732127, 0.0);
    NXOpen.Point3d viewCenter844 = new NXOpen.Point3d(-54.118463891401113, -26.399250678732749, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint844, viewCenter844);
    
    NXOpen.Point3d scaleAboutPoint845 = new NXOpen.Point3d(83.047642760179428, -169.39519185520004, 0.0);
    NXOpen.Point3d viewCenter845 = new NXOpen.Point3d(-83.047642760178789, 169.39519185519939, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint845, viewCenter845);
    
    NXOpen.Point3d scaleAboutPoint846 = new NXOpen.Point3d(66.878101719455785, -135.95614099547231, 0.0);
    NXOpen.Point3d viewCenter846 = new NXOpen.Point3d(-66.878101719455259, 135.95614099547166, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint846, viewCenter846);
    
    NXOpen.Point3d scaleAboutPoint847 = new NXOpen.Point3d(53.50248137556467, -108.76491279637789, 0.0);
    NXOpen.Point3d viewCenter847 = new NXOpen.Point3d(-53.502481375564024, 108.76491279637723, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint847, viewCenter847);
    
    NXOpen.Point3d scaleAboutPoint848 = new NXOpen.Point3d(42.80198510045183, -87.011930237102376, 0.0);
    NXOpen.Point3d viewCenter848 = new NXOpen.Point3d(-42.801985100451176, 87.011930237101723, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint848, viewCenter848);
    
    NXOpen.Point3d scaleAboutPoint849 = new NXOpen.Point3d(34.241588080361566, -69.609544189681984, 0.0);
    NXOpen.Point3d viewCenter849 = new NXOpen.Point3d(-34.24158808036087, 69.60954418968133, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint849, viewCenter849);
    
    NXOpen.Point3d scaleAboutPoint850 = new NXOpen.Point3d(83.441343585301581, -1.2615321924346876, 0.0);
    NXOpen.Point3d viewCenter850 = new NXOpen.Point3d(-83.441343585300899, 1.2615321924340266, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint850, viewCenter850);
    
    NXOpen.Point3d scaleAboutPoint851 = new NXOpen.Point3d(104.97750029900249, -0.67582081737587862, 0.0);
    NXOpen.Point3d viewCenter851 = new NXOpen.Point3d(-104.97750029900178, 0.67582081737525879, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint851, viewCenter851);
    
    NXOpen.Point3d scaleAboutPoint852 = new NXOpen.Point3d(131.78505938823258, -3.0522060064733671e-13, 0.0);
    NXOpen.Point3d viewCenter852 = new NXOpen.Point3d(-131.78505938823193, -3.2869910838943954e-13, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint852, viewCenter852);
    
    NXOpen.Point3d scaleAboutPoint853 = new NXOpen.Point3d(-10.207710262442767, -19.711440506787245, 0.0);
    NXOpen.Point3d viewCenter853 = new NXOpen.Point3d(10.207710262443589, 19.711440506786541, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint853, viewCenter853);
    
    NXOpen.Point3d scaleAboutPoint854 = new NXOpen.Point3d(-5.9134321520356057, -16.613928427149297, 0.0);
    NXOpen.Point3d viewCenter854 = new NXOpen.Point3d(5.9134321520364983, 16.613928427148618, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint854, viewCenter854);
    
    NXOpen.Point3d scaleAboutPoint855 = new NXOpen.Point3d(-4.0549249042528492, -13.516416347511338, 0.0);
    NXOpen.Point3d viewCenter855 = new NXOpen.Point3d(4.0549249042536948, 13.516416347510681, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint855, viewCenter855);
    
    NXOpen.Point3d scaleAboutPoint856 = new NXOpen.Point3d(-2.3428455002348016, -11.173570847276084, 0.0);
    NXOpen.Point3d viewCenter856 = new NXOpen.Point3d(2.3428455002356579, 11.173570847275453, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint856, viewCenter856);
    
    NXOpen.Point3d scaleAboutPoint857 = new NXOpen.Point3d(-0.86505064624022321, -9.3713820009412743, 0.0);
    NXOpen.Point3d viewCenter857 = new NXOpen.Point3d(0.8650506462411488, 9.371382000940649, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint857, viewCenter857);
    
    NXOpen.Point3d coordinates14 = new NXOpen.Point3d(640.48277158968483, 201.85040102363709, 0.0);
    NXOpen.Point point24;
    point24 = workPart.Points.CreatePoint(coordinates14);
    
    NXOpen.Point3d point25 = new NXOpen.Point3d(640.48277158968483, 201.85040102363709, 0.0);
    cutCopyPasteBuilder23.CutCopyPasteLeader.Selection.SetValue(point24, workPart.Views.WorkView, point25);
    
    NXOpen.Session.UndoMarkId markId288;
    markId288 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "粘贴");
    
    NXOpen.Matrix3x3 rot11 = new NXOpen.Matrix3x3();
    rot11.Xx = 1.0;
    rot11.Xy = 0.0;
    rot11.Xz = 0.0;
    rot11.Yx = 0.0;
    rot11.Yy = 1.0;
    rot11.Yz = 0.0;
    rot11.Zx = 0.0;
    rot11.Zy = 0.0;
    rot11.Zz = 1.0;
    NXOpen.Vector3d trans11 = new NXOpen.Vector3d(-116.81785849206165, 16.781295540570142, 0.0);
    cutCopyPasteBuilder23.CutCopyPasteLeader.SetMoveOnCommit(rot11, trans11);
    
    NXOpen.NXObject nXObject17;
    nXObject17 = cutCopyPasteBuilder23.Commit();
    
    theSession.DeleteUndoMark(markId288, null);
    
    theSession.SetUndoMarkName(markId287, "粘贴");
    
    cutCopyPasteBuilder23.Destroy();
    
    workPart.Points.DeletePoint(point24);
    
    NXOpen.Session.UndoMarkId markId289;
    markId289 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Start");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder24;
    cutCopyPasteBuilder24 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder24.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder24.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation24 = new NXOpen.Point3d(757.30063008174648, 185.06910548306695, 0.0);
    cutCopyPasteBuilder24.SetDefaultToPoint(droplocation24);
    
    cutCopyPasteBuilder24.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects50 = new NXOpen.TaggedObject[1];
    objects50[0] = note16;
    bool added24;
    added24 = cutCopyPasteBuilder24.ObjectsToCopy.Add(objects50);
    
    NXOpen.Point3d origin231 = new NXOpen.Point3d(757.30063008174648, 185.06910548306695, 0.0);
    NXOpen.Vector3d normal24 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane24;
    plane24 = workPart.Planes.CreatePlane(origin231, normal24, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder24.PlaneToRestrictMotion = plane24;
    
    cutCopyPasteBuilder24.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder24.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder24.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder24.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder24.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder24.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder24.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder24.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder24.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId289, "粘贴 对话框");
    
    cutCopyPasteBuilder24.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder24.Transform.SetMotionToTwoDimensions(plane24);
    
    cutCopyPasteBuilder24.InitPaste();
    
    cutCopyPasteBuilder24.CutCopyPasteLeader.IsLeaderSelection = false;
    
    // ----------------------------------------------
    //   对话开始 粘贴
    // ----------------------------------------------
    cutCopyPasteBuilder24.Destroy();
    
    theSession.UndoToMark(markId289, null);
    
    theSession.DeleteUndoMark(markId289, null);
    
    int nErrs216;
    nErrs216 = theSession.UpdateManager.DoUpdate(markId287);
    
    NXOpen.Session.UndoMarkId markId290;
    markId290 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Annotations.Note note67 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 1 1"));
    NXOpen.Annotations.DraftingNoteBuilder draftingNoteBuilder7;
    draftingNoteBuilder7 = workPart.Annotations.CreateDraftingNoteBuilder(note67);
    
    draftingNoteBuilder7.Text.TextBlock.CustomSymbolScale = 1.0;
    
    draftingNoteBuilder7.Origin.SetInferRelativeToGeometry(true);
    
    theSession.SetUndoMarkName(markId290, "注释 对话框");
    
    draftingNoteBuilder7.Origin.SetInferRelativeToGeometry(true);
    
    NXOpen.Annotations.LeaderData leaderData8;
    leaderData8 = workPart.Annotations.CreateLeaderData();
    
    leaderData8.StubSize = 3.5000000103999995;
    
    leaderData8.Arrowhead = NXOpen.Annotations.LeaderData.ArrowheadType.FilledArrow;
    
    leaderData8.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Center;
    
    draftingNoteBuilder7.Leader.Leaders.Append(leaderData8);
    
    leaderData8.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Legacy;
    
    leaderData8.StubSide = NXOpen.Annotations.LeaderSide.Inferred;
    
    double symbolscale7;
    symbolscale7 = draftingNoteBuilder7.Text.TextBlock.SymbolScale;
    
    double symbolaspectratio7;
    symbolaspectratio7 = draftingNoteBuilder7.Text.TextBlock.SymbolAspectRatio;
    
    draftingNoteBuilder7.Origin.SetInferRelativeToGeometry(true);
    
    draftingNoteBuilder7.Origin.SetInferRelativeToGeometry(true);
    
    // ----------------------------------------------
    //   对话开始 注释
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId291;
    markId291 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.DeleteUndoMark(markId291, null);
    
    NXOpen.Session.UndoMarkId markId292;
    markId292 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId292, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId292, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId290, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId293;
    markId293 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId293, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId293, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId290, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId294;
    markId294 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId294, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId294, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId290, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId295;
    markId295 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId295, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId295, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId290, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId296;
    markId296 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId296, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId296, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId290, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId297;
    markId297 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId297, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId297, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId290, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId298;
    markId298 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId298, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId298, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId290, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId299;
    markId299 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    string[] text5 = new string[1];
    text5[0] = "<F34><C1.0>截面图<C><F>";
    draftingNoteBuilder7.Text.TextBlock.SetText(text5);
    
    theSession.SetUndoMarkName(markId299, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId299, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId290, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId300;
    markId300 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    NXOpen.Session.UndoMarkId markId301;
    markId301 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    NXOpen.NXObject nXObject18;
    nXObject18 = draftingNoteBuilder7.Commit();
    
    theSession.DeleteUndoMark(markId301, null);
    
    theSession.SetUndoMarkName(markId290, "注释");
    
    draftingNoteBuilder7.Destroy();
    
    theSession.DeleteUndoMark(markId300, null);
    
    theSession.SetUndoMarkVisibility(markId290, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.DeleteUndoMark(markId299, null);
    
    theSession.DeleteUndoMark(markId298, null);
    
    theSession.DeleteUndoMark(markId297, null);
    
    theSession.DeleteUndoMark(markId296, null);
    
    theSession.DeleteUndoMark(markId295, null);
    
    theSession.DeleteUndoMark(markId294, null);
    
    theSession.DeleteUndoMark(markId293, null);
    
    theSession.DeleteUndoMark(markId292, null);
    
    NXOpen.Point3d scaleAboutPoint858 = new NXOpen.Point3d(18.80043404496509, 5.6516642221055911, 0.0);
    NXOpen.Point3d viewCenter858 = new NXOpen.Point3d(-18.800434044964188, -5.6516642221062643, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint858, viewCenter858);
    
    NXOpen.Point3d scaleAboutPoint859 = new NXOpen.Point3d(24.653943417860496, 7.4971056007524144, 0.0);
    NXOpen.Point3d viewCenter859 = new NXOpen.Point3d(-24.653943417859583, -7.497105600753124, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint859, viewCenter859);
    
    NXOpen.Point3d scaleAboutPoint860 = new NXOpen.Point3d(31.177867041592489, 9.5516008855740857, 0.0);
    NXOpen.Point3d viewCenter860 = new NXOpen.Point3d(-31.177867041591586, -9.5516008855747767, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint860, viewCenter860);
    
    NXOpen.Point3d scaleAboutPoint861 = new NXOpen.Point3d(39.1976074077823, 11.939501106967699, 0.0);
    NXOpen.Point3d viewCenter861 = new NXOpen.Point3d(-39.197607407781454, -11.939501106968393, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint861, viewCenter861);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->复制(C)
    // ----------------------------------------------
    workPart.PmiManager.RestoreUnpastedObjects();
    
    // ----------------------------------------------
    //   菜单：编辑(E)->粘贴(P)
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId302;
    markId302 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder25;
    cutCopyPasteBuilder25 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder25.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder25.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation25 = new NXOpen.Point3d(585.84310905208338, 217.06583090602959, 0.0);
    cutCopyPasteBuilder25.SetDefaultToPoint(droplocation25);
    
    cutCopyPasteBuilder25.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects51 = new NXOpen.TaggedObject[1];
    NXOpen.Annotations.Note note68 = ((NXOpen.Annotations.Note)nXObject18);
    objects51[0] = note68;
    bool added25;
    added25 = cutCopyPasteBuilder25.ObjectsToCopy.Add(objects51);
    
    NXOpen.Point3d origin232 = new NXOpen.Point3d(585.84310905208338, 217.06583090602959, 0.0);
    NXOpen.Vector3d normal25 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane25;
    plane25 = workPart.Planes.CreatePlane(origin232, normal25, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder25.PlaneToRestrictMotion = plane25;
    
    cutCopyPasteBuilder25.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder25.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder25.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder25.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder25.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder25.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder25.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder25.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder25.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId302, "粘贴 对话框");
    
    cutCopyPasteBuilder25.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder25.Transform.SetMotionToTwoDimensions(plane25);
    
    cutCopyPasteBuilder25.InitPaste();
    
    cutCopyPasteBuilder25.CutCopyPasteLeader.IsLeaderSelection = false;
    
    NXOpen.Point3d scaleAboutPoint862 = new NXOpen.Point3d(59.97909754208046, -43.365169114931426, 0.0);
    NXOpen.Point3d viewCenter862 = new NXOpen.Point3d(-59.979097542079572, 43.365169114930723, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint862, viewCenter862);
    
    NXOpen.Point3d scaleAboutPoint863 = new NXOpen.Point3d(68.990041773754399, -55.614421429863221, 0.0);
    NXOpen.Point3d viewCenter863 = new NXOpen.Point3d(-68.990041773753518, 55.614421429862546, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint863, viewCenter863);
    
    NXOpen.Point3d scaleAboutPoint864 = new NXOpen.Point3d(86.677539728505138, -69.518026787328964, 0.0);
    NXOpen.Point3d viewCenter864 = new NXOpen.Point3d(-86.677539728504328, 69.518026787328267, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint864, viewCenter864);
    
    NXOpen.Point3d scaleAboutPoint865 = new NXOpen.Point3d(113.29678416289362, -86.347549095020852, 0.0);
    NXOpen.Point3d viewCenter865 = new NXOpen.Point3d(-113.29678416289279, 86.347549095020156, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint865, viewCenter865);
    
    NXOpen.Point3d scaleAboutPoint866 = new NXOpen.Point3d(194.5569776583668, -94.872307126694835, 0.0);
    NXOpen.Point3d viewCenter866 = new NXOpen.Point3d(-194.55697765836578, 94.872307126694267, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint866, viewCenter866);
    
    NXOpen.Point3d scaleAboutPoint867 = new NXOpen.Point3d(-427.09725219173117, -164.9953167420777, 0.0);
    NXOpen.Point3d viewCenter867 = new NXOpen.Point3d(427.09725219173185, 164.99531674207711, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint867, viewCenter867);
    
    NXOpen.Point3d scaleAboutPoint868 = new NXOpen.Point3d(-327.24071153845307, -129.93381193438623, 0.0);
    NXOpen.Point3d viewCenter868 = new NXOpen.Point3d(327.24071153845381, 129.93381193438566, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint868, viewCenter868);
    
    NXOpen.Point3d scaleAboutPoint869 = new NXOpen.Point3d(-253.54280339365846, -103.94704954750898, 0.0);
    NXOpen.Point3d viewCenter869 = new NXOpen.Point3d(253.54280339365928, 103.94704954750853, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint869, viewCenter869);
    
    NXOpen.Point3d scaleAboutPoint870 = new NXOpen.Point3d(-198.43436760180469, -83.157639638007268, 0.0);
    NXOpen.Point3d viewCenter870 = new NXOpen.Point3d(198.43436760180552, 83.157639638006785, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint870, viewCenter870);
    
    NXOpen.Point3d scaleAboutPoint871 = new NXOpen.Point3d(-157.33953404524459, -66.526111710405843, 0.0);
    NXOpen.Point3d viewCenter871 = new NXOpen.Point3d(157.33953404524541, 66.526111710405374, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint871, viewCenter871);
    
    NXOpen.Point3d scaleAboutPoint872 = new NXOpen.Point3d(-125.59003522895578, -53.784073382804387, 0.0);
    NXOpen.Point3d viewCenter872 = new NXOpen.Point3d(125.59003522895657, 53.784073382803918, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint872, viewCenter872);
    
    NXOpen.Point3d scaleAboutPoint873 = new NXOpen.Point3d(-100.0214809715809, -43.477805917827219, 0.0);
    NXOpen.Point3d viewCenter873 = new NXOpen.Point3d(100.02148097158161, 43.477805917826764, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint873, viewCenter873);
    
    NXOpen.Point3d scaleAboutPoint874 = new NXOpen.Point3d(2.3428455002356094, -51.9030387744424, 0.0);
    NXOpen.Point3d viewCenter874 = new NXOpen.Point3d(-2.3428455002348882, 51.903038774441946, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint874, viewCenter874);
    
    NXOpen.Point3d coordinates15 = new NXOpen.Point3d(144.79208632678359, 123.42779874544422, 0.0);
    NXOpen.Point point26;
    point26 = workPart.Points.CreatePoint(coordinates15);
    
    NXOpen.Point3d point27 = new NXOpen.Point3d(144.79208632678359, 123.42779874544422, 0.0);
    cutCopyPasteBuilder25.CutCopyPasteLeader.Selection.SetValue(point26, workPart.Views.WorkView, point27);
    
    NXOpen.Session.UndoMarkId markId303;
    markId303 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "粘贴");
    
    NXOpen.Matrix3x3 rot12 = new NXOpen.Matrix3x3();
    rot12.Xx = 1.0;
    rot12.Xy = 0.0;
    rot12.Xz = 0.0;
    rot12.Yx = 0.0;
    rot12.Yy = 1.0;
    rot12.Yz = 0.0;
    rot12.Zx = 0.0;
    rot12.Zy = 0.0;
    rot12.Zz = 1.0;
    NXOpen.Vector3d trans12 = new NXOpen.Vector3d(-441.05102272529979, -93.638032160585368, 0.0);
    cutCopyPasteBuilder25.CutCopyPasteLeader.SetMoveOnCommit(rot12, trans12);
    
    NXOpen.NXObject nXObject19;
    nXObject19 = cutCopyPasteBuilder25.Commit();
    
    theSession.DeleteUndoMark(markId303, null);
    
    theSession.SetUndoMarkName(markId302, "粘贴");
    
    cutCopyPasteBuilder25.Destroy();
    
    workPart.Points.DeletePoint(point26);
    
    NXOpen.Session.UndoMarkId markId304;
    markId304 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Start");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder26;
    cutCopyPasteBuilder26 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder26.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder26.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation26 = new NXOpen.Point3d(585.84310905208338, 217.06583090602959, 0.0);
    cutCopyPasteBuilder26.SetDefaultToPoint(droplocation26);
    
    cutCopyPasteBuilder26.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects52 = new NXOpen.TaggedObject[1];
    objects52[0] = note68;
    bool added26;
    added26 = cutCopyPasteBuilder26.ObjectsToCopy.Add(objects52);
    
    NXOpen.Point3d origin233 = new NXOpen.Point3d(585.84310905208338, 217.06583090602959, 0.0);
    NXOpen.Vector3d normal26 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane26;
    plane26 = workPart.Planes.CreatePlane(origin233, normal26, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder26.PlaneToRestrictMotion = plane26;
    
    cutCopyPasteBuilder26.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder26.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder26.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder26.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder26.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder26.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder26.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder26.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder26.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId304, "粘贴 对话框");
    
    cutCopyPasteBuilder26.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder26.Transform.SetMotionToTwoDimensions(plane26);
    
    cutCopyPasteBuilder26.InitPaste();
    
    cutCopyPasteBuilder26.CutCopyPasteLeader.IsLeaderSelection = false;
    
    // ----------------------------------------------
    //   对话开始 粘贴
    // ----------------------------------------------
    NXOpen.Point3d scaleAboutPoint875 = new NXOpen.Point3d(-33.736975203387047, -33.016099664853733, 0.0);
    NXOpen.Point3d viewCenter875 = new NXOpen.Point3d(33.736975203387736, 33.016099664853265, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint875, viewCenter875);
    
    NXOpen.Point3d scaleAboutPoint876 = new NXOpen.Point3d(-27.393270464288577, -38.566841311564879, 0.0);
    NXOpen.Point3d viewCenter876 = new NXOpen.Point3d(27.393270464289266, 38.566841311564431, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint876, viewCenter876);
    
    NXOpen.Point3d scaleAboutPoint877 = new NXOpen.Point3d(-29.736115964523808, -45.955815581537543, 0.0);
    NXOpen.Point3d viewCenter877 = new NXOpen.Point3d(29.736115964524483, 45.955815581537109, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint877, viewCenter877);
    
    NXOpen.Point3d scaleAboutPoint878 = new NXOpen.Point3d(-35.199000904976174, -56.318401447962621, 0.0);
    NXOpen.Point3d viewCenter878 = new NXOpen.Point3d(35.199000904976877, 56.318401447962174, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint878, viewCenter878);
    
    NXOpen.Point3d scaleAboutPoint879 = new NXOpen.Point3d(-26.399250678732031, -38.014920977374842, 0.0);
    NXOpen.Point3d viewCenter879 = new NXOpen.Point3d(26.399250678732677, 38.014920977374402, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint879, viewCenter879);
    
    cutCopyPasteBuilder26.Destroy();
    
    theSession.UndoToMark(markId304, null);
    
    theSession.DeleteUndoMark(markId304, null);
    
    int nErrs217;
    nErrs217 = theSession.UpdateManager.DoUpdate(markId302);
    
    NXOpen.Point3d scaleAboutPoint880 = new NXOpen.Point3d(10.813133078009136, -40.369030157899708, 0.0);
    NXOpen.Point3d viewCenter880 = new NXOpen.Point3d(-10.813133078008452, 40.369030157899239, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint880, viewCenter880);
    
    NXOpen.Point3d scaleAboutPoint881 = new NXOpen.Point3d(8.5351663762419481, -32.295224126319795, 0.0);
    NXOpen.Point3d viewCenter881 = new NXOpen.Point3d(-8.5351663762412855, 32.295224126319347, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint881, viewCenter881);
    
    NXOpen.Point3d scaleAboutPoint882 = new NXOpen.Point3d(6.8281331009936297, -25.836179301055896, 0.0);
    NXOpen.Point3d viewCenter882 = new NXOpen.Point3d(-6.8281331009929529, 25.836179301055427, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint882, viewCenter882);
    
    NXOpen.Point3d scaleAboutPoint883 = new NXOpen.Point3d(5.4625064807949704, -20.66894344084475, 0.0);
    NXOpen.Point3d viewCenter883 = new NXOpen.Point3d(-5.4625064807942936, 20.668943440844295, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint883, viewCenter883);
    
    NXOpen.Point3d scaleAboutPoint884 = new NXOpen.Point3d(4.3109510605193426, -16.535154752675847, 0.0);
    NXOpen.Point3d viewCenter884 = new NXOpen.Point3d(-4.3109510605186632, 16.535154752675393, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint884, viewCenter884);
    
    NXOpen.Point3d scaleAboutPoint885 = new NXOpen.Point3d(3.4487608484155419, -13.228123802140734, 0.0);
    NXOpen.Point3d viewCenter885 = new NXOpen.Point3d(-3.4487608484148646, 13.228123802140265, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint885, viewCenter885);
    
    NXOpen.Session.UndoMarkId markId305;
    markId305 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note69 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 1 1"));
    note69.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Note note70 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-7897"));
    note69.InsertIntoStack(note70, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    int nErrs218;
    nErrs218 = theSession.UpdateManager.DoUpdate(markId305);
    
    NXOpen.Point3d scaleAboutPoint886 = new NXOpen.Point3d(-8.9573295460205049, -0.56691959152055116, 0.0);
    NXOpen.Point3d viewCenter886 = new NXOpen.Point3d(8.9573295460211977, 0.56691959152006899, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint886, viewCenter886);
    
    NXOpen.Point3d scaleAboutPoint887 = new NXOpen.Point3d(-11.432878428992518, -0.66140619010724788, 0.0);
    NXOpen.Point3d viewCenter887 = new NXOpen.Point3d(11.432878428993195, 0.66140619010679491, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint887, viewCenter887);
    
    NXOpen.Point3d scaleAboutPoint888 = new NXOpen.Point3d(-14.350152160357426, -0.82675773763400551, 0.0);
    NXOpen.Point3d viewCenter888 = new NXOpen.Point3d(14.350152160358107, 0.82675773763355254, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint888, viewCenter888);
    
    NXOpen.Point3d scaleAboutPoint889 = new NXOpen.Point3d(-18.01150785559274, -1.0334471720424514, 0.0);
    NXOpen.Point3d viewCenter889 = new NXOpen.Point3d(18.011507855593418, 1.033447172041996, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint889, viewCenter889);
    
    NXOpen.Point3d scaleAboutPoint890 = new NXOpen.Point3d(-22.514384819491021, -1.2918089650530025, 0.0);
    NXOpen.Point3d viewCenter890 = new NXOpen.Point3d(22.514384819491681, 1.2918089650525486, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint890, viewCenter890);
    
    NXOpen.Point3d scaleAboutPoint891 = new NXOpen.Point3d(-28.489001282860116, -1.6147612063162053, 0.0);
    NXOpen.Point3d viewCenter891 = new NXOpen.Point3d(28.489001282860787, 1.6147612063157437, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint891, viewCenter891);
    
    NXOpen.Point3d scaleAboutPoint892 = new NXOpen.Point3d(-47.145260220117933, -10.813133078009013, 0.0);
    NXOpen.Point3d viewCenter892 = new NXOpen.Point3d(47.145260220118615, 10.813133078008557, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint892, viewCenter892);
    
    NXOpen.Point3d scaleAboutPoint893 = new NXOpen.Point3d(-59.832669698314902, -13.876854116778144, 0.0);
    NXOpen.Point3d viewCenter893 = new NXOpen.Point3d(59.832669698315549, 13.876854116777725, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint893, viewCenter893);
    
    NXOpen.Point3d scaleAboutPoint894 = new NXOpen.Point3d(-73.439195488142644, -18.472435674931894, 0.0);
    NXOpen.Point3d viewCenter894 = new NXOpen.Point3d(73.43919548814327, 18.472435674931443, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint894, viewCenter894);
    
    NXOpen.Point3d scaleAboutPoint895 = new NXOpen.Point3d(-91.798994360178384, -23.090544593664823, 0.0);
    NXOpen.Point3d viewCenter895 = new NXOpen.Point3d(91.798994360178995, 23.090544593664376, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint895, viewCenter895);
    
    NXOpen.Point3d scaleAboutPoint896 = new NXOpen.Point3d(-114.74874295022306, -28.863180742080967, 0.0);
    NXOpen.Point3d viewCenter896 = new NXOpen.Point3d(114.74874295022367, 28.863180742080498, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint896, viewCenter896);
    
    NXOpen.Point3d scaleAboutPoint897 = new NXOpen.Point3d(-143.43592868777893, -36.078975927601171, 0.0);
    NXOpen.Point3d viewCenter897 = new NXOpen.Point3d(143.43592868777952, 36.078975927600659, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint897, viewCenter897);
    
    NXOpen.Point3d scaleAboutPoint898 = new NXOpen.Point3d(-102.8470807692279, -9.8997190045248669, 0.0);
    NXOpen.Point3d viewCenter898 = new NXOpen.Point3d(102.84708076922854, 9.8997190045244086, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint898, viewCenter898);
    
    NXOpen.Session.UndoMarkId markId306;
    markId306 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Point3d drawingReferencePoint34 = new NXOpen.Point3d(165.38731169526969, 191.00045053551924, 0.0);
    sectionView5.MoveView(drawingReferencePoint34);
    
    int nErrs219;
    nErrs219 = theSession.UpdateManager.DoUpdate(markId306);
    
    NXOpen.Session.UndoMarkId markId307;
    markId307 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Point3d drawingReferencePoint35 = new NXOpen.Point3d(173.74707441020158, 190.12047551289481, 0.0);
    sectionView5.MoveView(drawingReferencePoint35);
    
    int nErrs220;
    nErrs220 = theSession.UpdateManager.DoUpdate(markId307);
    
    NXOpen.Point3d scaleAboutPoint899 = new NXOpen.Point3d(-175.11502950225778, -39.158888506786582, 0.0);
    NXOpen.Point3d viewCenter899 = new NXOpen.Point3d(175.11502950225838, 39.158888506786106, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint899, viewCenter899);
    
    NXOpen.Point3d scaleAboutPoint900 = new NXOpen.Point3d(-223.84364638008464, -49.498595022623469, 0.0);
    NXOpen.Point3d viewCenter900 = new NXOpen.Point3d(223.84364638008526, 49.498595022622965, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint900, viewCenter900);
    
    NXOpen.Point3d scaleAboutPoint901 = new NXOpen.Point3d(356.11489196831735, 34.374024321265807, 0.0);
    NXOpen.Point3d viewCenter901 = new NXOpen.Point3d(-356.11489196831667, -34.374024321266383, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint901, viewCenter901);
    
    NXOpen.Point3d scaleAboutPoint902 = new NXOpen.Point3d(284.89191357465387, 27.499219457012551, 0.0);
    NXOpen.Point3d viewCenter902 = new NXOpen.Point3d(-284.8919135746533, -27.499219457013194, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint902, viewCenter902);
    
    NXOpen.Point3d scaleAboutPoint903 = new NXOpen.Point3d(227.91353085972298, 21.999375565610034, 0.0);
    NXOpen.Point3d viewCenter903 = new NXOpen.Point3d(-227.91353085972261, -21.999375565610585, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint903, viewCenter903);
    
    NXOpen.Point3d scaleAboutPoint904 = new NXOpen.Point3d(182.33082468777852, 17.599500452487941, 0.0);
    NXOpen.Point3d viewCenter904 = new NXOpen.Point3d(-182.33082468777803, -17.599500452488531, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint904, viewCenter904);
    
    NXOpen.Point3d scaleAboutPoint905 = new NXOpen.Point3d(145.86465975022284, 14.079600361990309, 0.0);
    NXOpen.Point3d viewCenter905 = new NXOpen.Point3d(-145.86465975022242, -14.079600361990872, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint905, viewCenter905);
    
    NXOpen.Point3d scaleAboutPoint906 = new NXOpen.Point3d(116.6917278001783, 11.263680289592168, 0.0);
    NXOpen.Point3d viewCenter906 = new NXOpen.Point3d(-116.69172780017786, -11.263680289592751, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint906, viewCenter906);
    
    NXOpen.Point3d scaleAboutPoint907 = new NXOpen.Point3d(92.63250670160879, 8.8307253470401843, 0.0);
    NXOpen.Point3d viewCenter907 = new NXOpen.Point3d(-92.632506701608349, -8.8307253470408149, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint907, viewCenter907);
    
    NXOpen.Session.UndoMarkId markId308;
    markId308 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note68.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Note note71 = ((NXOpen.Annotations.Note)workPart.FindObject("HANDLE R-9955"));
    note68.InsertIntoStack(note71, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    int nErrs221;
    nErrs221 = theSession.UpdateManager.DoUpdate(markId308);
    
    NXOpen.Point3d scaleAboutPoint908 = new NXOpen.Point3d(10.813133078008997, -6.3437047390988255, 0.0);
    NXOpen.Point3d viewCenter908 = new NXOpen.Point3d(-10.813133078008541, 6.3437047390981647, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint908, viewCenter908);
    
    NXOpen.Point3d scaleAboutPoint909 = new NXOpen.Point3d(10.993351962642496, -7.7494120392399521, 0.0);
    NXOpen.Point3d viewCenter909 = new NXOpen.Point3d(-10.993351962642061, 7.7494120392392762, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint909, viewCenter909);
    
    NXOpen.Point3d scaleAboutPoint910 = new NXOpen.Point3d(12.390048318551946, -9.2362178374661532, 0.0);
    NXOpen.Point3d viewCenter910 = new NXOpen.Point3d(-12.390048318551495, 9.2362178374654942, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint910, viewCenter910);
    
    NXOpen.Point3d scaleAboutPoint911 = new NXOpen.Point3d(153.74923595293754, 20.556216528505917, 0.0);
    NXOpen.Point3d viewCenter911 = new NXOpen.Point3d(-153.74923595293711, -20.556216528506621, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint911, viewCenter911);
    
    NXOpen.Point3d scaleAboutPoint912 = new NXOpen.Point3d(189.01863485972393, 23.583330606333867, 0.0);
    NXOpen.Point3d viewCenter912 = new NXOpen.Point3d(-189.01863485972351, -23.583330606334602, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint912, viewCenter912);
    
    NXOpen.Point3d scaleAboutPoint913 = new NXOpen.Point3d(236.27329357465479, 29.479163257917399, 0.0);
    NXOpen.Point3d viewCenter913 = new NXOpen.Point3d(-236.27329357465442, -29.47916325791817, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint913, viewCenter913);
    
    NXOpen.Point3d scaleAboutPoint914 = new NXOpen.Point3d(295.34161696831865, 36.8489540723969, 0.0);
    NXOpen.Point3d viewCenter914 = new NXOpen.Point3d(-295.34161696831819, -36.848954072397589, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint914, viewCenter914);
    
    NXOpen.Point3d origin234 = new NXOpen.Point3d(436.6280272250587, 302.92476104463447, 0.0);
    workPart.Views.WorkView.SetOrigin(origin234);
    
    NXOpen.Point3d origin235 = new NXOpen.Point3d(436.6280272250587, 302.92476104463447, 0.0);
    workPart.Views.WorkView.SetOrigin(origin235);
    
    NXOpen.Point3d scaleAboutPoint915 = new NXOpen.Point3d(-5.4998438914023264, 87.310021776015546, 0.0);
    NXOpen.Point3d viewCenter915 = new NXOpen.Point3d(5.4998438914028993, -87.310021776016228, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint915, viewCenter915);
    
    NXOpen.Point3d scaleAboutPoint916 = new NXOpen.Point3d(-3.8498907239815647, 69.848017420812383, 0.0);
    NXOpen.Point3d viewCenter916 = new NXOpen.Point3d(3.849890723982023, -69.848017420813022, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint916, viewCenter916);
    
    NXOpen.Point3d scaleAboutPoint917 = new NXOpen.Point3d(-2.1999375565607422, 56.318401447961996, 0.0);
    NXOpen.Point3d viewCenter917 = new NXOpen.Point3d(2.199937556561256, -56.318401447962692, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint917, viewCenter917);
    
    NXOpen.Point3d scaleAboutPoint918 = new NXOpen.Point3d(-0.70398001809925559, 45.758701176469103, 0.0);
    NXOpen.Point3d viewCenter918 = new NXOpen.Point3d(0.70398001809990129, -45.758701176469721, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint918, viewCenter918);
    
    NXOpen.Point3d scaleAboutPoint919 = new NXOpen.Point3d(3.5217761613154171e-13, 36.888552948415104, 0.0);
    NXOpen.Point3d viewCenter919 = new NXOpen.Point3d(3.2869910838943893e-13, -36.888552948415622, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint919, viewCenter919);
    
    NXOpen.Point3d scaleAboutPoint920 = new NXOpen.Point3d(0.45054721158401201, 29.510842358732003, 0.0);
    NXOpen.Point3d viewCenter920 = new NXOpen.Point3d(-0.45054721158339217, -29.510842358732564, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint920, viewCenter920);
    
    NXOpen.Point3d scaleAboutPoint921 = new NXOpen.Point3d(1.0813133078011778, 23.969111656252501, 0.0);
    NXOpen.Point3d viewCenter921 = new NXOpen.Point3d(-1.0813133078006218, -23.969111656253073, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint921, viewCenter921);
    
    NXOpen.Session.UndoMarkId markId309;
    markId309 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.IdSymbol idSymbol10 = ((NXOpen.Annotations.IdSymbol)workPart.FindObject("HANDLE R-66715"));
    idSymbol10.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin236 = new NXOpen.Point3d(434.05114356780604, 428.0645570532659, 0.0);
    idSymbol10.AnnotationOrigin = origin236;
    
    int nErrs222;
    nErrs222 = theSession.UpdateManager.DoUpdate(markId309);
    
    NXOpen.Point3d scaleAboutPoint922 = new NXOpen.Point3d(-12.831584585903471, 6.9204051699253268, 0.0);
    NXOpen.Point3d viewCenter922 = new NXOpen.Point3d(12.831584585904025, -6.9204051699259042, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint922, viewCenter922);
    
    NXOpen.Point3d scaleAboutPoint923 = new NXOpen.Point3d(-16.219699617012822, 8.2900686931397836, 0.0);
    NXOpen.Point3d viewCenter923 = new NXOpen.Point3d(16.219699617013497, -8.2900686931403538, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint923, viewCenter923);
    
    NXOpen.Point3d scaleAboutPoint924 = new NXOpen.Point3d(-20.274624521266137, 10.137312260632955, 0.0);
    NXOpen.Point3d viewCenter924 = new NXOpen.Point3d(20.274624521266777, -10.13731226063352, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint924, viewCenter924);
    
    NXOpen.Point3d scaleAboutPoint925 = new NXOpen.Point3d(-25.624872658822532, 12.671640325791268, 0.0);
    NXOpen.Point3d viewCenter925 = new NXOpen.Point3d(25.624872658823236, -12.671640325791833, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint925, viewCenter925);
    
    NXOpen.Point3d scaleAboutPoint926 = new NXOpen.Point3d(-32.38308083257791, 15.839550407239209, 0.0);
    NXOpen.Point3d viewCenter926 = new NXOpen.Point3d(32.383080832578784, -15.839550407239736, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint926, viewCenter926);
    
    NXOpen.Point3d scaleAboutPoint927 = new NXOpen.Point3d(-99.437177556558211, 72.597939366513714, 0.0);
    NXOpen.Point3d viewCenter927 = new NXOpen.Point3d(99.437177556558979, -72.597939366514339, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint927, viewCenter927);
    
    NXOpen.Point3d scaleAboutPoint928 = new NXOpen.Point3d(-79.549742045246447, 58.078351493210896, 0.0);
    NXOpen.Point3d viewCenter928 = new NXOpen.Point3d(79.549742045247385, -58.078351493211571, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint928, viewCenter928);
    
    NXOpen.Point3d scaleAboutPoint929 = new NXOpen.Point3d(-63.639793636197098, 46.462681194568617, 0.0);
    NXOpen.Point3d viewCenter929 = new NXOpen.Point3d(63.639793636197943, -46.46268119456937, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint929, viewCenter929);
    
    NXOpen.Point3d scaleAboutPoint930 = new NXOpen.Point3d(-50.91183490895758, 37.170144955654848, 0.0);
    NXOpen.Point3d viewCenter930 = new NXOpen.Point3d(50.911834908958483, -37.17014495565558, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint930, viewCenter930);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId310;
    markId310 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId311;
    markId311 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects53 = new NXOpen.TaggedObject[1];
    NXOpen.Annotations.Note note72 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 45 1"));
    objects53[0] = note72;
    int nErrs223;
    nErrs223 = theSession.UpdateManager.AddObjectsToDeleteList(objects53);
    
    NXOpen.Session.UndoMarkId id26;
    id26 = theSession.NewestVisibleUndoMark;
    
    int nErrs224;
    nErrs224 = theSession.UpdateManager.DoUpdate(id26);
    
    theSession.DeleteUndoMark(markId310, null);
    
    NXOpen.Session.UndoMarkId markId312;
    markId312 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Annotations.Note note73 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 45 1"));
    NXOpen.Annotations.DraftingNoteBuilder draftingNoteBuilder8;
    draftingNoteBuilder8 = workPart.Annotations.CreateDraftingNoteBuilder(note73);
    
    draftingNoteBuilder8.Text.TextBlock.CustomSymbolScale = 1.0;
    
    draftingNoteBuilder8.Origin.SetInferRelativeToGeometry(true);
    
    theSession.SetUndoMarkName(markId312, "注释 对话框");
    
    draftingNoteBuilder8.Origin.SetInferRelativeToGeometry(true);
    
    NXOpen.Annotations.LeaderData leaderData9;
    leaderData9 = workPart.Annotations.CreateLeaderData();
    
    leaderData9.StubSize = 3.5000000103999995;
    
    leaderData9.Arrowhead = NXOpen.Annotations.LeaderData.ArrowheadType.FilledArrow;
    
    leaderData9.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Center;
    
    draftingNoteBuilder8.Leader.Leaders.Append(leaderData9);
    
    leaderData9.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Legacy;
    
    leaderData9.StubSide = NXOpen.Annotations.LeaderSide.Inferred;
    
    double symbolscale8;
    symbolscale8 = draftingNoteBuilder8.Text.TextBlock.SymbolScale;
    
    double symbolaspectratio8;
    symbolaspectratio8 = draftingNoteBuilder8.Text.TextBlock.SymbolAspectRatio;
    
    draftingNoteBuilder8.Origin.SetInferRelativeToGeometry(true);
    
    draftingNoteBuilder8.Origin.SetInferRelativeToGeometry(true);
    
    NXOpen.Session.UndoMarkId markId313;
    markId313 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.DeleteUndoMark(markId313, null);
    
    NXOpen.Session.UndoMarkId markId314;
    markId314 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    draftingNoteBuilder8.Destroy();
    
    theSession.UndoToMark(markId312, null);
    
    theSession.DeleteUndoMark(markId312, null);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->撤消
    // ----------------------------------------------
    bool marksRecycled10;
    bool undoUnavailable10;
    theSession.UndoLastNVisibleMarks(1, out marksRecycled10, out undoUnavailable10);
    
    NXOpen.Session.UndoMarkId markId315;
    markId315 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note74 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 45 1"));
    NXOpen.Annotations.Annotation.AssociativeOriginData assocOrigin3 = new NXOpen.Annotations.Annotation.AssociativeOriginData();
    assocOrigin3.OriginType = NXOpen.Annotations.AssociativeOriginType.Drag;
    assocOrigin3.View = nullNXOpen_View;
    assocOrigin3.ViewOfGeometry = nullNXOpen_View;
    assocOrigin3.PointOnGeometry = nullNXOpen_Point;
    assocOrigin3.VertAnnotation = note73;
    assocOrigin3.VertAlignmentPosition = NXOpen.Annotations.AlignmentPosition.BottomCenter;
    assocOrigin3.HorizAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin3.HorizAlignmentPosition = NXOpen.Annotations.AlignmentPosition.TopLeft;
    assocOrigin3.AlignedAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin3.DimensionLine = 0;
    assocOrigin3.AssociatedView = nullNXOpen_View;
    assocOrigin3.AssociatedPoint = nullNXOpen_Point;
    assocOrigin3.OffsetAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin3.OffsetAlignmentPosition = NXOpen.Annotations.AlignmentPosition.TopLeft;
    assocOrigin3.XOffsetFactor = 0.0;
    assocOrigin3.YOffsetFactor = 0.0;
    assocOrigin3.StackAlignmentPosition = NXOpen.Annotations.StackAlignmentPosition.Above;
    NXOpen.Point3d origin237 = new NXOpen.Point3d(409.63564001615418, 450.64331406894252, 0.0);
    note74.SetAssociativeOrigin(assocOrigin3, origin237);
    
    note74.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Annotation.AssociativeOriginData assocOrigin4 = new NXOpen.Annotations.Annotation.AssociativeOriginData();
    assocOrigin4.OriginType = NXOpen.Annotations.AssociativeOriginType.HorizontallyAligned;
    assocOrigin4.View = nullNXOpen_View;
    assocOrigin4.ViewOfGeometry = nullNXOpen_View;
    assocOrigin4.PointOnGeometry = nullNXOpen_Point;
    assocOrigin4.VertAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin4.VertAlignmentPosition = NXOpen.Annotations.AlignmentPosition.TopLeft;
    assocOrigin4.HorizAnnotation = label14;
    assocOrigin4.HorizAlignmentPosition = NXOpen.Annotations.AlignmentPosition.BottomCenter;
    assocOrigin4.AlignedAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin4.DimensionLine = 0;
    assocOrigin4.AssociatedView = nullNXOpen_View;
    assocOrigin4.AssociatedPoint = nullNXOpen_Point;
    assocOrigin4.OffsetAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin4.OffsetAlignmentPosition = NXOpen.Annotations.AlignmentPosition.TopLeft;
    assocOrigin4.XOffsetFactor = 0.0;
    assocOrigin4.YOffsetFactor = 0.0;
    assocOrigin4.StackAlignmentPosition = NXOpen.Annotations.StackAlignmentPosition.Above;
    NXOpen.Point3d origin238 = new NXOpen.Point3d(396.48198273789222, 461.42571477989884, 0.0);
    note74.SetAssociativeOrigin(assocOrigin4, origin238);
    
    int nErrs225;
    nErrs225 = theSession.UpdateManager.DoUpdate(markId315);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId316;
    markId316 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId317;
    markId317 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects54 = new NXOpen.TaggedObject[1];
    objects54[0] = note74;
    int nErrs226;
    nErrs226 = theSession.UpdateManager.AddObjectsToDeleteList(objects54);
    
    NXOpen.Session.UndoMarkId id27;
    id27 = theSession.NewestVisibleUndoMark;
    
    int nErrs227;
    nErrs227 = theSession.UpdateManager.DoUpdate(id27);
    
    theSession.DeleteUndoMark(markId316, null);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->删除(D)...
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId318;
    markId318 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Delete");
    
    theSession.UpdateManager.ClearErrorList();
    
    NXOpen.Session.UndoMarkId markId319;
    markId319 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Delete");
    
    NXOpen.TaggedObject[] objects55 = new NXOpen.TaggedObject[1];
    objects55[0] = note73;
    int nErrs228;
    nErrs228 = theSession.UpdateManager.AddObjectsToDeleteList(objects55);
    
    NXOpen.Session.UndoMarkId id28;
    id28 = theSession.NewestVisibleUndoMark;
    
    int nErrs229;
    nErrs229 = theSession.UpdateManager.DoUpdate(id28);
    
    theSession.DeleteUndoMark(markId318, null);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->复制(C)
    // ----------------------------------------------
    workPart.PmiManager.RestoreUnpastedObjects();
    
    // ----------------------------------------------
    //   菜单：编辑(E)->粘贴(P)
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId320;
    markId320 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder27;
    cutCopyPasteBuilder27 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder27.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder27.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation27 = new NXOpen.Point3d(402.60942481543049, 402.24256998937432, 0.0);
    cutCopyPasteBuilder27.SetDefaultToPoint(droplocation27);
    
    cutCopyPasteBuilder27.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects56 = new NXOpen.TaggedObject[1];
    objects56[0] = note42;
    bool added27;
    added27 = cutCopyPasteBuilder27.ObjectsToCopy.Add(objects56);
    
    NXOpen.Point3d origin239 = new NXOpen.Point3d(402.60942481543049, 402.24256998937432, 0.0);
    NXOpen.Vector3d normal27 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane27;
    plane27 = workPart.Planes.CreatePlane(origin239, normal27, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder27.PlaneToRestrictMotion = plane27;
    
    cutCopyPasteBuilder27.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder27.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder27.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder27.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder27.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder27.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder27.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder27.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder27.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId320, "粘贴 对话框");
    
    cutCopyPasteBuilder27.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder27.Transform.SetMotionToTwoDimensions(plane27);
    
    cutCopyPasteBuilder27.InitPaste();
    
    cutCopyPasteBuilder27.CutCopyPasteLeader.IsLeaderSelection = false;
    
    NXOpen.Point3d scaleAboutPoint931 = new NXOpen.Point3d(-36.223995811328962, 50.100849928107003, 0.0);
    NXOpen.Point3d viewCenter931 = new NXOpen.Point3d(36.223995811329893, -50.100849928107799, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint931, viewCenter931);
    
    NXOpen.Point3d coordinates16 = new NXOpen.Point3d(368.11553029658245, 459.69635041052834, 0.0);
    NXOpen.Point point28;
    point28 = workPart.Points.CreatePoint(coordinates16);
    
    NXOpen.Point3d point29 = new NXOpen.Point3d(368.11553029658245, 459.69635041052834, 0.0);
    cutCopyPasteBuilder27.CutCopyPasteLeader.Selection.SetValue(point28, workPart.Views.WorkView, point29);
    
    NXOpen.Session.UndoMarkId markId321;
    markId321 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "粘贴");
    
    NXOpen.Matrix3x3 rot13 = new NXOpen.Matrix3x3();
    rot13.Xx = 1.0;
    rot13.Xy = 0.0;
    rot13.Xz = 0.0;
    rot13.Yx = 0.0;
    rot13.Yy = 1.0;
    rot13.Yz = 0.0;
    rot13.Zx = 0.0;
    rot13.Zy = 0.0;
    rot13.Zz = 1.0;
    NXOpen.Vector3d trans13 = new NXOpen.Vector3d(-34.493894518848037, 57.453780421154022, 0.0);
    cutCopyPasteBuilder27.CutCopyPasteLeader.SetMoveOnCommit(rot13, trans13);
    
    NXOpen.NXObject nXObject20;
    nXObject20 = cutCopyPasteBuilder27.Commit();
    
    theSession.DeleteUndoMark(markId321, null);
    
    theSession.SetUndoMarkName(markId320, "粘贴");
    
    cutCopyPasteBuilder27.Destroy();
    
    workPart.Points.DeletePoint(point28);
    
    NXOpen.Session.UndoMarkId markId322;
    markId322 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Start");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder28;
    cutCopyPasteBuilder28 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder28.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder28.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation28 = new NXOpen.Point3d(402.60942481543049, 402.24256998937432, 0.0);
    cutCopyPasteBuilder28.SetDefaultToPoint(droplocation28);
    
    cutCopyPasteBuilder28.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects57 = new NXOpen.TaggedObject[1];
    objects57[0] = note42;
    bool added28;
    added28 = cutCopyPasteBuilder28.ObjectsToCopy.Add(objects57);
    
    NXOpen.Point3d origin240 = new NXOpen.Point3d(402.60942481543049, 402.24256998937432, 0.0);
    NXOpen.Vector3d normal28 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane28;
    plane28 = workPart.Planes.CreatePlane(origin240, normal28, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder28.PlaneToRestrictMotion = plane28;
    
    cutCopyPasteBuilder28.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder28.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder28.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder28.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder28.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder28.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder28.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder28.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder28.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId322, "粘贴 对话框");
    
    cutCopyPasteBuilder28.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder28.Transform.SetMotionToTwoDimensions(plane28);
    
    cutCopyPasteBuilder28.InitPaste();
    
    cutCopyPasteBuilder28.CutCopyPasteLeader.IsLeaderSelection = false;
    
    // ----------------------------------------------
    //   对话开始 粘贴
    // ----------------------------------------------
    cutCopyPasteBuilder28.Destroy();
    
    theSession.UndoToMark(markId322, null);
    
    theSession.DeleteUndoMark(markId322, null);
    
    int nErrs230;
    nErrs230 = theSession.UpdateManager.DoUpdate(markId320);
    
    NXOpen.Point3d scaleAboutPoint932 = new NXOpen.Point3d(-23.068017233084959, 5.4786540928573846, 0.0);
    NXOpen.Point3d viewCenter932 = new NXOpen.Point3d(23.068017233085875, -5.4786540928581786, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint932, viewCenter932);
    
    NXOpen.Point3d scaleAboutPoint933 = new NXOpen.Point3d(-28.835021541356319, 6.848317616071836, 0.0);
    NXOpen.Point3d viewCenter933 = new NXOpen.Point3d(28.835021541357222, -6.8483176160726327, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint933, viewCenter933);
    
    NXOpen.Point3d scaleAboutPoint934 = new NXOpen.Point3d(-35.36795610931992, 8.5603970200898889, 0.0);
    NXOpen.Point3d viewCenter934 = new NXOpen.Point3d(35.367956109320858, -8.5603970200906776, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint934, viewCenter934);
    
    NXOpen.Point3d scaleAboutPoint935 = new NXOpen.Point3d(-41.39402506425192, 11.545272296831902, 0.0);
    NXOpen.Point3d viewCenter935 = new NXOpen.Point3d(41.394025064252816, -11.5452722968327, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint935, viewCenter935);
    
    NXOpen.Point3d scaleAboutPoint936 = new NXOpen.Point3d(-20.063430515836185, 32.735070841627802, 0.0);
    NXOpen.Point3d viewCenter936 = new NXOpen.Point3d(20.063430515837062, -32.735070841628534, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint936, viewCenter936);
    
    NXOpen.Point3d scaleAboutPoint937 = new NXOpen.Point3d(-29.919150769229617, 138.59606606334467, 0.0);
    NXOpen.Point3d viewCenter937 = new NXOpen.Point3d(29.919150769230423, -138.5960660633454, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint937, viewCenter937);
    
    NXOpen.Point3d scaleAboutPoint938 = new NXOpen.Point3d(-23.935320615383603, 110.87685285067568, 0.0);
    NXOpen.Point3d viewCenter938 = new NXOpen.Point3d(23.935320615384427, -110.87685285067634, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint938, viewCenter938);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->复制(C)
    // ----------------------------------------------
    workPart.PmiManager.RestoreUnpastedObjects();
    
    // ----------------------------------------------
    //   菜单：编辑(E)->粘贴(P)
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId323;
    markId323 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder29;
    cutCopyPasteBuilder29 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder29.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder29.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation29 = new NXOpen.Point3d(421.77584399220461, 445.86539579092965, 0.0);
    cutCopyPasteBuilder29.SetDefaultToPoint(droplocation29);
    
    cutCopyPasteBuilder29.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects58 = new NXOpen.TaggedObject[1];
    objects58[0] = note36;
    bool added29;
    added29 = cutCopyPasteBuilder29.ObjectsToCopy.Add(objects58);
    
    NXOpen.Point3d origin241 = new NXOpen.Point3d(421.77584399220461, 445.86539579092965, 0.0);
    NXOpen.Vector3d normal29 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane29;
    plane29 = workPart.Planes.CreatePlane(origin241, normal29, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder29.PlaneToRestrictMotion = plane29;
    
    cutCopyPasteBuilder29.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder29.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder29.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder29.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder29.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder29.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder29.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder29.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder29.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId323, "粘贴 对话框");
    
    cutCopyPasteBuilder29.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder29.Transform.SetMotionToTwoDimensions(plane29);
    
    cutCopyPasteBuilder29.InitPaste();
    
    cutCopyPasteBuilder29.CutCopyPasteLeader.IsLeaderSelection = false;
    
    NXOpen.Point3d scaleAboutPoint939 = new NXOpen.Point3d(27.877608716741832, 85.885562208142346, 0.0);
    NXOpen.Point3d viewCenter939 = new NXOpen.Point3d(-27.877608716740987, -85.885562208143071, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint939, viewCenter939);
    
    NXOpen.Point3d scaleAboutPoint940 = new NXOpen.Point3d(22.30208697339356, 68.70844976651388, 0.0);
    NXOpen.Point3d viewCenter940 = new NXOpen.Point3d(-22.302086973392715, -68.708449766514505, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint940, viewCenter940);
    
    NXOpen.Point3d scaleAboutPoint941 = new NXOpen.Point3d(17.841669578714857, 54.966759813210992, 0.0);
    NXOpen.Point3d viewCenter941 = new NXOpen.Point3d(-17.841669578714104, -54.966759813211667, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint941, viewCenter941);
    
    NXOpen.Point3d coordinates17 = new NXOpen.Point3d(448.06752652417134, 532.47183353760727, 0.0);
    NXOpen.Point point30;
    point30 = workPart.Points.CreatePoint(coordinates17);
    
    NXOpen.Point3d point31 = new NXOpen.Point3d(448.06752652417134, 532.47183353760727, 0.0);
    cutCopyPasteBuilder29.CutCopyPasteLeader.Selection.SetValue(point30, workPart.Views.WorkView, point31);
    
    NXOpen.Session.UndoMarkId markId324;
    markId324 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "粘贴");
    
    NXOpen.Matrix3x3 rot14 = new NXOpen.Matrix3x3();
    rot14.Xx = 1.0;
    rot14.Xy = 0.0;
    rot14.Xz = 0.0;
    rot14.Yx = 0.0;
    rot14.Yy = 1.0;
    rot14.Yz = 0.0;
    rot14.Zx = 0.0;
    rot14.Zy = 0.0;
    rot14.Zz = 1.0;
    NXOpen.Vector3d trans14 = new NXOpen.Vector3d(26.291682531966728, 86.606437746677614, 0.0);
    cutCopyPasteBuilder29.CutCopyPasteLeader.SetMoveOnCommit(rot14, trans14);
    
    NXOpen.NXObject nXObject21;
    nXObject21 = cutCopyPasteBuilder29.Commit();
    
    theSession.DeleteUndoMark(markId324, null);
    
    theSession.SetUndoMarkName(markId323, "粘贴");
    
    cutCopyPasteBuilder29.Destroy();
    
    workPart.Points.DeletePoint(point30);
    
    NXOpen.Session.UndoMarkId markId325;
    markId325 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Start");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder30;
    cutCopyPasteBuilder30 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder30.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder30.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation30 = new NXOpen.Point3d(421.77584399220461, 445.86539579092965, 0.0);
    cutCopyPasteBuilder30.SetDefaultToPoint(droplocation30);
    
    cutCopyPasteBuilder30.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects59 = new NXOpen.TaggedObject[1];
    objects59[0] = note36;
    bool added30;
    added30 = cutCopyPasteBuilder30.ObjectsToCopy.Add(objects59);
    
    NXOpen.Point3d origin242 = new NXOpen.Point3d(421.77584399220461, 445.86539579092965, 0.0);
    NXOpen.Vector3d normal30 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane30;
    plane30 = workPart.Planes.CreatePlane(origin242, normal30, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder30.PlaneToRestrictMotion = plane30;
    
    cutCopyPasteBuilder30.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder30.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder30.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder30.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder30.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder30.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder30.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder30.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder30.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId325, "粘贴 对话框");
    
    cutCopyPasteBuilder30.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder30.Transform.SetMotionToTwoDimensions(plane30);
    
    cutCopyPasteBuilder30.InitPaste();
    
    cutCopyPasteBuilder30.CutCopyPasteLeader.IsLeaderSelection = false;
    
    // ----------------------------------------------
    //   对话开始 粘贴
    // ----------------------------------------------
    cutCopyPasteBuilder30.Destroy();
    
    theSession.UndoToMark(markId325, null);
    
    theSession.DeleteUndoMark(markId325, null);
    
    int nErrs231;
    nErrs231 = theSession.UpdateManager.DoUpdate(markId323);
    
    NXOpen.Point3d scaleAboutPoint942 = new NXOpen.Point3d(-44.550108281395786, 2.4509768310149891, 0.0);
    NXOpen.Point3d viewCenter942 = new NXOpen.Point3d(44.550108281396582, -2.4509768310156743, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint942, viewCenter942);
    
    NXOpen.Point3d scaleAboutPoint943 = new NXOpen.Point3d(-55.867854236378292, 3.0637210387687821, 0.0);
    NXOpen.Point3d viewCenter943 = new NXOpen.Point3d(55.86785423637911, -3.0637210387695184, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint943, viewCenter943);
    
    NXOpen.Point3d scaleAboutPoint944 = new NXOpen.Point3d(-69.834817795472972, 3.8296512984611084, 0.0);
    NXOpen.Point3d viewCenter944 = new NXOpen.Point3d(69.834817795473796, -3.8296512984617848, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint944, viewCenter944);
    
    NXOpen.Point3d scaleAboutPoint945 = new NXOpen.Point3d(-87.29352224434129, 4.7870641230765045, 0.0);
    NXOpen.Point3d viewCenter945 = new NXOpen.Point3d(87.293522244342228, -4.7870641230771147, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint945, viewCenter945);
    
    NXOpen.Point3d scaleAboutPoint946 = new NXOpen.Point3d(-109.1169028054267, 5.9838301538456591, 0.0);
    NXOpen.Point3d viewCenter946 = new NXOpen.Point3d(109.11690280542766, -5.9838301538463634, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint946, viewCenter946);
    
    NXOpen.Point3d scaleAboutPoint947 = new NXOpen.Point3d(-136.3961285067835, 7.4797876923071085, 0.0);
    NXOpen.Point3d viewCenter947 = new NXOpen.Point3d(136.39612850678429, -7.479787692307915, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint947, viewCenter947);
    
    NXOpen.Point3d origin243 = new NXOpen.Point3d(560.59496612428404, 384.08153987545734, 0.0);
    workPart.Views.WorkView.SetOrigin(origin243);
    
    NXOpen.Point3d origin244 = new NXOpen.Point3d(560.59496612428404, 384.08153987545734, 0.0);
    workPart.Views.WorkView.SetOrigin(origin244);
    
    NXOpen.Point3d scaleAboutPoint948 = new NXOpen.Point3d(138.04608167420508, 78.097783257916149, 0.0);
    NXOpen.Point3d viewCenter948 = new NXOpen.Point3d(-138.04608167420437, -78.097783257916973, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint948, viewCenter948);
    
    NXOpen.Point3d scaleAboutPoint949 = new NXOpen.Point3d(110.43686533936425, 62.478226606332932, 0.0);
    NXOpen.Point3d viewCenter949 = new NXOpen.Point3d(-110.43686533936337, -62.478226606333664, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint949, viewCenter949);
    
    NXOpen.Point3d scaleAboutPoint950 = new NXOpen.Point3d(88.349492271491414, 49.982581285066217, 0.0);
    NXOpen.Point3d viewCenter950 = new NXOpen.Point3d(-88.349492271490533, -49.982581285067006, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint950, viewCenter950);
    
    NXOpen.Point3d scaleAboutPoint951 = new NXOpen.Point3d(70.679593817193279, 39.986065028052955, 0.0);
    NXOpen.Point3d viewCenter951 = new NXOpen.Point3d(-70.679593817192384, -39.986065028053638, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint951, viewCenter951);
    
    NXOpen.Point3d scaleAboutPoint952 = new NXOpen.Point3d(48.208551639456267, 30.186663176107462, 0.0);
    NXOpen.Point3d viewCenter952 = new NXOpen.Point3d(-48.208551639455351, -30.186663176108212, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint952, viewCenter952);
    
    NXOpen.Point3d scaleAboutPoint953 = new NXOpen.Point3d(63.63979363619805, 42.520393093211169, 0.0);
    NXOpen.Point3d viewCenter953 = new NXOpen.Point3d(-63.639793636197091, -42.520393093212036, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint953, viewCenter953);
    
    NXOpen.Point3d scaleAboutPoint954 = new NXOpen.Point3d(84.125612162894342, 59.13432152036011, 0.0);
    NXOpen.Point3d viewCenter954 = new NXOpen.Point3d(-84.125612162893376, -59.134321520360899, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint954, viewCenter954);
    
    NXOpen.Point3d scaleAboutPoint955 = new NXOpen.Point3d(111.75682787330092, 80.517714570133322, 0.0);
    NXOpen.Point3d viewCenter955 = new NXOpen.Point3d(-111.75682787329997, -80.517714570134132, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint955, viewCenter955);
    
    NXOpen.Point3d scaleAboutPoint956 = new NXOpen.Point3d(148.49578506787003, 108.34692466063039, 0.0);
    NXOpen.Point3d viewCenter956 = new NXOpen.Point3d(-148.49578506786912, -108.34692466063113, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint956, viewCenter956);
    
    NXOpen.Point3d scaleAboutPoint957 = new NXOpen.Point3d(193.86949717194128, 140.93349971719059, 0.0);
    NXOpen.Point3d viewCenter957 = new NXOpen.Point3d(-193.86949717194034, -140.93349971719138, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint957, viewCenter957);
    
    NXOpen.Point3d scaleAboutPoint958 = new NXOpen.Point3d(244.9149232890214, 177.88557586255169, 0.0);
    NXOpen.Point3d viewCenter958 = new NXOpen.Point3d(-244.91492328902041, -177.88557586255254, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint958, viewCenter958);
    
    NXOpen.Point3d scaleAboutPoint959 = new NXOpen.Point3d(245.98911154906108, 134.27353250494522, 0.0);
    NXOpen.Point3d viewCenter959 = new NXOpen.Point3d(-245.98911154906, -134.27353250494613, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint959, viewCenter959);
    
    NXOpen.Point3d scaleAboutPoint960 = new NXOpen.Point3d(429.67530401582673, -38.939324426434709, 0.0);
    NXOpen.Point3d viewCenter960 = new NXOpen.Point3d(-429.67530401582559, 38.939324426433814, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint960, viewCenter960);
    
    NXOpen.Point3d scaleAboutPoint961 = new NXOpen.Point3d(363.07563189337372, -27.928894761029202, 0.0);
    NXOpen.Point3d viewCenter961 = new NXOpen.Point3d(-363.07563189337264, 27.928894761028307, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint961, viewCenter961);
    
    NXOpen.Point3d scaleAboutPoint962 = new NXOpen.Point3d(290.46050551469926, -22.343115808823434, 0.0);
    NXOpen.Point3d viewCenter962 = new NXOpen.Point3d(-290.46050551469784, 22.343115808822503, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint962, viewCenter962);
    
    NXOpen.Point3d scaleAboutPoint963 = new NXOpen.Point3d(232.36840441175968, -17.874492647058865, 0.0);
    NXOpen.Point3d viewCenter963 = new NXOpen.Point3d(-232.36840441175818, 17.874492647057945, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint963, viewCenter963);
    
    NXOpen.Point3d scaleAboutPoint964 = new NXOpen.Point3d(185.8947235294076, -13.749609728506835, 0.0);
    NXOpen.Point3d viewCenter964 = new NXOpen.Point3d(-185.89472352940641, 13.749609728505964, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint964, viewCenter964);
    
    NXOpen.Point3d scaleAboutPoint965 = new NXOpen.Point3d(146.95582877827758, -10.559700271493348, 0.0);
    NXOpen.Point3d viewCenter965 = new NXOpen.Point3d(-146.95582877827619, 10.55970027149254, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint965, viewCenter965);
    
    NXOpen.Point3d scaleAboutPoint966 = new NXOpen.Point3d(112.28481288687567, -7.3917901900455121, 0.0);
    NXOpen.Point3d viewCenter966 = new NXOpen.Point3d(-112.28481288687432, 7.3917901900446896, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint966, viewCenter966);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->复制(C)
    // ----------------------------------------------
    workPart.PmiManager.RestoreUnpastedObjects();
    
    // ----------------------------------------------
    //   菜单：编辑(E)->粘贴(P)
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId326;
    markId326 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder31;
    cutCopyPasteBuilder31 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder31.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder31.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation31 = new NXOpen.Point3d(708.99038935334306, 208.98342926797025, 0.0);
    cutCopyPasteBuilder31.SetDefaultToPoint(droplocation31);
    
    cutCopyPasteBuilder31.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects60 = new NXOpen.TaggedObject[1];
    objects60[0] = note68;
    bool added31;
    added31 = cutCopyPasteBuilder31.ObjectsToCopy.Add(objects60);
    
    NXOpen.Point3d origin245 = new NXOpen.Point3d(708.99038935334306, 208.98342926797025, 0.0);
    NXOpen.Vector3d normal31 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane31;
    plane31 = workPart.Planes.CreatePlane(origin245, normal31, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder31.PlaneToRestrictMotion = plane31;
    
    cutCopyPasteBuilder31.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder31.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder31.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder31.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder31.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder31.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder31.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder31.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder31.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId326, "粘贴 对话框");
    
    cutCopyPasteBuilder31.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder31.Transform.SetMotionToTwoDimensions(plane31);
    
    cutCopyPasteBuilder31.InitPaste();
    
    cutCopyPasteBuilder31.CutCopyPasteLeader.IsLeaderSelection = false;
    
    cutCopyPasteBuilder31.Destroy();
    
    theSession.UndoToMark(markId326, null);
    
    theSession.DeleteUndoMark(markId326, null);
    
    int nErrs232;
    nErrs232 = theSession.UpdateManager.DoUpdate(markId323);
    
    NXOpen.Point3d scaleAboutPoint967 = new NXOpen.Point3d(-67.863673744793871, -12.671640325791943, 0.0);
    NXOpen.Point3d viewCenter967 = new NXOpen.Point3d(67.86367374479542, 12.671640325791143, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint967, viewCenter967);
    
    NXOpen.Point3d scaleAboutPoint968 = new NXOpen.Point3d(-54.290938995834949, -10.137312260633646, 0.0);
    NXOpen.Point3d viewCenter968 = new NXOpen.Point3d(54.290938995836491, 10.13731226063282, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint968, viewCenter968);
    
    NXOpen.Point3d scaleAboutPoint969 = new NXOpen.Point3d(-43.432751196667752, -8.1098498085069952, 0.0);
    NXOpen.Point3d viewCenter969 = new NXOpen.Point3d(43.432751196669393, 8.1098498085061692, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint969, viewCenter969);
    
    NXOpen.Point3d scaleAboutPoint970 = new NXOpen.Point3d(-34.746200957334082, -6.4878798468056793, 0.0);
    NXOpen.Point3d viewCenter970 = new NXOpen.Point3d(34.746200957335638, 6.4878798468048622, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint970, viewCenter970);
    
    NXOpen.Point3d scaleAboutPoint971 = new NXOpen.Point3d(-27.912300852032537, -4.2675831881212192, 0.0);
    NXOpen.Point3d viewCenter971 = new NXOpen.Point3d(27.912300852034122, 4.2675831881203639, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint971, viewCenter971);
    
    NXOpen.Session.UndoMarkId markId327;
    markId327 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note68.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin246 = new NXOpen.Point3d(624.12558690776439, 204.9853634218191, 0.0);
    note68.AnnotationOrigin = origin246;
    
    int nErrs233;
    nErrs233 = theSession.UpdateManager.DoUpdate(markId327);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->复制(C)
    // ----------------------------------------------
    workPart.PmiManager.RestoreUnpastedObjects();
    
    // ----------------------------------------------
    //   菜单：编辑(E)->粘贴(P)
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId328;
    markId328 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder32;
    cutCopyPasteBuilder32 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder32.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder32.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation32 = new NXOpen.Point3d(663.34121620400947, 200.648576181999, 0.0);
    cutCopyPasteBuilder32.SetDefaultToPoint(droplocation32);
    
    cutCopyPasteBuilder32.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects61 = new NXOpen.TaggedObject[1];
    objects61[0] = note68;
    bool added32;
    added32 = cutCopyPasteBuilder32.ObjectsToCopy.Add(objects61);
    
    NXOpen.Point3d origin247 = new NXOpen.Point3d(663.34121620400947, 200.648576181999, 0.0);
    NXOpen.Vector3d normal32 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane32;
    plane32 = workPart.Planes.CreatePlane(origin247, normal32, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder32.PlaneToRestrictMotion = plane32;
    
    cutCopyPasteBuilder32.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder32.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder32.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder32.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder32.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder32.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder32.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder32.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder32.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId328, "粘贴 对话框");
    
    cutCopyPasteBuilder32.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder32.Transform.SetMotionToTwoDimensions(plane32);
    
    cutCopyPasteBuilder32.InitPaste();
    
    cutCopyPasteBuilder32.CutCopyPasteLeader.IsLeaderSelection = false;
    
    NXOpen.Point3d scaleAboutPoint972 = new NXOpen.Point3d(-3.7831548262252008, -13.102633788392939, 0.0);
    NXOpen.Point3d viewCenter972 = new NXOpen.Point3d(3.7831548262268009, 13.102633788392085, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint972, viewCenter972);
    
    NXOpen.Point3d scaleAboutPoint973 = new NXOpen.Point3d(-5.0749637912780017, -17.531693097145354, 0.0);
    NXOpen.Point3d viewCenter973 = new NXOpen.Point3d(5.0749637912795977, 17.531693097144498, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint973, viewCenter973);
    
    NXOpen.Point3d scaleAboutPoint974 = new NXOpen.Point3d(-6.4878798468044732, -22.202966586845147, 0.0);
    NXOpen.Point3d viewCenter974 = new NXOpen.Point3d(6.4878798468060594, 22.20296658684428, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint974, viewCenter974);
    
    NXOpen.Point3d scaleAboutPoint975 = new NXOpen.Point3d(-8.2900686931392631, -28.114146002823297, 0.0);
    NXOpen.Point3d viewCenter975 = new NXOpen.Point3d(8.2900686931408423, 28.114146002822441, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint975, viewCenter975);
    
    NXOpen.Point3d scaleAboutPoint976 = new NXOpen.Point3d(-10.362585866424251, -35.593229715112727, 0.0);
    NXOpen.Point3d viewCenter976 = new NXOpen.Point3d(10.362585866425903, 35.593229715111846, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint976, viewCenter976);
    
    NXOpen.Point3d scaleAboutPoint977 = new NXOpen.Point3d(-12.953232333030543, -44.773129151130604, 0.0);
    NXOpen.Point3d viewCenter977 = new NXOpen.Point3d(12.95323233303214, 44.773129151129666, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint977, viewCenter977);
    
    NXOpen.Point3d scaleAboutPoint978 = new NXOpen.Point3d(-16.543530425338091, -56.670391457012649, 0.0);
    NXOpen.Point3d viewCenter978 = new NXOpen.Point3d(16.543530425339704, 56.670391457011732, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint978, viewCenter978);
    
    NXOpen.Point3d scaleAboutPoint979 = new NXOpen.Point3d(-21.119400542985098, -71.717964343890102, 0.0);
    NXOpen.Point3d viewCenter979 = new NXOpen.Point3d(21.119400542986714, 71.717964343889236, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint979, viewCenter979);
    
    NXOpen.Point3d scaleAboutPoint980 = new NXOpen.Point3d(-26.399250678731597, -89.647455429862489, 0.0);
    NXOpen.Point3d viewCenter980 = new NXOpen.Point3d(26.399250678733111, 89.647455429861665, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint980, viewCenter980);
    
    NXOpen.Point3d scaleAboutPoint981 = new NXOpen.Point3d(-32.999063348414886, -112.74679977375327, 0.0);
    NXOpen.Point3d viewCenter981 = new NXOpen.Point3d(32.999063348416151, 112.74679977375246, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint981, viewCenter981);
    
    NXOpen.Point3d scaleAboutPoint982 = new NXOpen.Point3d(-38.670777361423696, 171.01077099829851, 0.0);
    NXOpen.Point3d viewCenter982 = new NXOpen.Point3d(38.670777361424911, -171.01077099829928, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint982, viewCenter982);
    
    NXOpen.Point3d scaleAboutPoint983 = new NXOpen.Point3d(-49.412659961819266, 218.06021678803151, 0.0);
    NXOpen.Point3d viewCenter983 = new NXOpen.Point3d(49.412659961820516, -218.06021678803233, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint983, viewCenter983);
    
    NXOpen.Point3d scaleAboutPoint984 = new NXOpen.Point3d(-39.5301279694554, 175.30752403845682, 0.0);
    NXOpen.Point3d viewCenter984 = new NXOpen.Point3d(39.530127969456544, -175.30752403845753, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint984, viewCenter984);
    
    NXOpen.Point3d scaleAboutPoint985 = new NXOpen.Point3d(-31.624102375564206, 140.24601923076546, 0.0);
    NXOpen.Point3d viewCenter985 = new NXOpen.Point3d(31.624102375565354, -140.24601923076608, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint985, viewCenter985);
    
    NXOpen.Point3d scaleAboutPoint986 = new NXOpen.Point3d(-25.299281900451231, 112.19681538461224, 0.0);
    NXOpen.Point3d viewCenter986 = new NXOpen.Point3d(25.299281900452421, -112.19681538461292, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint986, viewCenter986);
    
    NXOpen.Point3d scaleAboutPoint987 = new NXOpen.Point3d(-20.2394255203608, 89.757452307689761, 0.0);
    NXOpen.Point3d viewCenter987 = new NXOpen.Point3d(20.239425520362122, -89.757452307690414, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint987, viewCenter987);
    
    NXOpen.Point3d scaleAboutPoint988 = new NXOpen.Point3d(-16.19154041628855, 71.805961846151703, 0.0);
    NXOpen.Point3d viewCenter988 = new NXOpen.Point3d(16.1915404162899, -71.805961846152414, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint988, viewCenter988);
    
    NXOpen.Point3d scaleAboutPoint989 = new NXOpen.Point3d(-12.953232333030654, 57.444769476921302, 0.0);
    NXOpen.Point3d viewCenter989 = new NXOpen.Point3d(12.953232333032016, -57.444769476921984, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint989, viewCenter989);
    
    NXOpen.Point3d scaleAboutPoint990 = new NXOpen.Point3d(-28.835021541356031, 13.516416347510695, 0.0);
    NXOpen.Point3d viewCenter990 = new NXOpen.Point3d(28.83502154135746, -13.516416347511258, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint990, viewCenter990);
    
    NXOpen.Point3d scaleAboutPoint991 = new NXOpen.Point3d(-23.068017233084696, 8.6505064624067671, 0.0);
    NXOpen.Point3d viewCenter991 = new NXOpen.Point3d(23.068017233086081, -8.6505064624072787, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint991, viewCenter991);
    
    NXOpen.Point3d scaleAboutPoint992 = new NXOpen.Point3d(-18.742764001881195, 5.9111794159778794, 0.0);
    NXOpen.Point3d viewCenter992 = new NXOpen.Point3d(18.742764001882566, -5.9111794159783964, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint992, viewCenter992);
    
    NXOpen.Point3d scaleAboutPoint993 = new NXOpen.Point3d(-15.109551287670243, 4.2675831881205655, 0.0);
    NXOpen.Point3d viewCenter993 = new NXOpen.Point3d(15.109551287671609, -4.2675831881210273, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint993, viewCenter993);
    
    NXOpen.Point3d scaleAboutPoint994 = new NXOpen.Point3d(-12.087641030136071, 3.3217944815641296, 0.0);
    NXOpen.Point3d viewCenter994 = new NXOpen.Point3d(12.087641030137434, -3.3217944815644684, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint994, viewCenter994);
    
    NXOpen.Point3d scaleAboutPoint995 = new NXOpen.Point3d(-9.743930479254594, 2.435982619813656, 0.0);
    NXOpen.Point3d viewCenter995 = new NXOpen.Point3d(9.74393047925596, -2.4359826198139949, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint995, viewCenter995);
    
    NXOpen.Point3d coordinates18 = new NXOpen.Point3d(616.14212803055432, 464.69435278882253, 0.0);
    NXOpen.Point point32;
    point32 = workPart.Points.CreatePoint(coordinates18);
    
    NXOpen.Point3d point33 = new NXOpen.Point3d(616.14212803055432, 464.69435278882253, 0.0);
    cutCopyPasteBuilder32.CutCopyPasteLeader.Selection.SetValue(point32, workPart.Views.WorkView, point33);
    
    NXOpen.Session.UndoMarkId markId329;
    markId329 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "粘贴");
    
    NXOpen.Matrix3x3 rot15 = new NXOpen.Matrix3x3();
    rot15.Xx = 1.0;
    rot15.Xy = 0.0;
    rot15.Xz = 0.0;
    rot15.Yx = 0.0;
    rot15.Yy = 1.0;
    rot15.Yz = 0.0;
    rot15.Zx = 0.0;
    rot15.Zy = 0.0;
    rot15.Zz = 1.0;
    NXOpen.Vector3d trans15 = new NXOpen.Vector3d(-47.199088173455152, 264.04577660682355, 0.0);
    cutCopyPasteBuilder32.CutCopyPasteLeader.SetMoveOnCommit(rot15, trans15);
    
    NXOpen.NXObject nXObject22;
    nXObject22 = cutCopyPasteBuilder32.Commit();
    
    theSession.DeleteUndoMark(markId329, null);
    
    theSession.SetUndoMarkName(markId328, "粘贴");
    
    cutCopyPasteBuilder32.Destroy();
    
    workPart.Points.DeletePoint(point32);
    
    NXOpen.Session.UndoMarkId markId330;
    markId330 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Start");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder33;
    cutCopyPasteBuilder33 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder33.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder33.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation33 = new NXOpen.Point3d(663.34121620400947, 200.648576181999, 0.0);
    cutCopyPasteBuilder33.SetDefaultToPoint(droplocation33);
    
    cutCopyPasteBuilder33.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects62 = new NXOpen.TaggedObject[1];
    objects62[0] = note68;
    bool added33;
    added33 = cutCopyPasteBuilder33.ObjectsToCopy.Add(objects62);
    
    NXOpen.Point3d origin248 = new NXOpen.Point3d(663.34121620400947, 200.648576181999, 0.0);
    NXOpen.Vector3d normal33 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane33;
    plane33 = workPart.Planes.CreatePlane(origin248, normal33, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder33.PlaneToRestrictMotion = plane33;
    
    cutCopyPasteBuilder33.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder33.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder33.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder33.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder33.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder33.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder33.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder33.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder33.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId330, "粘贴 对话框");
    
    cutCopyPasteBuilder33.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder33.Transform.SetMotionToTwoDimensions(plane33);
    
    cutCopyPasteBuilder33.InitPaste();
    
    cutCopyPasteBuilder33.CutCopyPasteLeader.IsLeaderSelection = false;
    
    // ----------------------------------------------
    //   对话开始 粘贴
    // ----------------------------------------------
    NXOpen.Point3d scaleAboutPoint996 = new NXOpen.Point3d(-32.243551767716774, -1.2991907305675388, 0.0);
    NXOpen.Point3d viewCenter996 = new NXOpen.Point3d(32.243551767718131, 1.299190730567199, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint996, viewCenter996);
    
    NXOpen.Point3d scaleAboutPoint997 = new NXOpen.Point3d(-40.304439709646154, -1.4763531029176364, 0.0);
    NXOpen.Point3d viewCenter997 = new NXOpen.Point3d(40.304439709647518, 1.476353102917298, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint997, viewCenter997);
    
    NXOpen.Point3d scaleAboutPoint998 = new NXOpen.Point3d(-50.380549637057861, -1.8454413786470072, 0.0);
    NXOpen.Point3d viewCenter998 = new NXOpen.Point3d(50.380549637059225, 1.8454413786466686, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint998, viewCenter998);
    
    NXOpen.Point3d scaleAboutPoint999 = new NXOpen.Point3d(-62.975687046322534, -2.0761215509778612, 0.0);
    NXOpen.Point3d viewCenter999 = new NXOpen.Point3d(62.975687046323905, 2.0761215509775153, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint999, viewCenter999);
    
    NXOpen.Point3d scaleAboutPoint1000 = new NXOpen.Point3d(-78.575433700196569, -0.72087553853410158, 0.0);
    NXOpen.Point3d viewCenter1000 = new NXOpen.Point3d(78.575433700197891, 0.72087553853375297, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1000, viewCenter1000);
    
    NXOpen.Point3d scaleAboutPoint1001 = new NXOpen.Point3d(23.608673886986537, 2.1626266156015324, 0.0);
    NXOpen.Point3d viewCenter1001 = new NXOpen.Point3d(-23.608673886985212, -2.1626266156019831, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1001, viewCenter1001);
    
    NXOpen.Point3d scaleAboutPoint1002 = new NXOpen.Point3d(18.88693910958926, 1.7301012924812256, 0.0);
    NXOpen.Point3d viewCenter1002 = new NXOpen.Point3d(-18.88693910958813, -1.7301012924815742, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1002, viewCenter1002);
    
    NXOpen.Point3d scaleAboutPoint1003 = new NXOpen.Point3d(15.109551287671533, 1.2687409478196134, 0.0);
    NXOpen.Point3d viewCenter1003 = new NXOpen.Point3d(-15.109551287670397, -1.2687409478197866, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1003, viewCenter1003);
    
    NXOpen.Point3d scaleAboutPoint1004 = new NXOpen.Point3d(11.626280685475624, 0.83044862039101708, 0.0);
    NXOpen.Point3d viewCenter1004 = new NXOpen.Point3d(-11.626280685474486, -0.83044862039112477, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1004, viewCenter1004);
    
    NXOpen.Point3d coordinates19 = new NXOpen.Point3d(729.37056789846463, 464.48449150204453, 0.0);
    NXOpen.Point point34;
    point34 = workPart.Points.CreatePoint(coordinates19);
    
    NXOpen.Point3d point35 = new NXOpen.Point3d(729.37056789846463, 464.48449150204453, 0.0);
    cutCopyPasteBuilder33.CutCopyPasteLeader.Selection.SetValue(point34, workPart.Views.WorkView, point35);
    
    NXOpen.Session.UndoMarkId markId331;
    markId331 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "粘贴");
    
    NXOpen.Matrix3x3 rot16 = new NXOpen.Matrix3x3();
    rot16.Xx = 1.0;
    rot16.Xy = 0.0;
    rot16.Xz = 0.0;
    rot16.Yx = 0.0;
    rot16.Yy = 1.0;
    rot16.Yz = 0.0;
    rot16.Zx = 0.0;
    rot16.Zy = 0.0;
    rot16.Zz = 1.0;
    NXOpen.Vector3d trans16 = new NXOpen.Vector3d(66.029351694455158, 263.8359153200455, 0.0);
    cutCopyPasteBuilder33.CutCopyPasteLeader.SetMoveOnCommit(rot16, trans16);
    
    NXOpen.NXObject nXObject23;
    nXObject23 = cutCopyPasteBuilder33.Commit();
    
    theSession.DeleteUndoMark(markId331, null);
    
    theSession.SetUndoMarkName(markId330, "粘贴");
    
    cutCopyPasteBuilder33.Destroy();
    
    workPart.Points.DeletePoint(point34);
    
    NXOpen.Session.UndoMarkId markId332;
    markId332 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Start");
    
    NXOpen.Drafting.CutCopyPasteBuilder cutCopyPasteBuilder34;
    cutCopyPasteBuilder34 = workPart.DraftingManager.CreateCutCopyPasteBuilder();
    
    cutCopyPasteBuilder34.DestinationView = workPart.Views.WorkView;
    
    cutCopyPasteBuilder34.CutCopyPasteLeader.DestinationView = workPart.Views.WorkView;
    
    NXOpen.Point3d droplocation34 = new NXOpen.Point3d(663.34121620400947, 200.648576181999, 0.0);
    cutCopyPasteBuilder34.SetDefaultToPoint(droplocation34);
    
    cutCopyPasteBuilder34.Originals = NXOpen.Drafting.CutCopyPasteBuilder.TypeOperation.Copy;
    
    NXOpen.TaggedObject[] objects63 = new NXOpen.TaggedObject[1];
    objects63[0] = note68;
    bool added34;
    added34 = cutCopyPasteBuilder34.ObjectsToCopy.Add(objects63);
    
    NXOpen.Point3d origin249 = new NXOpen.Point3d(663.34121620400947, 200.648576181999, 0.0);
    NXOpen.Vector3d normal34 = new NXOpen.Vector3d(0.0, 0.0, 1.0);
    NXOpen.Plane plane34;
    plane34 = workPart.Planes.CreatePlane(origin249, normal34, NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder34.PlaneToRestrictMotion = plane34;
    
    cutCopyPasteBuilder34.Transform.DistanceAngle.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder34.Transform.DistanceAngle.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder34.Transform.AlongCurveAngle.AlongCurve.IsPercentUsed = true;
    
    cutCopyPasteBuilder34.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder34.Transform.AlongCurveAngle.AlongCurve.Expression.SetFormula("0");
    
    cutCopyPasteBuilder34.Transform.OrientXpress.AxisOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Axis.Passive;
    
    cutCopyPasteBuilder34.Transform.OrientXpress.PlaneOption = NXOpen.GeometricUtilities.OrientXpressBuilder.Plane.Passive;
    
    cutCopyPasteBuilder34.Transform.Option = NXOpen.GeometricUtilities.ModlMotion.Options.Distance;
    
    cutCopyPasteBuilder34.PasteType = NXOpen.Drafting.CutCopyPasteBuilder.TypePaste.Tracking;
    
    theSession.SetUndoMarkName(markId332, "粘贴 对话框");
    
    cutCopyPasteBuilder34.Transform.SetUpdateOption(NXOpen.SmartObject.UpdateOption.AfterModeling);
    
    cutCopyPasteBuilder34.Transform.SetMotionToTwoDimensions(plane34);
    
    cutCopyPasteBuilder34.InitPaste();
    
    cutCopyPasteBuilder34.CutCopyPasteLeader.IsLeaderSelection = false;
    
    // ----------------------------------------------
    //   对话开始 粘贴
    // ----------------------------------------------
    cutCopyPasteBuilder34.Destroy();
    
    theSession.UndoToMark(markId332, null);
    
    theSession.DeleteUndoMark(markId332, null);
    
    int nErrs234;
    nErrs234 = theSession.UpdateManager.DoUpdate(markId330);
    
    NXOpen.Point3d scaleAboutPoint1005 = new NXOpen.Point3d(26.131449921639724, 12.401366064506664, 0.0);
    NXOpen.Point3d viewCenter1005 = new NXOpen.Point3d(-26.131449921638591, -12.401366064506774, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1005, viewCenter1005);
    
    NXOpen.Point3d scaleAboutPoint1006 = new NXOpen.Point3d(33.310216884575908, 15.686251718498029, 0.0);
    NXOpen.Point3d viewCenter1006 = new NXOpen.Point3d(-33.310216884574771, -15.686251718498138, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1006, viewCenter1006);
    
    NXOpen.Point3d scaleAboutPoint1007 = new NXOpen.Point3d(42.560491795043148, 19.838494820453384, 0.0);
    NXOpen.Point3d viewCenter1007 = new NXOpen.Point3d(-42.560491795042012, -19.838494820453501, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1007, viewCenter1007);
    
    NXOpen.Point3d scaleAboutPoint1008 = new NXOpen.Point3d(53.48896495921732, 25.086468740980305, 0.0);
    NXOpen.Point3d viewCenter1008 = new NXOpen.Point3d(-53.48896495921619, -25.086468740980422, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1008, viewCenter1008);
    
    NXOpen.Point3d scaleAboutPoint1009 = new NXOpen.Point3d(67.582081737555413, 31.538304810858811, 0.0);
    NXOpen.Point3d viewCenter1009 = new NXOpen.Point3d(-67.582081737554276, -31.538304810859035, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1009, viewCenter1009);
    
    NXOpen.Point3d scaleAboutPoint1010 = new NXOpen.Point3d(84.92814938352781, 40.098701830949025, 0.0);
    NXOpen.Point3d viewCenter1010 = new NXOpen.Point3d(-84.928149383526687, -40.098701830949359, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1010, viewCenter1010);
    
    NXOpen.Point3d scaleAboutPoint1011 = new NXOpen.Point3d(34.917408897737239, -49.560193274207023, 0.0);
    NXOpen.Point3d viewCenter1011 = new NXOpen.Point3d(-34.917408897736109, 49.560193274206696, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1011, viewCenter1011);
    
    NXOpen.Point3d scaleAboutPoint1012 = new NXOpen.Point3d(46.462681194569633, -59.486311529410393, 0.0);
    NXOpen.Point3d viewCenter1012 = new NXOpen.Point3d(-46.462681194568461, 59.486311529410095, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1012, viewCenter1012);
    
    NXOpen.Point3d origin250 = new NXOpen.Point3d(602.4663889528041, 293.30214668733106, 0.0);
    workPart.Views.WorkView.SetOrigin(origin250);
    
    NXOpen.Point3d origin251 = new NXOpen.Point3d(602.4663889528041, 293.30214668733106, 0.0);
    workPart.Views.WorkView.SetOrigin(origin251);
    
    NXOpen.Point3d scaleAboutPoint1013 = new NXOpen.Point3d(27.719213212669523, -121.43655312216893, 0.0);
    NXOpen.Point3d viewCenter1013 = new NXOpen.Point3d(-27.719213212668421, 121.4365531221686, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1013, viewCenter1013);
    
    NXOpen.Point3d scaleAboutPoint1014 = new NXOpen.Point3d(22.175370570135829, -96.445262479635716, 0.0);
    NXOpen.Point3d viewCenter1014 = new NXOpen.Point3d(-22.175370570134657, 96.44526247963536, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1014, viewCenter1014);
    
    NXOpen.Point3d scaleAboutPoint1015 = new NXOpen.Point3d(17.740296456108709, -76.874617976468755, 0.0);
    NXOpen.Point3d viewCenter1015 = new NXOpen.Point3d(-17.740296456107579, 76.874617976468443, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1015, viewCenter1015);
    
    NXOpen.Point3d scaleAboutPoint1016 = new NXOpen.Point3d(14.417510770678948, -61.499694381175054, 0.0);
    NXOpen.Point3d viewCenter1016 = new NXOpen.Point3d(-14.41751077067782, 61.499694381174734, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1016, viewCenter1016);
    
    NXOpen.Session.UndoMarkId markId333;
    markId333 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note68.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin252 = new NXOpen.Point3d(619.59774269325624, 204.38947040136196, 0.0);
    note68.AnnotationOrigin = origin252;
    
    int nErrs235;
    nErrs235 = theSession.UpdateManager.DoUpdate(markId333);
    
    NXOpen.Point3d scaleAboutPoint1017 = new NXOpen.Point3d(32.078961464759928, -17.120794040180719, 0.0);
    NXOpen.Point3d viewCenter1017 = new NXOpen.Point3d(-32.078961464758784, 17.120794040180375, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1017, viewCenter1017);
    
    NXOpen.Point3d scaleAboutPoint1018 = new NXOpen.Point3d(25.66316917180805, -13.696635232144606, 0.0);
    NXOpen.Point3d viewCenter1018 = new NXOpen.Point3d(-25.663169171806921, 13.696635232144269, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1018, viewCenter1018);
    
    NXOpen.Point3d scaleAboutPoint1019 = new NXOpen.Point3d(20.41519525128113, -10.957308185715723, 0.0);
    NXOpen.Point3d viewCenter1019 = new NXOpen.Point3d(-20.415195251280004, 10.957308185715377, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1019, viewCenter1019);
    
    NXOpen.Point3d scaleAboutPoint1020 = new NXOpen.Point3d(16.332156201025025, -8.7658465485726111, 0.0);
    NXOpen.Point3d viewCenter1020 = new NXOpen.Point3d(-16.332156201023885, 8.7658465485722736, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1020, viewCenter1020);
    
    NXOpen.Point3d scaleAboutPoint1021 = new NXOpen.Point3d(13.065724960820116, -7.0126772388581227, 0.0);
    NXOpen.Point3d viewCenter1021 = new NXOpen.Point3d(-13.065724960818972, 7.0126772388577843, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1021, viewCenter1021);
    
    NXOpen.Point3d scaleAboutPoint1022 = new NXOpen.Point3d(10.452579968656202, -5.610141791086523, 0.0);
    NXOpen.Point3d viewCenter1022 = new NXOpen.Point3d(-10.452579968655069, 5.6101417910861828, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1022, viewCenter1022);
    
    NXOpen.Point3d scaleAboutPoint1023 = new NXOpen.Point3d(8.3620639749250696, -4.4881134328692482, 0.0);
    NXOpen.Point3d viewCenter1023 = new NXOpen.Point3d(-8.3620639749239309, 4.4881134328689054, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1023, viewCenter1023);
    
    NXOpen.Point3d scaleAboutPoint1024 = new NXOpen.Point3d(6.6518565405054684, -3.5904907462954272, 0.0);
    NXOpen.Point3d viewCenter1024 = new NXOpen.Point3d(-6.6518565405043315, 3.590490746295087, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1024, viewCenter1024);
    
    NXOpen.Point3d scaleAboutPoint1025 = new NXOpen.Point3d(-2.2374426545328969, -2.8119211739408789, 0.0);
    NXOpen.Point3d viewCenter1025 = new NXOpen.Point3d(2.2374426545340365, 2.8119211739405388, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1025, viewCenter1025);
    
    NXOpen.Session.UndoMarkId markId334;
    markId334 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note68.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    note68.InsertIntoStack(note71, NXOpen.Annotations.StackAlignmentPosition.Below);
    
    int nErrs236;
    nErrs236 = theSession.UpdateManager.DoUpdate(markId334);
    
    NXOpen.Point3d scaleAboutPoint1026 = new NXOpen.Point3d(-0.26456247604223748, -7.2187761320253738, 0.0);
    NXOpen.Point3d viewCenter1026 = new NXOpen.Point3d(0.26456247604337507, 7.2187761320250337, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1026, viewCenter1026);
    
    NXOpen.Point3d scaleAboutPoint1027 = new NXOpen.Point3d(-0.3307030950529381, -9.0707134643250171, 0.0);
    NXOpen.Point3d viewCenter1027 = new NXOpen.Point3d(0.33070309505407652, 9.0707134643246743, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1027, viewCenter1027);
    
    NXOpen.Point3d scaleAboutPoint1028 = new NXOpen.Point3d(-0.41337886881632008, -11.397445954522917, 0.0);
    NXOpen.Point3d viewCenter1028 = new NXOpen.Point3d(0.41337886881745256, 11.397445954522578, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1028, viewCenter1028);
    
    NXOpen.Point3d scaleAboutPoint1029 = new NXOpen.Point3d(-0.51672358602053559, -14.246807443153612, 0.0);
    NXOpen.Point3d viewCenter1029 = new NXOpen.Point3d(0.51672358602167423, 14.246807443153273, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1029, viewCenter1029);
    
    NXOpen.Point3d scaleAboutPoint1030 = new NXOpen.Point3d(-0.64590448252581556, -17.808509303941968, 0.0);
    NXOpen.Point3d viewCenter1030 = new NXOpen.Point3d(0.6459044825269542, 17.808509303941626, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1030, viewCenter1030);
    
    NXOpen.Point3d scaleAboutPoint1031 = new NXOpen.Point3d(-0.80738060315741345, -22.260636629927411, 0.0);
    NXOpen.Point3d viewCenter1031 = new NXOpen.Point3d(0.8073806031585482, 22.260636629927067, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1031, viewCenter1031);
    
    NXOpen.Point3d scaleAboutPoint1032 = new NXOpen.Point3d(-1.0092257539469114, -27.825795787409223, 0.0);
    NXOpen.Point3d viewCenter1032 = new NXOpen.Point3d(1.0092257539480414, 27.825795787408886, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1032, viewCenter1032);
    
    NXOpen.Point3d scaleAboutPoint1033 = new NXOpen.Point3d(-1.2615321924337743, -34.782244734261468, 0.0);
    NXOpen.Point3d viewCenter1033 = new NXOpen.Point3d(1.2615321924349163, 34.782244734261141, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1033, viewCenter1033);
    
    NXOpen.Point3d scaleAboutPoint1034 = new NXOpen.Point3d(27.032832695022343, -24.780096637103409, 0.0);
    NXOpen.Point3d viewCenter1034 = new NXOpen.Point3d(-27.032832695021217, 24.780096637103163, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1034, viewCenter1034);
    
    NXOpen.Point3d scaleAboutPoint1035 = new NXOpen.Point3d(34.917408897737012, -30.693528789139457, 0.0);
    NXOpen.Point3d viewCenter1035 = new NXOpen.Point3d(-34.917408897735889, 30.693528789139151, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1035, viewCenter1035);
    
    NXOpen.Point3d scaleAboutPoint1036 = new NXOpen.Point3d(45.054721158370214, -38.01492097737448, 0.0);
    NXOpen.Point3d viewCenter1036 = new NXOpen.Point3d(-45.054721158369013, 38.014920977374189, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1036, viewCenter1036);
    
    NXOpen.Point3d scaleAboutPoint1037 = new NXOpen.Point3d(92.837364886875505, -45.318713665157077, 0.0);
    NXOpen.Point3d viewCenter1037 = new NXOpen.Point3d(-92.837364886874283, 45.318713665156821, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1037, viewCenter1037);
    
    NXOpen.Point3d scaleAboutPoint1038 = new NXOpen.Point3d(118.79662805429534, -60.498282805427955, 0.0);
    NXOpen.Point3d viewCenter1038 = new NXOpen.Point3d(-118.79662805429433, 60.49828280542777, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1038, viewCenter1038);
    
    NXOpen.Point3d scaleAboutPoint1039 = new NXOpen.Point3d(153.99562895927144, -83.872619343888729, 0.0);
    NXOpen.Point3d viewCenter1039 = new NXOpen.Point3d(-153.99562895927062, 83.872619343888559, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1039, viewCenter1039);
    
    NXOpen.Point3d scaleAboutPoint1040 = new NXOpen.Point3d(199.36934106334235, 226.86856052035444, 0.0);
    NXOpen.Point3d viewCenter1040 = new NXOpen.Point3d(-199.36934106334149, -226.86856052035463, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1040, viewCenter1040);
    
    NXOpen.Point3d scaleAboutPoint1041 = new NXOpen.Point3d(159.49547285067399, 181.49484841628347, 0.0);
    NXOpen.Point3d viewCenter1041 = new NXOpen.Point3d(-159.49547285067308, -181.49484841628376, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1041, viewCenter1041);
    
    NXOpen.Point3d scaleAboutPoint1042 = new NXOpen.Point3d(127.59637828053923, 145.74586312216707, 0.0);
    NXOpen.Point3d viewCenter1042 = new NXOpen.Point3d(-127.5963782805384, -145.74586312216729, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1042, viewCenter1042);
    
    NXOpen.Point3d scaleAboutPoint1043 = new NXOpen.Point3d(102.07710262443156, 116.59669049773369, 0.0);
    NXOpen.Point3d viewCenter1043 = new NXOpen.Point3d(-102.07710262443064, -116.59669049773386, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1043, viewCenter1043);
    
    NXOpen.Point3d scaleAboutPoint1044 = new NXOpen.Point3d(81.661682099545402, 93.277352398186864, 0.0);
    NXOpen.Point3d viewCenter1044 = new NXOpen.Point3d(-81.661682099544393, -93.277352398187148, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1044, viewCenter1044);
    
    NXOpen.Point3d scaleAboutPoint1045 = new NXOpen.Point3d(65.329345679636333, 74.621881918549519, 0.0);
    NXOpen.Point3d viewCenter1045 = new NXOpen.Point3d(-65.329345679635438, -74.621881918549676, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1045, viewCenter1045);
    
    NXOpen.Point3d scaleAboutPoint1046 = new NXOpen.Point3d(52.263476543709139, 59.697505534839543, 0.0);
    NXOpen.Point3d viewCenter1046 = new NXOpen.Point3d(-52.263476543708236, -59.69750553483977, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1046, viewCenter1046);
    
    NXOpen.Point3d scaleAboutPoint1047 = new NXOpen.Point3d(41.810781234967394, 47.758004427871583, 0.0);
    NXOpen.Point3d viewCenter1047 = new NXOpen.Point3d(-41.810781234966491, -47.758004427871867, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1047, viewCenter1047);
    
    NXOpen.Point3d scaleAboutPoint1048 = new NXOpen.Point3d(24.798118525567059, 24.653943417859686, 0.0);
    NXOpen.Point3d viewCenter1048 = new NXOpen.Point3d(-24.798118525566142, -24.653943417859917, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1048, viewCenter1048);
    
    NXOpen.Point3d scaleAboutPoint1049 = new NXOpen.Point3d(120.74665270443083, -14.41751077067835, 0.0);
    NXOpen.Point3d viewCenter1049 = new NXOpen.Point3d(-120.74665270442993, 14.41751077067817, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1049, viewCenter1049);
    
    NXOpen.Session.UndoMarkId markId335;
    markId335 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note7.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Annotation.AssociativeOriginData assocOrigin5 = new NXOpen.Annotations.Annotation.AssociativeOriginData();
    assocOrigin5.OriginType = NXOpen.Annotations.AssociativeOriginType.HorizontallyAligned;
    assocOrigin5.View = nullNXOpen_View;
    assocOrigin5.ViewOfGeometry = nullNXOpen_View;
    assocOrigin5.PointOnGeometry = nullNXOpen_Point;
    assocOrigin5.VertAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin5.VertAlignmentPosition = NXOpen.Annotations.AlignmentPosition.TopLeft;
    assocOrigin5.HorizAnnotation = note8;
    assocOrigin5.HorizAlignmentPosition = NXOpen.Annotations.AlignmentPosition.BottomCenter;
    assocOrigin5.AlignedAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin5.DimensionLine = 0;
    assocOrigin5.AssociatedView = nullNXOpen_View;
    assocOrigin5.AssociatedPoint = nullNXOpen_Point;
    assocOrigin5.OffsetAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin5.OffsetAlignmentPosition = NXOpen.Annotations.AlignmentPosition.TopLeft;
    assocOrigin5.XOffsetFactor = 0.0;
    assocOrigin5.YOffsetFactor = 0.0;
    assocOrigin5.StackAlignmentPosition = NXOpen.Annotations.StackAlignmentPosition.Above;
    NXOpen.Point3d origin253 = new NXOpen.Point3d(622.91029587368394, 458.16440200805664, 0.0);
    note7.SetAssociativeOrigin(assocOrigin5, origin253);
    
    int nErrs237;
    nErrs237 = theSession.UpdateManager.DoUpdate(markId335);
    
    // ----------------------------------------------
    //   菜单：编辑(E)->撤消
    // ----------------------------------------------
    bool marksRecycled11;
    bool undoUnavailable11;
    theSession.UndoLastNVisibleMarks(1, out marksRecycled11, out undoUnavailable11);
    
    NXOpen.Session.UndoMarkId markId336;
    markId336 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Annotations.Note note75 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 2 1"));
    NXOpen.Annotations.DraftingNoteBuilder draftingNoteBuilder9;
    draftingNoteBuilder9 = workPart.Annotations.CreateDraftingNoteBuilder(note75);
    
    draftingNoteBuilder9.Text.TextBlock.CustomSymbolScale = 1.0;
    
    draftingNoteBuilder9.Origin.SetInferRelativeToGeometry(true);
    
    theSession.SetUndoMarkName(markId336, "注释 对话框");
    
    draftingNoteBuilder9.Origin.SetInferRelativeToGeometry(true);
    
    NXOpen.Annotations.LeaderData leaderData10;
    leaderData10 = workPart.Annotations.CreateLeaderData();
    
    leaderData10.StubSize = 3.5000000103999995;
    
    leaderData10.Arrowhead = NXOpen.Annotations.LeaderData.ArrowheadType.FilledArrow;
    
    leaderData10.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Center;
    
    draftingNoteBuilder9.Leader.Leaders.Append(leaderData10);
    
    leaderData10.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Legacy;
    
    leaderData10.StubSide = NXOpen.Annotations.LeaderSide.Inferred;
    
    double symbolscale9;
    symbolscale9 = draftingNoteBuilder9.Text.TextBlock.SymbolScale;
    
    double symbolaspectratio9;
    symbolaspectratio9 = draftingNoteBuilder9.Text.TextBlock.SymbolAspectRatio;
    
    draftingNoteBuilder9.Origin.SetInferRelativeToGeometry(true);
    
    draftingNoteBuilder9.Origin.SetInferRelativeToGeometry(true);
    
    NXOpen.Session.UndoMarkId markId337;
    markId337 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.DeleteUndoMark(markId337, null);
    
    NXOpen.Session.UndoMarkId markId338;
    markId338 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId338, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId338, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId336, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId339;
    markId339 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId339, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId339, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId336, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId340;
    markId340 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    string[] text6 = new string[1];
    text6[0] = "<F34><C1.3>截面图<C><F>";
    draftingNoteBuilder9.Text.TextBlock.SetText(text6);
    
    theSession.SetUndoMarkName(markId340, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId340, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId336, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId341;
    markId341 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    NXOpen.Session.UndoMarkId markId342;
    markId342 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    NXOpen.NXObject nXObject24;
    nXObject24 = draftingNoteBuilder9.Commit();
    
    theSession.DeleteUndoMark(markId342, null);
    
    theSession.SetUndoMarkName(markId336, "注释");
    
    draftingNoteBuilder9.Destroy();
    
    theSession.DeleteUndoMark(markId341, null);
    
    theSession.SetUndoMarkVisibility(markId336, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.DeleteUndoMark(markId340, null);
    
    theSession.DeleteUndoMark(markId339, null);
    
    theSession.DeleteUndoMark(markId338, null);
    
    NXOpen.Session.UndoMarkId markId343;
    markId343 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note76 = ((NXOpen.Annotations.Note)nXObject24);
    note76.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Annotation.AssociativeOriginData assocOrigin6 = new NXOpen.Annotations.Annotation.AssociativeOriginData();
    assocOrigin6.OriginType = NXOpen.Annotations.AssociativeOriginType.RelativeToView;
    assocOrigin6.View = sectionView2;
    assocOrigin6.ViewOfGeometry = nullNXOpen_View;
    assocOrigin6.PointOnGeometry = nullNXOpen_Point;
    assocOrigin6.VertAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin6.VertAlignmentPosition = NXOpen.Annotations.AlignmentPosition.TopLeft;
    assocOrigin6.HorizAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin6.HorizAlignmentPosition = NXOpen.Annotations.AlignmentPosition.TopLeft;
    assocOrigin6.AlignedAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin6.DimensionLine = 0;
    assocOrigin6.AssociatedView = nullNXOpen_View;
    assocOrigin6.AssociatedPoint = nullNXOpen_Point;
    assocOrigin6.OffsetAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin6.OffsetAlignmentPosition = NXOpen.Annotations.AlignmentPosition.TopLeft;
    assocOrigin6.XOffsetFactor = 0.0;
    assocOrigin6.YOffsetFactor = 0.0;
    assocOrigin6.StackAlignmentPosition = NXOpen.Annotations.StackAlignmentPosition.Above;
    NXOpen.Point3d origin254 = new NXOpen.Point3d(619.30591773986816, 464.03456497192383, 0.0);
    note76.SetAssociativeOrigin(assocOrigin6, origin254);
    
    int nErrs238;
    nErrs238 = theSession.UpdateManager.DoUpdate(markId343);
    
    NXOpen.Session.UndoMarkId markId344;
    markId344 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Annotations.Note note77 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 1 1"));
    NXOpen.Annotations.DraftingNoteBuilder draftingNoteBuilder10;
    draftingNoteBuilder10 = workPart.Annotations.CreateDraftingNoteBuilder(note77);
    
    draftingNoteBuilder10.Text.TextBlock.CustomSymbolScale = 1.0;
    
    draftingNoteBuilder10.Origin.SetInferRelativeToGeometry(true);
    
    theSession.SetUndoMarkName(markId344, "注释 对话框");
    
    draftingNoteBuilder10.Origin.SetInferRelativeToGeometry(true);
    
    NXOpen.Annotations.LeaderData leaderData11;
    leaderData11 = workPart.Annotations.CreateLeaderData();
    
    leaderData11.StubSize = 3.5000000103999995;
    
    leaderData11.Arrowhead = NXOpen.Annotations.LeaderData.ArrowheadType.FilledArrow;
    
    leaderData11.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Center;
    
    draftingNoteBuilder10.Leader.Leaders.Append(leaderData11);
    
    leaderData11.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Legacy;
    
    leaderData11.StubSide = NXOpen.Annotations.LeaderSide.Inferred;
    
    double symbolscale10;
    symbolscale10 = draftingNoteBuilder10.Text.TextBlock.SymbolScale;
    
    double symbolaspectratio10;
    symbolaspectratio10 = draftingNoteBuilder10.Text.TextBlock.SymbolAspectRatio;
    
    draftingNoteBuilder10.Origin.SetInferRelativeToGeometry(true);
    
    draftingNoteBuilder10.Origin.SetInferRelativeToGeometry(true);
    
    // ----------------------------------------------
    //   对话开始 注释
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId345;
    markId345 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.DeleteUndoMark(markId345, null);
    
    NXOpen.Session.UndoMarkId markId346;
    markId346 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId346, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId346, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId344, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId347;
    markId347 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId347, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId347, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId344, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId348;
    markId348 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    string[] text7 = new string[1];
    text7[0] = "<F34><C1.3>截面图<C><F>";
    draftingNoteBuilder10.Text.TextBlock.SetText(text7);
    
    theSession.SetUndoMarkName(markId348, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId348, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId344, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId349;
    markId349 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    NXOpen.Session.UndoMarkId markId350;
    markId350 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    NXOpen.NXObject nXObject25;
    nXObject25 = draftingNoteBuilder10.Commit();
    
    theSession.DeleteUndoMark(markId350, null);
    
    theSession.SetUndoMarkName(markId344, "注释");
    
    draftingNoteBuilder10.Destroy();
    
    theSession.DeleteUndoMark(markId349, null);
    
    theSession.SetUndoMarkVisibility(markId344, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.DeleteUndoMark(markId348, null);
    
    theSession.DeleteUndoMark(markId347, null);
    
    theSession.DeleteUndoMark(markId346, null);
    
    NXOpen.Point3d scaleAboutPoint1050 = new NXOpen.Point3d(60.148052746423794, -54.516212601627188, 0.0);
    NXOpen.Point3d viewCenter1050 = new NXOpen.Point3d(-60.148052746422891, 54.516212601627139, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1050, viewCenter1050);
    
    NXOpen.Point3d scaleAboutPoint1051 = new NXOpen.Point3d(48.839317735673049, -45.415158927636561, 0.0);
    NXOpen.Point3d viewCenter1051 = new NXOpen.Point3d(-48.839317735672147, 45.41515892763644, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1051, viewCenter1051);
    
    NXOpen.Point3d scaleAboutPoint1052 = new NXOpen.Point3d(40.080679942486, -36.620477357522752, 0.0);
    NXOpen.Point3d viewCenter1052 = new NXOpen.Point3d(-40.080679942485091, 36.620477357522752, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1052, viewCenter1052);
    
    NXOpen.Point3d scaleAboutPoint1053 = new NXOpen.Point3d(32.756584470981416, -29.181041799852764, 0.0);
    NXOpen.Point3d viewCenter1053 = new NXOpen.Point3d(-32.756584470980513, 29.181041799852764, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1053, viewCenter1053);
    
    NXOpen.Point3d scaleAboutPoint1054 = new NXOpen.Point3d(26.297539645717574, -23.252561370949874, 0.0);
    NXOpen.Point3d viewCenter1054 = new NXOpen.Point3d(-26.297539645716665, 23.252561370949874, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1054, viewCenter1054);
    
    NXOpen.Session.UndoMarkId markId351;
    markId351 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note78 = ((NXOpen.Annotations.Note)nXObject25);
    note78.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin255 = new NXOpen.Point3d(732.16864347071498, 463.71817441541521, 0.0);
    note78.AnnotationOrigin = origin255;
    
    int nErrs239;
    nErrs239 = theSession.UpdateManager.DoUpdate(markId351);
    
    NXOpen.Session.UndoMarkId markId352;
    markId352 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note5.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Annotation.AssociativeOriginData assocOrigin7 = new NXOpen.Annotations.Annotation.AssociativeOriginData();
    assocOrigin7.OriginType = NXOpen.Annotations.AssociativeOriginType.HorizontallyAligned;
    assocOrigin7.View = nullNXOpen_View;
    assocOrigin7.ViewOfGeometry = nullNXOpen_View;
    assocOrigin7.PointOnGeometry = nullNXOpen_Point;
    assocOrigin7.VertAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin7.VertAlignmentPosition = NXOpen.Annotations.AlignmentPosition.TopLeft;
    assocOrigin7.HorizAnnotation = note6;
    assocOrigin7.HorizAlignmentPosition = NXOpen.Annotations.AlignmentPosition.BottomCenter;
    assocOrigin7.AlignedAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin7.DimensionLine = 0;
    assocOrigin7.AssociatedView = nullNXOpen_View;
    assocOrigin7.AssociatedPoint = nullNXOpen_Point;
    assocOrigin7.OffsetAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin7.OffsetAlignmentPosition = NXOpen.Annotations.AlignmentPosition.TopLeft;
    assocOrigin7.XOffsetFactor = 0.0;
    assocOrigin7.YOffsetFactor = 0.0;
    assocOrigin7.StackAlignmentPosition = NXOpen.Annotations.StackAlignmentPosition.Above;
    NXOpen.Point3d origin256 = new NXOpen.Point3d(732.8330023670278, 458.16604995727539, 0.0);
    note5.SetAssociativeOrigin(assocOrigin7, origin256);
    
    int nErrs240;
    nErrs240 = theSession.UpdateManager.DoUpdate(markId352);
    
    NXOpen.Point3d scaleAboutPoint1055 = new NXOpen.Point3d(54.47742949765442, -4.2076063433147386, 0.0);
    NXOpen.Point3d viewCenter1055 = new NXOpen.Point3d(-54.47742949765351, 4.2076063433147386, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1055, viewCenter1055);
    
    NXOpen.Point3d scaleAboutPoint1056 = new NXOpen.Point3d(-18.177597579670671, -14.4867148223775, 0.0);
    NXOpen.Point3d viewCenter1056 = new NXOpen.Point3d(18.177597579671581, 14.4867148223775, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1056, viewCenter1056);
    
    NXOpen.Point3d scaleAboutPoint1057 = new NXOpen.Point3d(-16.724312493986304, -17.07033275248304, 0.0);
    NXOpen.Point3d viewCenter1057 = new NXOpen.Point3d(16.72431249398721, 17.07033275248304, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1057, viewCenter1057);
    
    NXOpen.Point3d scaleAboutPoint1058 = new NXOpen.Point3d(-51.182163235907275, -25.518994064100475, 0.0);
    NXOpen.Point3d viewCenter1058 = new NXOpen.Point3d(51.182163235908192, 25.518994064100475, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1058, viewCenter1058);
    
    NXOpen.Session.UndoMarkId markId353;
    markId353 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    note7.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Annotation.AssociativeOriginData assocOrigin8 = new NXOpen.Annotations.Annotation.AssociativeOriginData();
    assocOrigin8.OriginType = NXOpen.Annotations.AssociativeOriginType.HorizontallyAligned;
    assocOrigin8.View = nullNXOpen_View;
    assocOrigin8.ViewOfGeometry = nullNXOpen_View;
    assocOrigin8.PointOnGeometry = nullNXOpen_Point;
    assocOrigin8.VertAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin8.VertAlignmentPosition = NXOpen.Annotations.AlignmentPosition.TopLeft;
    assocOrigin8.HorizAnnotation = note8;
    assocOrigin8.HorizAlignmentPosition = NXOpen.Annotations.AlignmentPosition.BottomCenter;
    assocOrigin8.AlignedAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin8.DimensionLine = 0;
    assocOrigin8.AssociatedView = nullNXOpen_View;
    assocOrigin8.AssociatedPoint = nullNXOpen_Point;
    assocOrigin8.OffsetAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin8.OffsetAlignmentPosition = NXOpen.Annotations.AlignmentPosition.TopLeft;
    assocOrigin8.XOffsetFactor = 0.0;
    assocOrigin8.YOffsetFactor = 0.0;
    assocOrigin8.StackAlignmentPosition = NXOpen.Annotations.StackAlignmentPosition.Above;
    NXOpen.Point3d origin257 = new NXOpen.Point3d(619.58720381615069, 458.16440200805664, 0.0);
    note7.SetAssociativeOrigin(assocOrigin8, origin257);
    
    int nErrs241;
    nErrs241 = theSession.UpdateManager.DoUpdate(markId353);
    
    NXOpen.Point3d scaleAboutPoint1059 = new NXOpen.Point3d(32.619618118659943, 2.3428455002352098, 0.0);
    NXOpen.Point3d viewCenter1059 = new NXOpen.Point3d(-32.619618118659083, -2.3428455002352098, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1059, viewCenter1059);
    
    NXOpen.Point3d scaleAboutPoint1060 = new NXOpen.Point3d(48.208551639455763, 4.9560193274206084, 0.0);
    NXOpen.Point3d viewCenter1060 = new NXOpen.Point3d(-48.208551639454868, -4.9560193274206643, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1060, viewCenter1060);
    
    NXOpen.Point3d scaleAboutPoint1061 = new NXOpen.Point3d(68.145265752034319, 8.4477602171942969, 0.0);
    NXOpen.Point3d viewCenter1061 = new NXOpen.Point3d(-68.145265752033424, -8.4477602171942276, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1061, viewCenter1061);
    
    NXOpen.Point3d scaleAboutPoint1062 = new NXOpen.Point3d(114.04476293212309, -65.470141683255562, 0.0);
    NXOpen.Point3d viewCenter1062 = new NXOpen.Point3d(-114.04476293212221, 65.47014168325569, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1062, viewCenter1062);
    
    NXOpen.Point3d scaleAboutPoint1063 = new NXOpen.Point3d(91.235810345698553, -51.531337324885058, 0.0);
    NXOpen.Point3d viewCenter1063 = new NXOpen.Point3d(-91.235810345697871, 51.531337324885129, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1063, viewCenter1063);
    
    NXOpen.Point3d scaleAboutPoint1064 = new NXOpen.Point3d(73.213921882350704, -40.549249042532466, 0.0);
    NXOpen.Point3d viewCenter1064 = new NXOpen.Point3d(-73.213921882350036, 40.54924904253258, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1064, viewCenter1064);
    
    NXOpen.Point3d scaleAboutPoint1065 = new NXOpen.Point3d(59.652450813681533, -30.997648156958132, 0.0);
    NXOpen.Point3d viewCenter1065 = new NXOpen.Point3d(-59.652450813680858, 30.997648156958249, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1065, viewCenter1065);
    
    NXOpen.Session.UndoMarkId markId354;
    markId354 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note79 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 10 1"));
    note79.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Annotations.Annotation.AssociativeOriginData assocOrigin9 = new NXOpen.Annotations.Annotation.AssociativeOriginData();
    assocOrigin9.OriginType = NXOpen.Annotations.AssociativeOriginType.RelativeToView;
    assocOrigin9.View = projectedView1;
    assocOrigin9.ViewOfGeometry = nullNXOpen_View;
    assocOrigin9.PointOnGeometry = nullNXOpen_Point;
    assocOrigin9.VertAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin9.VertAlignmentPosition = NXOpen.Annotations.AlignmentPosition.TopLeft;
    assocOrigin9.HorizAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin9.HorizAlignmentPosition = NXOpen.Annotations.AlignmentPosition.TopLeft;
    assocOrigin9.AlignedAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin9.DimensionLine = 0;
    assocOrigin9.AssociatedView = nullNXOpen_View;
    assocOrigin9.AssociatedPoint = nullNXOpen_Point;
    assocOrigin9.OffsetAnnotation = nullNXOpen_Annotations_Annotation;
    assocOrigin9.OffsetAlignmentPosition = NXOpen.Annotations.AlignmentPosition.TopLeft;
    assocOrigin9.XOffsetFactor = 0.0;
    assocOrigin9.YOffsetFactor = 0.0;
    assocOrigin9.StackAlignmentPosition = NXOpen.Annotations.StackAlignmentPosition.Above;
    NXOpen.Point3d origin258 = new NXOpen.Point3d(788.81386375427246, 426.88181304931641, 0.0);
    note79.SetAssociativeOrigin(assocOrigin9, origin258);
    
    int nErrs242;
    nErrs242 = theSession.UpdateManager.DoUpdate(markId354);
    
    NXOpen.Session.UndoMarkId markId355;
    markId355 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Annotations.DraftingNoteBuilder draftingNoteBuilder11;
    draftingNoteBuilder11 = workPart.Annotations.CreateDraftingNoteBuilder(note79);
    
    draftingNoteBuilder11.Text.TextBlock.CustomSymbolScale = 1.0;
    
    draftingNoteBuilder11.Origin.SetInferRelativeToGeometry(true);
    
    theSession.SetUndoMarkName(markId355, "注释 对话框");
    
    draftingNoteBuilder11.Origin.SetInferRelativeToGeometry(true);
    
    NXOpen.Annotations.LeaderData leaderData12;
    leaderData12 = workPart.Annotations.CreateLeaderData();
    
    leaderData12.StubSize = 3.5000000103999995;
    
    leaderData12.Arrowhead = NXOpen.Annotations.LeaderData.ArrowheadType.FilledArrow;
    
    leaderData12.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Center;
    
    draftingNoteBuilder11.Leader.Leaders.Append(leaderData12);
    
    leaderData12.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Legacy;
    
    leaderData12.StubSide = NXOpen.Annotations.LeaderSide.Inferred;
    
    double symbolscale11;
    symbolscale11 = draftingNoteBuilder11.Text.TextBlock.SymbolScale;
    
    double symbolaspectratio11;
    symbolaspectratio11 = draftingNoteBuilder11.Text.TextBlock.SymbolAspectRatio;
    
    draftingNoteBuilder11.Origin.SetInferRelativeToGeometry(true);
    
    draftingNoteBuilder11.Origin.SetInferRelativeToGeometry(true);
    
    // ----------------------------------------------
    //   对话开始 注释
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId356;
    markId356 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.DeleteUndoMark(markId356, null);
    
    NXOpen.Session.UndoMarkId markId357;
    markId357 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId357, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId357, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId355, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId358;
    markId358 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId358, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId358, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId355, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId359;
    markId359 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    string[] text8 = new string[1];
    text8[0] = "<F34><C1.3>前端高点位于中心右侧<C><F>";
    draftingNoteBuilder11.Text.TextBlock.SetText(text8);
    
    theSession.SetUndoMarkName(markId359, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId359, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId355, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId360;
    markId360 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    NXOpen.Session.UndoMarkId markId361;
    markId361 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    NXOpen.NXObject nXObject26;
    nXObject26 = draftingNoteBuilder11.Commit();
    
    theSession.DeleteUndoMark(markId361, null);
    
    theSession.SetUndoMarkName(markId355, "注释");
    
    draftingNoteBuilder11.Destroy();
    
    theSession.DeleteUndoMark(markId360, null);
    
    theSession.SetUndoMarkVisibility(markId355, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.DeleteUndoMark(markId359, null);
    
    theSession.DeleteUndoMark(markId358, null);
    
    theSession.DeleteUndoMark(markId357, null);
    
    NXOpen.Point3d scaleAboutPoint1066 = new NXOpen.Point3d(81.458935854332381, 10.236432647181607, 0.0);
    NXOpen.Point3d viewCenter1066 = new NXOpen.Point3d(-81.458935854331713, -10.236432647181486, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1066, viewCenter1066);
    
    NXOpen.Point3d scaleAboutPoint1067 = new NXOpen.Point3d(103.9862964335171, 13.516416347510926, 0.0);
    NXOpen.Point3d viewCenter1067 = new NXOpen.Point3d(-103.9862964335164, -13.516416347510747, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1067, viewCenter1067);
    
    NXOpen.Point3d scaleAboutPoint1068 = new NXOpen.Point3d(131.78505938823105, 17.571341251764142, 0.0);
    NXOpen.Point3d viewCenter1068 = new NXOpen.Point3d(-131.78505938823037, -17.571341251764029, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1068, viewCenter1068);
    
    NXOpen.Point3d scaleAboutPoint1069 = new NXOpen.Point3d(165.85769226424799, 22.808952586424585, 0.0);
    NXOpen.Point3d viewCenter1069 = new NXOpen.Point3d(-165.85769226424728, -22.808952586424493, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1069, viewCenter1069);
    
    NXOpen.Point3d scaleAboutPoint1070 = new NXOpen.Point3d(208.37808535745941, 29.919150769229773, 0.0);
    NXOpen.Point3d viewCenter1070 = new NXOpen.Point3d(-208.37808535745847, -29.919150769229717, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1070, viewCenter1070);
    
    NXOpen.Point3d scaleAboutPoint1071 = new NXOpen.Point3d(135.51615348415882, -38.278913484161606, 0.0);
    NXOpen.Point3d viewCenter1071 = new NXOpen.Point3d(-135.51615348415774, 38.278913484161606, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1071, viewCenter1071);
    
    NXOpen.Point3d scaleAboutPoint1072 = new NXOpen.Point3d(108.41292278732712, -30.623130787329242, 0.0);
    NXOpen.Point3d viewCenter1072 = new NXOpen.Point3d(-108.41292278732605, 30.623130787329274, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1072, viewCenter1072);
    
    NXOpen.Point3d scaleAboutPoint1073 = new NXOpen.Point3d(86.7303382298619, -24.498504629863426, 0.0);
    NXOpen.Point3d viewCenter1073 = new NXOpen.Point3d(-86.730338229860735, 24.498504629863426, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1073, viewCenter1073);
    
    NXOpen.Point3d scaleAboutPoint1074 = new NXOpen.Point3d(69.384270583889588, -19.598803703890731, 0.0);
    NXOpen.Point3d viewCenter1074 = new NXOpen.Point3d(-69.384270583888451, 19.598803703890731, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1074, viewCenter1074);
    
    NXOpen.Point3d scaleAboutPoint1075 = new NXOpen.Point3d(55.327197582478334, -15.31860519384564, 0.0);
    NXOpen.Point3d viewCenter1075 = new NXOpen.Point3d(-55.327197582477197, 15.31860519384564, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1075, viewCenter1075);
    
    NXOpen.Point3d scaleAboutPoint1076 = new NXOpen.Point3d(44.838458496809878, -11.966533939662934, 0.0);
    NXOpen.Point3d viewCenter1076 = new NXOpen.Point3d(-44.838458496808748, 11.966533939662934, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1076, viewCenter1076);
    
    NXOpen.Point3d scaleAboutPoint1077 = new NXOpen.Point3d(35.986106883613473, -9.573227151730352, 0.0);
    NXOpen.Point3d viewCenter1077 = new NXOpen.Point3d(-35.986106883612337, 9.573227151730352, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1077, viewCenter1077);
    
    NXOpen.Point3d scaleAboutPoint1078 = new NXOpen.Point3d(28.881157575823224, -7.5663096524519426, 0.0);
    NXOpen.Point3d viewCenter1078 = new NXOpen.Point3d(-28.881157575822087, 7.5663096524519426, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1078, viewCenter1078);
    
    NXOpen.Point3d scaleAboutPoint1079 = new NXOpen.Point3d(23.178743715804565, -6.0530477219615513, 0.0);
    NXOpen.Point3d viewCenter1079 = new NXOpen.Point3d(-23.178743715803428, 6.0530477219615513, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1079, viewCenter1079);
    
    NXOpen.Point3d scaleAboutPoint1080 = new NXOpen.Point3d(18.661103220877145, -4.7833840534525418, 0.0);
    NXOpen.Point3d viewCenter1080 = new NXOpen.Point3d(-18.661103220876011, 4.7833840534525418, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1080, viewCenter1080);
    
    NXOpen.Point3d scaleAboutPoint1081 = new NXOpen.Point3d(15.023369175288551, -3.7794639434686754, 0.0);
    NXOpen.Point3d viewCenter1081 = new NXOpen.Point3d(-15.023369175287412, 3.7794639434686754, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1081, viewCenter1081);
    
    NXOpen.Point3d scaleAboutPoint1082 = new NXOpen.Point3d(18.632757241301153, -3.6660800251646188, 0.0);
    NXOpen.Point3d viewCenter1082 = new NXOpen.Point3d(-18.632757241300013, 3.6660800251646188, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1082, viewCenter1082);
    
    NXOpen.Point3d scaleAboutPoint1083 = new NXOpen.Point3d(23.054730055159485, -4.6770866300424849, 0.0);
    NXOpen.Point3d viewCenter1083 = new NXOpen.Point3d(-23.054730055158345, 4.6770866300424849, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1083, viewCenter1083);
    
    NXOpen.Point3d scaleAboutPoint1084 = new NXOpen.Point3d(28.050708955432132, -6.0235206599031974, 0.0);
    NXOpen.Point3d viewCenter1084 = new NXOpen.Point3d(-28.050708955430999, 6.0235206599031974, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1084, viewCenter1084);
    
    NXOpen.Point3d scaleAboutPoint1085 = new NXOpen.Point3d(29.969967989224845, -8.0461244109001129, 0.0);
    NXOpen.Point3d viewCenter1085 = new NXOpen.Point3d(-29.969967989223701, 8.0461244109001129, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1085, viewCenter1085);
    
    NXOpen.Point3d scaleAboutPoint1086 = new NXOpen.Point3d(28.235253093296841, -9.0426627553693972, 0.0);
    NXOpen.Point3d viewCenter1086 = new NXOpen.Point3d(-28.235253093295704, 9.0426627553693972, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1086, viewCenter1086);
    
    NXOpen.Point3d scaleAboutPoint1087 = new NXOpen.Point3d(34.948046108124643, -11.41866853037717, 0.0);
    NXOpen.Point3d viewCenter1087 = new NXOpen.Point3d(-34.948046108123506, 11.41866853037717, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1087, viewCenter1087);
    
    NXOpen.Point3d scaleAboutPoint1088 = new NXOpen.Point3d(43.252532312035285, -14.273335662971455, 0.0);
    NXOpen.Point3d viewCenter1088 = new NXOpen.Point3d(-43.252532312034155, 14.273335662971455, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1088, viewCenter1088);
    
    NXOpen.Point3d scaleAboutPoint1089 = new NXOpen.Point3d(57.129386428813071, -11.714227501176062, 0.0);
    NXOpen.Point3d viewCenter1089 = new NXOpen.Point3d(-57.129386428811934, 11.714227501176062, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1089, viewCenter1089);
    
    NXOpen.Point3d scaleAboutPoint1090 = new NXOpen.Point3d(71.411733036016244, -14.642784376470084, 0.0);
    NXOpen.Point3d viewCenter1090 = new NXOpen.Point3d(-71.411733036015093, 14.642784376470084, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1090, viewCenter1090);
    
    NXOpen.Session.UndoMarkId markId362;
    markId362 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Label label30 = ((NXOpen.Annotations.Label)workPart.FindObject("HANDLE R-83837"));
    label30.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin259 = new NXOpen.Point3d(689.56073572668799, 382.91647207126647, 0.0);
    label30.AnnotationOrigin = origin259;
    
    int nErrs243;
    nErrs243 = theSession.UpdateManager.DoUpdate(markId362);
    
    NXOpen.Session.UndoMarkId markId363;
    markId363 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "起点");
    
    NXOpen.Annotations.Note note80 = ((NXOpen.Annotations.Note)workPart.FindObject("ENTITY 25 8 1"));
    NXOpen.Annotations.DraftingNoteBuilder draftingNoteBuilder12;
    draftingNoteBuilder12 = workPart.Annotations.CreateDraftingNoteBuilder(note80);
    
    draftingNoteBuilder12.Text.TextBlock.CustomSymbolScale = 1.0;
    
    draftingNoteBuilder12.Origin.SetInferRelativeToGeometry(true);
    
    theSession.SetUndoMarkName(markId363, "注释 对话框");
    
    draftingNoteBuilder12.Origin.SetInferRelativeToGeometry(true);
    
    NXOpen.Annotations.LeaderData leaderData13;
    leaderData13 = workPart.Annotations.CreateLeaderData();
    
    leaderData13.StubSize = 3.5000000103999995;
    
    leaderData13.Arrowhead = NXOpen.Annotations.LeaderData.ArrowheadType.FilledArrow;
    
    leaderData13.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Center;
    
    draftingNoteBuilder12.Leader.Leaders.Append(leaderData13);
    
    leaderData13.VerticalAttachment = NXOpen.Annotations.LeaderVerticalAttachment.Legacy;
    
    leaderData13.StubSide = NXOpen.Annotations.LeaderSide.Inferred;
    
    double symbolscale12;
    symbolscale12 = draftingNoteBuilder12.Text.TextBlock.SymbolScale;
    
    double symbolaspectratio12;
    symbolaspectratio12 = draftingNoteBuilder12.Text.TextBlock.SymbolAspectRatio;
    
    draftingNoteBuilder12.Origin.SetInferRelativeToGeometry(true);
    
    draftingNoteBuilder12.Origin.SetInferRelativeToGeometry(true);
    
    // ----------------------------------------------
    //   对话开始 注释
    // ----------------------------------------------
    NXOpen.Session.UndoMarkId markId364;
    markId364 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.DeleteUndoMark(markId364, null);
    
    NXOpen.Session.UndoMarkId markId365;
    markId365 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId365, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId365, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId363, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId366;
    markId366 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    theSession.SetUndoMarkName(markId366, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId366, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId363, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId367;
    markId367 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    string[] text9 = new string[1];
    text9[0] = "<F34><C1.3>功能性鼻子<C><F>";
    draftingNoteBuilder12.Text.TextBlock.SetText(text9);
    
    theSession.SetUndoMarkName(markId367, "注释 - 文本输入");
    
    theSession.SetUndoMarkVisibility(markId367, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.SetUndoMarkVisibility(markId363, null, NXOpen.Session.MarkVisibility.Invisible);
    
    NXOpen.Session.UndoMarkId markId368;
    markId368 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    NXOpen.Session.UndoMarkId markId369;
    markId369 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "注释");
    
    NXOpen.NXObject nXObject27;
    nXObject27 = draftingNoteBuilder12.Commit();
    
    theSession.DeleteUndoMark(markId369, null);
    
    theSession.SetUndoMarkName(markId363, "注释");
    
    draftingNoteBuilder12.Destroy();
    
    theSession.DeleteUndoMark(markId368, null);
    
    theSession.SetUndoMarkVisibility(markId363, null, NXOpen.Session.MarkVisibility.Visible);
    
    theSession.DeleteUndoMark(markId367, null);
    
    theSession.DeleteUndoMark(markId366, null);
    
    theSession.DeleteUndoMark(markId365, null);
    
    NXOpen.Session.UndoMarkId markId370;
    markId370 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Edit Object Origin");
    
    NXOpen.Annotations.Note note81 = ((NXOpen.Annotations.Note)nXObject27);
    note81.LeaderOrientation = NXOpen.Annotations.LeaderOrientation.FromRight;
    
    NXOpen.Point3d origin260 = new NXOpen.Point3d(703.07715207419881, 382.35328805678688, 0.0);
    note81.AnnotationOrigin = origin260;
    
    int nErrs244;
    nErrs244 = theSession.UpdateManager.DoUpdate(markId370);
    
    NXOpen.Point3d scaleAboutPoint1091 = new NXOpen.Point3d(94.051730418096938, 53.502481375563768, 0.0);
    NXOpen.Point3d viewCenter1091 = new NXOpen.Point3d(-94.051730418095786, -53.502481375563768, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1091, viewCenter1091);
    
    NXOpen.Point3d scaleAboutPoint1092 = new NXOpen.Point3d(117.9166530316708, 64.766161665156176, 0.0);
    NXOpen.Point3d viewCenter1092 = new NXOpen.Point3d(-117.91665303166964, -64.766161665156119, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1092, viewCenter1092);
    
    NXOpen.Point3d scaleAboutPoint1093 = new NXOpen.Point3d(147.3958162895882, 79.637739547508545, 0.0);
    NXOpen.Point3d viewCenter1093 = new NXOpen.Point3d(-147.39581628958712, -79.637739547508545, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1093, viewCenter1093);
    
    NXOpen.Point3d scaleAboutPoint1094 = new NXOpen.Point3d(184.24477036198527, 98.447205656105211, 0.0);
    NXOpen.Point3d viewCenter1094 = new NXOpen.Point3d(-184.24477036198408, -98.447205656105211, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1094, viewCenter1094);
    
    NXOpen.Point3d scaleAboutPoint1095 = new NXOpen.Point3d(176.68248501130674, -74.247892533934106, 0.0);
    NXOpen.Point3d viewCenter1095 = new NXOpen.Point3d(-176.68248501130557, 74.247892533934049, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1095, viewCenter1095);
    
    NXOpen.Point3d scaleAboutPoint1096 = new NXOpen.Point3d(141.34598800904541, -59.398314027147229, 0.0);
    NXOpen.Point3d viewCenter1096 = new NXOpen.Point3d(-141.34598800904439, 59.398314027147187, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1096, viewCenter1096);
    
    NXOpen.Point3d scaleAboutPoint1097 = new NXOpen.Point3d(113.07679040723635, -47.518651221717818, 0.0);
    NXOpen.Point3d viewCenter1097 = new NXOpen.Point3d(-113.07679040723546, 47.518651221717711, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1097, viewCenter1097);
    
    NXOpen.Point3d scaleAboutPoint1098 = new NXOpen.Point3d(90.46143232578909, -38.01492097737431, 0.0);
    NXOpen.Point3d viewCenter1098 = new NXOpen.Point3d(-90.461432325788209, 38.01492097737416, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1098, viewCenter1098);
    
    NXOpen.Point3d scaleAboutPoint1099 = new NXOpen.Point3d(72.369145860631463, -30.693528789139261, 0.0);
    NXOpen.Point3d viewCenter1099 = new NXOpen.Point3d(-72.369145860630567, 30.693528789139144, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1099, viewCenter1099);
    
    NXOpen.Point3d scaleAboutPoint1100 = new NXOpen.Point3d(57.67004308271337, -24.780096637103302, 0.0);
    NXOpen.Point3d viewCenter1100 = new NXOpen.Point3d(-57.670043082712468, 24.780096637103135, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(1.25, scaleAboutPoint1100, viewCenter1100);
    
    NXOpen.Point3d scaleAboutPoint1101 = new NXOpen.Point3d(77.854558161662894, -5.2263476543709197, 0.0);
    NXOpen.Point3d viewCenter1101 = new NXOpen.Point3d(-77.854558161661998, 5.226347654370799, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1101, viewCenter1101);
    
    NXOpen.Point3d scaleAboutPoint1102 = new NXOpen.Point3d(97.768744913662161, -6.3076609621717861, 0.0);
    NXOpen.Point3d viewCenter1102 = new NXOpen.Point3d(-97.768744913661294, 6.3076609621716733, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1102, viewCenter1102);
    
    NXOpen.Point3d scaleAboutPoint1103 = new NXOpen.Point3d(122.21093114207773, -7.6029841954749067, 0.0);
    NXOpen.Point3d viewCenter1103 = new NXOpen.Point3d(-122.21093114207675, 7.6029841954748134, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1103, viewCenter1103);
    
    NXOpen.Point3d scaleAboutPoint1104 = new NXOpen.Point3d(152.41167391854725, -9.1517402352938753, 0.0);
    NXOpen.Point3d viewCenter1104 = new NXOpen.Point3d(-152.41167391854631, 9.151740235293758, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1104, viewCenter1104);
    
    NXOpen.Point3d scaleAboutPoint1105 = new NXOpen.Point3d(190.51459239818396, -11.439675294117309, 0.0);
    NXOpen.Point3d viewCenter1105 = new NXOpen.Point3d(-190.51459239818303, 11.439675294117199, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1105, viewCenter1105);
    
    NXOpen.Point3d scaleAboutPoint1106 = new NXOpen.Point3d(218.89378687782073, -17.049516063347895, 0.0);
    NXOpen.Point3d viewCenter1106 = new NXOpen.Point3d(-218.89378687781991, 17.04951606334776, 0.0);
    workPart.Views.WorkView.ZoomAboutPoint(0.80000000000000004, scaleAboutPoint1106, viewCenter1106);
    
    // ----------------------------------------------
    //   菜单：工具(T)->操作记录(J)->停止录制(S)
    // ----------------------------------------------
    
  }
  public static int GetUnloadOption(string dummy) { return (int)NXOpen.Session.LibraryUnloadOption.Immediately; }
}
