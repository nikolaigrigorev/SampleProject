using Presenters;

namespace Models
{
	public class RootModel : IRootModel
	{
		private readonly IUpdateableModel _appInitModel;
		private readonly IUpdateableModel _timeModel;

		public RootModel(IUpdateableModel appInitModel, IUpdateableModel timeModel)
		{
			_appInitModel = appInitModel;
			_timeModel = timeModel;
		}
		
		public void Update()
		{
			//control of update order between models to evade skipping frames
			
			_timeModel.Update();
			_appInitModel.Update();
		}
	}
}